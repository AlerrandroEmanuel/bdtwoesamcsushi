using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace WinFormsApp_SGBD_POO_BD
{
    public partial class Form3 : Form
    {
        string pastaXML = @"C:\Users\Dora\source\repos\WinFormsApp_SGBD_POO_BD\xmlindependentes";

        public Form3()
        {
            InitializeComponent();
        }

        private void listarxml_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void desserializarxml_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void digitarxml_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void desserializarxmlform2_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeArquivo = digitarxml_box.Text.Trim();

                if (string.IsNullOrWhiteSpace(nomeArquivo))
                {
                    MessageBox.Show("Digite o nome do arquivo, por exemplo: produtos.xml");
                    return;
                }

                string caminho = Path.Combine(pastaXML, nomeArquivo);

                if (!File.Exists(caminho))
                {
                    MessageBox.Show("Arquivo não encontrado em C:\\xml.");
                    return;
                }

                DataTable tabela = ConverterXmlParaDataTable(caminho);
                desserializarxml_DataGridView.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao desserializar XML:\n" + ex.Message);
            }
        }

        private DataTable ConverterXmlParaDataTable(string caminhoXml)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(caminhoXml);

            // Se houver mais de uma tabela, pega a primeira
            if (dataSet.Tables.Count > 0)
                return dataSet.Tables[0];

            // Se o XML não pôde ser convertido diretamente, tentamos converter manualmente
            DataTable tabela = new DataTable("XML");

            XDocument doc = XDocument.Load(caminhoXml);
            var itens = doc.Root.Elements();

            if (!itens.Any())
                return tabela;

            // Criar colunas dinamicamente
            foreach (var elem in itens.First().Elements())
            {
                tabela.Columns.Add(elem.Name.LocalName);
            }

            // Inserir dados
            foreach (var item in itens)
            {
                DataRow row = tabela.NewRow();

                foreach (var elem in item.Elements())
                {
                    row[elem.Name.LocalName] = elem.Value;
                }

                tabela.Rows.Add(row);
            }

            return tabela;
        }

        private void listarxml_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(pastaXML))
                {
                    MessageBox.Show("A pasta C:\\xml não existe.");
                    return;
                }

                string[] arquivos = Directory.GetFiles(pastaXML, "*.xml", SearchOption.TopDirectoryOnly);

                DataTable tabela = new DataTable();
                tabela.Columns.Add("Nome do Arquivo");
                tabela.Columns.Add("Caminho Completo");

                foreach (string arquivo in arquivos)
                {
                    tabela.Rows.Add(Path.GetFileName(arquivo), arquivo);
                }

                listarxml_DataGridView.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar arquivos XML:\n" + ex.Message);
            }
        }
    }
}
