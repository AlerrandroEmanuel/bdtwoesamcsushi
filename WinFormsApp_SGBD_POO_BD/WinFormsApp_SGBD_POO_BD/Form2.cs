using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Text.Json;
using System.IO;

namespace WinFormsApp_SGBD_POO_BD
{
    public partial class Form2 : Form
    {

        private string connString;

        public Form2(string connectionString)
        {
            InitializeComponent();
            this.connString = connectionString;
        }

        private void readfuncionario_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(this.connString))
                {
                    conn.Open();

                    string sql = "SELECT * FROM vendedores ORDER BY id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        gridviewsgdb.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler vendedores: " + ex.Message);
            }
        }

        private void createfuncionario_btn_Click(object sender, EventArgs e)
        {
            string nome = nomevendedor_box.Text;
            string idade = idadevendedor_box.Text;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(idade))
            {
                MessageBox.Show("Preencha NOME e IDADE.");
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(this.connString))
                {
                    conn.Open();

                    string sql = "INSERT INTO vendedores (nome, idade) VALUES (@nome, @idade)";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@idade", int.Parse(idade));

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Vendedor inserido com sucesso!");
                readfuncionario_btn_Click(sender, e); // Atualiza tabela
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir vendedor: " + ex.Message);
            }
        }

        private void updatefuncionario_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idvendedor_box.Text))
            {
                MessageBox.Show("Informe o ID do vendedor que deseja atualizar.");
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(this.connString))
                {
                    conn.Open();

                    string sql = "UPDATE vendedores SET nome=@nome, idade=@idade WHERE id=@id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(idvendedor_box.Text));
                        cmd.Parameters.AddWithValue("@nome", nomevendedor_box.Text);
                        cmd.Parameters.AddWithValue("@idade", int.Parse(idadevendedor_box.Text));

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                            MessageBox.Show("Vendedor atualizado!");
                        else
                            MessageBox.Show("ID não encontrado.");
                    }
                }

                readfuncionario_btn_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar vendedor: " + ex.Message);
            }
        }

        private void deletefuncionario_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idvendedor_box.Text))
            {
                MessageBox.Show("Informe o ID para excluir.");
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(this.connString))
                {
                    conn.Open();

                    string sql = "DELETE FROM vendedores WHERE id=@id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(idvendedor_box.Text));

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                            MessageBox.Show("Vendedor removido!");
                        else
                            MessageBox.Show("ID não encontrado.");
                    }
                }

                readfuncionario_btn_Click(sender, e); // Atualiza grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover vendedor: " + ex.Message);
            }
        }

        private void idvendedor_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomevendedor_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void idadevendedor_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void readproduto_box_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(this.connString))
                {
                    conn.Open();

                    string sql = "SELECT * FROM produtos ORDER BY id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        gridviewsgdb.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler produtos: " + ex.Message);
            }
        }

        private void createproduto_box_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nomeproduto_box.Text) ||
        string.IsNullOrWhiteSpace(priceproduto_box.Text) ||
        string.IsNullOrWhiteSpace(quantidadeproduto_box.Text))
            {
                MessageBox.Show("Preencha nome, preço e quantidade.");
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(this.connString))
                {
                    conn.Open();

                    string sql = "INSERT INTO produtos (nome, preco, quantidade) VALUES (@nome, @preco, @quantidade)";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", nomeproduto_box.Text);
                        cmd.Parameters.AddWithValue("@preco", decimal.Parse(priceproduto_box.Text));
                        cmd.Parameters.AddWithValue("@quantidade", int.Parse(quantidadeproduto_box.Text));

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Produto inserido com sucesso!");
                readproduto_box_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir produto: " + ex.Message);
            }
        }

        private void updateproduto_box_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idproduto_box.Text))
            {
                MessageBox.Show("Informe o ID do produto que deseja atualizar.");
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(this.connString))
                {
                    conn.Open();

                    string sql = "UPDATE produtos SET nome=@nome, preco=@preco, quantidade=@quantidade WHERE id=@id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(idproduto_box.Text));
                        cmd.Parameters.AddWithValue("@nome", nomeproduto_box.Text);
                        cmd.Parameters.AddWithValue("@preco", decimal.Parse(priceproduto_box.Text));
                        cmd.Parameters.AddWithValue("@quantidade", int.Parse(quantidadeproduto_box.Text));

                        int rows = cmd.ExecuteNonQuery();

                        MessageBox.Show(rows > 0 ? "Produto atualizado!" : "ID não encontrado.");
                    }
                }

                readproduto_box_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar produto: " + ex.Message);
            }
        }

        private void deleteproduto_box_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idproduto_box.Text))
            {
                MessageBox.Show("Informe o ID do produto que deseja excluir.");
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(this.connString))
                {
                    conn.Open();

                    string sql = "DELETE FROM produtos WHERE id=@id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(idproduto_box.Text));

                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show(rows > 0 ? "Produto removido!" : "ID não encontrado.");
                    }
                }

                readproduto_box_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover produto: " + ex.Message);
            }
        }

        private void idproduto_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeproduto_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantidadeproduto_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void exportarxmlbd_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(this.connString))
                {
                    conn.Open();

                    string sql = "SELECT id, criado_em AS datahora, conteudo AS xmlconteudo FROM logs_produtos_xml ORDER BY id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        gridviewsgdb.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler logs XML: " + ex.Message);
            }
        }

        private void exportarjsonbd_btn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = new NpgsqlConnection(this.connString))
                {
                    conn.Open();

                    string sql = "SELECT id, criado_em AS datahora, conteudo AS jsonconteudo FROM logs_produtos_json ORDER BY id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        gridviewsgdb.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ler logs JSON: " + ex.Message);
            }
        }

        private void iddesserializarxml_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void iddesserializarjson_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void desserializarxml_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(iddesserializarxml_box.Text))
            {
                MessageBox.Show("Digite o ID do XML que deseja desserializar.");
                return;
            }

            try
            {
                string xmlConteudo = "";

                // 1) Buscar o XML no banco (coluna 'conteudo')
                using (var conn = new NpgsqlConnection(this.connString))
                {
                    conn.Open();

                    string sql = "SELECT conteudo FROM logs_produtos_xml WHERE id = @id";

                    using (var cmd = new Npgsql.NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(iddesserializarxml_box.Text));
                        object result = cmd.ExecuteScalar();
                        if (result == null)
                        {
                            MessageBox.Show("ID não encontrado.");
                            return;
                        }

                        // Se o tipo retornado for XML do PG, ToString() geralmente traz o XML.
                        xmlConteudo = result.ToString();
                    }
                }

                // Opcional: salvar em arquivo temporário para inspecionar
                try
                {
                    string tmp = Path.Combine(Path.GetTempPath(), $"xml_debug_{Guid.NewGuid():N}.xml");
                    System.IO.File.WriteAllText(tmp, xmlConteudo, Encoding.UTF8);
                    // MessageBox.Show($"XML salvo temporariamente em: {tmp}"); // descomente se quiser ver o caminho
                }
                catch { /* não crítico */ }

                // 2) Validar XML bem formado
                try
                {
                    var xd = new XmlDocument();
                    xd.LoadXml(xmlConteudo); // lança se não for bem formado
                }
                catch (Exception xmlEx)
                {
                    MessageBox.Show("Conteúdo recuperado NÃO é um XML bem formado:\n" + xmlEx.Message);
                    return;
                }

                // 3) Tentar desserializar para ProdutoXML (um único)
                try
                {
                    var serializer = new XmlSerializer(typeof(ProdutoXML));
                    using (var reader = new System.IO.StringReader(xmlConteudo))
                    {
                        var produto = (ProdutoXML)serializer.Deserialize(reader);

                        // mostrar único produto no grid
                        DataTable dt = new DataTable();
                        dt.Columns.Add("Id");
                        dt.Columns.Add("Nome");
                        dt.Columns.Add("Preco");
                        dt.Columns.Add("Quantidade");

                        dt.Rows.Add(produto.Id, produto.Nome, produto.Preco, produto.Quantidade);
                        gridviewsgdb.DataSource = dt;
                        return;
                    }
                }
                catch
                {
                    // falhou — pode ser lista ou outra estrutura; tentaremos outra estratégia abaixo
                }

                // 4) Tentar desserializar para array/lista de ProdutoXML
                try
                {
                    var serializer = new XmlSerializer(typeof(ProdutoXML[]), new XmlRootAttribute("Produtos"));
                    using (var reader = new System.IO.StringReader(xmlConteudo))
                    {
                        var produtos = (ProdutoXML[])serializer.Deserialize(reader);
                        if (produtos != null && produtos.Length > 0)
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add("Id");
                            dt.Columns.Add("Nome");
                            dt.Columns.Add("Preco");
                            dt.Columns.Add("Quantidade");

                            foreach (var p in produtos)
                                dt.Rows.Add(p.Id, p.Nome, p.Preco, p.Quantidade);

                            gridviewsgdb.DataSource = dt;
                            return;
                        }
                    }
                }
                catch
                {
                    // ignora e segue para conversão genérica
                }

                // 5) Por fim: converter GENERICAMENTE o XML para DataTable (método do Form3)
                DataTable tabelaGenerica = ConverterXmlParaDataTable_Generico(xmlConteudo);
                if (tabelaGenerica != null)
                {
                    gridviewsgdb.DataSource = tabelaGenerica;
                    return;
                }

                // Se chegou aqui, não conseguimos transformar
                MessageBox.Show("Não foi possível desserializar o XML para um objeto conhecido. Ele foi validado como XML bem formado; exiba-o em modo genérico.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao desserializar XML: " + ex.Message);
            }
        }

        private void desserializarjson_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(iddesserializarjson_box.Text))
            {
                MessageBox.Show("Digite o ID do JSON que deseja desserializar.");
                return;
            }

            try
            {
                string jsonConteudo = "";

                // 1) Buscar JSON no banco
                using (var conn = new NpgsqlConnection(this.connString))
                {
                    conn.Open();

                    string sql = "SELECT conteudo FROM logs_produtos_json WHERE id = @id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", int.Parse(iddesserializarjson_box.Text));

                        object result = cmd.ExecuteScalar();
                        if (result == null)
                        {
                            MessageBox.Show("ID não encontrado.");
                            return;
                        }

                        jsonConteudo = result.ToString();
                    }
                }

                // 2) Converter JSON → DataTable (GENÉRICO)
                DataTable tabela = ConverterJsonParaDataTable_Generico(jsonConteudo);

                // 3) Mostrar no Grid
                gridviewsgdb.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao desserializar JSON: " + ex.Message);
            }
        }

        private void richTextquery_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridviewsgdb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void executarquery_btn_Click(object sender, EventArgs e)
        {
            string query = richTextquery.Text.Trim();

            if (string.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("Digite uma query SQL primeiro.");
                return;
            }

            try
            {
                using (var conn = new NpgsqlConnection(this.connString))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        // Verifica se a query começa com SELECT
                        if (query.StartsWith("SELECT", StringComparison.OrdinalIgnoreCase))
                        {
                            using (var da = new NpgsqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                da.Fill(dt);

                                gridviewsgdb.DataSource = dt;
                            }
                        }
                        else
                        {
                            // Executa comandos como INSERT, UPDATE, DELETE, CREATE, DROP...
                            int linhas = cmd.ExecuteNonQuery();

                            MessageBox.Show($"Comando executado com sucesso! Linhas afetadas: {linhas}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar a query: " + ex.Message);
            }
        }

        private void priceproduto_box_TextChanged(object sender, EventArgs e)
        {

        }

        private DataTable ConverterXmlParaDataTable_Generico(string xmlString)
        {
            try
            {
                // tentar com DataSet.ReadXml usando um StringReader
                DataSet ds = new DataSet();
                using (var sr = new System.IO.StringReader(xmlString))
                {
                    ds.ReadXml(sr);
                }

                if (ds.Tables.Count > 0)
                    return ds.Tables[0];

                // fallback com LINQ to XML (mesma lógica usada no Form3)
                XDocument doc = XDocument.Parse(xmlString);
                var itens = doc.Root.Elements();
                if (!itens.Any())
                    return null;

                DataTable tabela = new DataTable("XML");

                // criar colunas com base no primeiro elemento
                foreach (var elem in itens.First().Elements())
                    tabela.Columns.Add(elem.Name.LocalName);

                foreach (var item in itens)
                {
                    DataRow row = tabela.NewRow();
                    foreach (var elem in item.Elements())
                        row[elem.Name.LocalName] = elem.Value;
                    tabela.Rows.Add(row);
                }

                return tabela;
            }
            catch
            {
                return null;
            }
        }

        private DataTable ConverterJsonParaDataTable_Generico(string json)
        {
            var tabela = new DataTable();

            JsonNode node = JsonNode.Parse(json);

            // Caso seja uma LISTA JSON
            if (node is JsonArray array)
            {
                if (array.Count == 0)
                    return tabela;

                // Usar o primeiro objeto como modelo
                var firstObj = array[0].AsObject();

                foreach (var prop in firstObj)
                    tabela.Columns.Add(prop.Key);

                foreach (var item in array)
                {
                    var row = tabela.NewRow();
                    foreach (var prop in item.AsObject())
                        row[prop.Key] = prop.Value?.ToString() ?? "";
                    tabela.Rows.Add(row);
                }

                return tabela;
            }

            // Caso seja um OBJETO JSON
            if (node is JsonObject obj)
            {
                foreach (var prop in obj)
                    tabela.Columns.Add(prop.Key);

                DataRow row = tabela.NewRow();

                foreach (var prop in obj)
                    row[prop.Key] = prop.Value?.ToString() ?? "";

                tabela.Rows.Add(row);

                return tabela;
            }

            throw new Exception("Formato JSON não reconhecido.");
        }

        private void gravarjson_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Carregar produtos do banco
                List<ProdutoJSON> lista = CarregarProdutosJSONDoBanco();

                if (lista.Count == 0)
                {
                    MessageBox.Show("Nenhum produto encontrado.");
                    return;
                }

                // 2. Serializar a lista em JSON
                string jsonGerado = JsonSerializer.Serialize(lista, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                // 3. Salvar no banco
                SalvarJsonNoBanco(jsonGerado);

                MessageBox.Show("JSON dos produtos gravado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar JSON: " + ex.Message);
            }
        }

        private void gravarxml_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Carregar os produtos do banco em uma lista
                List<ProdutoXML> listaProdutos = CarregarProdutosDoBanco();

                if (listaProdutos.Count == 0)
                {
                    MessageBox.Show("Nenhum produto encontrado no banco.");
                    return;
                }

                // 2. Serializar a lista em XML
                string xmlGerado = SerializarProdutosParaXML(listaProdutos);

                // 3. Inserir XML na tabela logs_produtos_xml
                SalvarXmlNoBanco(xmlGerado);

                MessageBox.Show("XML dos produtos gravado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar XML: " + ex.Message);
            }
        }

        private List<ProdutoXML> CarregarProdutosDoBanco()
        {
            List<ProdutoXML> lista = new List<ProdutoXML>();

            using (var conn = new NpgsqlConnection(this.connString))
            {
                conn.Open();

                string sql = "SELECT id, nome, preco, quantidade FROM produtos";

                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new ProdutoXML
                        {
                            Id = reader.GetInt32(0),
                            Nome = reader.GetString(1),
                            Preco = reader.GetDecimal(2),
                            Quantidade = reader.GetInt32(3)
                        });
                    }
                }
            }

            return lista;
        }

        private string SerializarProdutosParaXML(List<ProdutoXML> produtos)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<ProdutoXML>));

            StringWriter sw = new StringWriter();
            serializer.Serialize(sw, produtos);

            return sw.ToString();
        }

        private void SalvarXmlNoBanco(string xmlConteudo)
        {
            using (var conn = new NpgsqlConnection(this.connString))
            {
                conn.Open();

                string sql = @"INSERT INTO logs_produtos_xml (criado_em, conteudo)
                       VALUES (NOW(), @conteudo)";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@conteudo", NpgsqlTypes.NpgsqlDbType.Xml).Value = xmlConteudo;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private List<ProdutoJSON> CarregarProdutosJSONDoBanco()
        {
            List<ProdutoJSON> lista = new List<ProdutoJSON>();

            using (var conn = new NpgsqlConnection(this.connString))
            {
                conn.Open();

                string sql = "SELECT id, nome, preco, quantidade FROM produtos";

                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new ProdutoJSON
                        {
                            id = reader.GetInt32(0),
                            nome = reader.GetString(1),
                            preco = reader.GetDecimal(2),
                            quantidade = reader.GetInt32(3)
                        });
                    }
                }
            }

            return lista;
        }

        private void SalvarJsonNoBanco(string json)
        {
            using (var conn = new NpgsqlConnection(this.connString))
            {
                conn.Open();

                string sql = @"INSERT INTO logs_produtos_json (conteudo, criado_em)
                       VALUES (@json, NOW())";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@json", NpgsqlTypes.NpgsqlDbType.Json).Value = json;
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}
