using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_SGBD_POO_BD
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void linkJSON_box_TextChanged(object sender, EventArgs e)
        {

        }

        private async void desserializarjson_btn_Click(object sender, EventArgs e)
        {
            string url = linkJSON_box.Text.Trim();

            if (string.IsNullOrWhiteSpace(url))
            {
                MessageBox.Show("Cole um link de API JSON na caixa.");
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string jsonStr = await client.GetStringAsync(url);

                    DataTable tabela = ConverterJsonParaDataTable(jsonStr);

                    JSONdesserializadodataGridView.DataSource = tabela;

                    MessageBox.Show("JSON carregado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao desserializar a API JSON:\n" + ex.Message);
            }
        }

        private void JSONdesserializadodataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private DataTable ConverterJsonParaDataTable(string json)
        {
            var tabela = new DataTable();

            try
            {
                // Tentativa 1: JSON como lista/array
                using JsonDocument doc = JsonDocument.Parse(json);

                if (doc.RootElement.ValueKind == JsonValueKind.Array)
                {
                    return ConverterArrayParaDataTable(doc.RootElement);
                }
                else if (doc.RootElement.ValueKind == JsonValueKind.Object)
                {
                    return ConverterObjetoParaDataTable(doc.RootElement);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao converter JSON para DataTable.");
            }

            return tabela;
        }

        private DataTable ConverterArrayParaDataTable(JsonElement array)
        {
            DataTable tabela = new DataTable();

            if (array.GetArrayLength() == 0)
                return tabela;

            // Criar colunas dinamicamente
            foreach (var prop in array[0].EnumerateObject())
            {
                tabela.Columns.Add(prop.Name);
            }

            // Inserir linhas
            foreach (var item in array.EnumerateArray())
            {
                DataRow row = tabela.NewRow();

                foreach (var prop in item.EnumerateObject())
                {
                    row[prop.Name] = prop.Value.ToString();
                }

                tabela.Rows.Add(row);
            }

            return tabela;
        }

        private DataTable ConverterObjetoParaDataTable(JsonElement obj)
        {
            DataTable tabela = new DataTable();
            tabela.Columns.Add("Propriedade");
            tabela.Columns.Add("Valor");

            foreach (var prop in obj.EnumerateObject())
            {
                tabela.Rows.Add(prop.Name, prop.Value.ToString());
            }

            return tabela;
        }


    }
}
