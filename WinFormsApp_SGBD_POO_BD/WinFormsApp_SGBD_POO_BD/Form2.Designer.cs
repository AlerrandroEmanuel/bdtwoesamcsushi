namespace WinFormsApp_SGBD_POO_BD
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            label5 = new Label();
            richTextquery = new RichTextBox();
            label1 = new Label();
            executarquery_btn = new Button();
            gridviewsgdb = new DataGridView();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            readfuncionario_btn = new Button();
            label6 = new Label();
            idvendedor_box = new TextBox();
            nomevendedor_box = new TextBox();
            label7 = new Label();
            idadevendedor_box = new TextBox();
            label8 = new Label();
            createfuncionario_btn = new Button();
            updatefuncionario_btn = new Button();
            deletefuncionario_btn = new Button();
            deleteproduto_box = new Button();
            updateproduto_box = new Button();
            createproduto_box = new Button();
            readproduto_box = new Button();
            idproduto_box = new TextBox();
            label9 = new Label();
            nomeproduto_box = new TextBox();
            label10 = new Label();
            precoproduto_box = new Label();
            quantidadeproduto_box = new TextBox();
            label11 = new Label();
            exportarxmlbd_btn = new Button();
            label12 = new Label();
            label13 = new Label();
            iddesserializarxml_box = new TextBox();
            iddesserializarjson_box = new TextBox();
            desserializarxml_btn = new Button();
            desserializarjson_btn = new Button();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            exportarjsonbd_btn = new Button();
            priceproduto_box = new TextBox();
            gravarxml_btn = new Button();
            gravarjson_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridviewsgdb).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(65, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 112);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Aqua;
            label5.Location = new Point(170, 19);
            label5.Name = "label5";
            label5.Size = new Size(322, 145);
            label5.TabIndex = 17;
            label5.Text = "SGDB";
            // 
            // richTextquery
            // 
            richTextquery.Location = new Point(1266, 167);
            richTextquery.Name = "richTextquery";
            richTextquery.Size = new Size(603, 656);
            richTextquery.TabIndex = 19;
            richTextquery.Text = "";
            richTextquery.TextChanged += richTextquery_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Aqua;
            label1.Location = new Point(1266, 108);
            label1.Name = "label1";
            label1.Size = new Size(370, 37);
            label1.TabIndex = 20;
            label1.Text = "Lugar para Inserir sua query:";
            // 
            // executarquery_btn
            // 
            executarquery_btn.BackColor = Color.Aqua;
            executarquery_btn.BackgroundImageLayout = ImageLayout.None;
            executarquery_btn.FlatStyle = FlatStyle.Flat;
            executarquery_btn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            executarquery_btn.ForeColor = Color.Black;
            executarquery_btn.Location = new Point(1680, 111);
            executarquery_btn.Margin = new Padding(0);
            executarquery_btn.Name = "executarquery_btn";
            executarquery_btn.Size = new Size(189, 38);
            executarquery_btn.TabIndex = 21;
            executarquery_btn.Text = "Executar";
            executarquery_btn.UseMnemonic = false;
            executarquery_btn.UseVisualStyleBackColor = false;
            executarquery_btn.Click += executarquery_btn_Click;
            // 
            // gridviewsgdb
            // 
            gridviewsgdb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridviewsgdb.Location = new Point(664, 167);
            gridviewsgdb.Name = "gridviewsgdb";
            gridviewsgdb.RowHeadersWidth = 51;
            gridviewsgdb.Size = new Size(573, 656);
            gridviewsgdb.TabIndex = 22;
            gridviewsgdb.CellContentClick += gridviewsgdb_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Aqua;
            label2.Location = new Point(826, 112);
            label2.Name = "label2";
            label2.Size = new Size(242, 37);
            label2.TabIndex = 23;
            label2.Text = "Veja os resultados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Aqua;
            label4.Location = new Point(63, 179);
            label4.Name = "label4";
            label4.Size = new Size(159, 28);
            label4.TabIndex = 24;
            label4.Text = "CRUD Vendedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Aqua;
            label3.Location = new Point(63, 337);
            label3.Name = "label3";
            label3.Size = new Size(142, 28);
            label3.TabIndex = 25;
            label3.Text = "CRUD Produto";
            // 
            // readfuncionario_btn
            // 
            readfuncionario_btn.BackColor = Color.Aqua;
            readfuncionario_btn.BackgroundImageLayout = ImageLayout.None;
            readfuncionario_btn.FlatStyle = FlatStyle.Flat;
            readfuncionario_btn.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            readfuncionario_btn.ForeColor = Color.Black;
            readfuncionario_btn.Location = new Point(236, 179);
            readfuncionario_btn.Margin = new Padding(0);
            readfuncionario_btn.Name = "readfuncionario_btn";
            readfuncionario_btn.Size = new Size(77, 28);
            readfuncionario_btn.TabIndex = 26;
            readfuncionario_btn.Text = "READ";
            readfuncionario_btn.UseMnemonic = false;
            readfuncionario_btn.UseVisualStyleBackColor = false;
            readfuncionario_btn.Click += readfuncionario_btn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Aqua;
            label6.Location = new Point(65, 228);
            label6.Name = "label6";
            label6.Size = new Size(24, 21);
            label6.TabIndex = 28;
            label6.Text = "ID";
            // 
            // idvendedor_box
            // 
            idvendedor_box.Location = new Point(65, 261);
            idvendedor_box.Name = "idvendedor_box";
            idvendedor_box.Size = new Size(59, 27);
            idvendedor_box.TabIndex = 29;
            idvendedor_box.TextChanged += idvendedor_box_TextChanged;
            // 
            // nomevendedor_box
            // 
            nomevendedor_box.Location = new Point(155, 261);
            nomevendedor_box.Name = "nomevendedor_box";
            nomevendedor_box.Size = new Size(321, 27);
            nomevendedor_box.TabIndex = 31;
            nomevendedor_box.TextChanged += nomevendedor_box_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Aqua;
            label7.Location = new Point(155, 228);
            label7.Name = "label7";
            label7.Size = new Size(50, 21);
            label7.TabIndex = 30;
            label7.Text = "Nome";
            // 
            // idadevendedor_box
            // 
            idadevendedor_box.Location = new Point(504, 261);
            idadevendedor_box.Name = "idadevendedor_box";
            idadevendedor_box.Size = new Size(81, 27);
            idadevendedor_box.TabIndex = 33;
            idadevendedor_box.TextChanged += idadevendedor_box_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Aqua;
            label8.Location = new Point(504, 228);
            label8.Name = "label8";
            label8.Size = new Size(51, 21);
            label8.TabIndex = 32;
            label8.Text = "Idade";
            // 
            // createfuncionario_btn
            // 
            createfuncionario_btn.BackColor = Color.Aqua;
            createfuncionario_btn.BackgroundImageLayout = ImageLayout.None;
            createfuncionario_btn.FlatStyle = FlatStyle.Flat;
            createfuncionario_btn.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createfuncionario_btn.ForeColor = Color.Black;
            createfuncionario_btn.Location = new Point(327, 179);
            createfuncionario_btn.Margin = new Padding(0);
            createfuncionario_btn.Name = "createfuncionario_btn";
            createfuncionario_btn.Size = new Size(77, 28);
            createfuncionario_btn.TabIndex = 34;
            createfuncionario_btn.Text = "CREATE";
            createfuncionario_btn.UseMnemonic = false;
            createfuncionario_btn.UseVisualStyleBackColor = false;
            createfuncionario_btn.Click += createfuncionario_btn_Click;
            // 
            // updatefuncionario_btn
            // 
            updatefuncionario_btn.BackColor = Color.Aqua;
            updatefuncionario_btn.BackgroundImageLayout = ImageLayout.None;
            updatefuncionario_btn.FlatStyle = FlatStyle.Flat;
            updatefuncionario_btn.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updatefuncionario_btn.ForeColor = Color.Black;
            updatefuncionario_btn.Location = new Point(415, 179);
            updatefuncionario_btn.Margin = new Padding(0);
            updatefuncionario_btn.Name = "updatefuncionario_btn";
            updatefuncionario_btn.Size = new Size(77, 28);
            updatefuncionario_btn.TabIndex = 35;
            updatefuncionario_btn.Text = "UPDATE";
            updatefuncionario_btn.UseMnemonic = false;
            updatefuncionario_btn.UseVisualStyleBackColor = false;
            updatefuncionario_btn.Click += updatefuncionario_btn_Click;
            // 
            // deletefuncionario_btn
            // 
            deletefuncionario_btn.BackColor = Color.Aqua;
            deletefuncionario_btn.BackgroundImageLayout = ImageLayout.None;
            deletefuncionario_btn.FlatStyle = FlatStyle.Flat;
            deletefuncionario_btn.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deletefuncionario_btn.ForeColor = Color.Black;
            deletefuncionario_btn.Location = new Point(504, 179);
            deletefuncionario_btn.Margin = new Padding(0);
            deletefuncionario_btn.Name = "deletefuncionario_btn";
            deletefuncionario_btn.Size = new Size(77, 28);
            deletefuncionario_btn.TabIndex = 36;
            deletefuncionario_btn.Text = "DELETE";
            deletefuncionario_btn.UseMnemonic = false;
            deletefuncionario_btn.UseVisualStyleBackColor = false;
            deletefuncionario_btn.Click += deletefuncionario_btn_Click;
            // 
            // deleteproduto_box
            // 
            deleteproduto_box.BackColor = Color.Aqua;
            deleteproduto_box.BackgroundImageLayout = ImageLayout.None;
            deleteproduto_box.FlatStyle = FlatStyle.Flat;
            deleteproduto_box.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteproduto_box.ForeColor = Color.Black;
            deleteproduto_box.Location = new Point(504, 337);
            deleteproduto_box.Margin = new Padding(0);
            deleteproduto_box.Name = "deleteproduto_box";
            deleteproduto_box.Size = new Size(77, 28);
            deleteproduto_box.TabIndex = 40;
            deleteproduto_box.Text = "DELETE";
            deleteproduto_box.UseMnemonic = false;
            deleteproduto_box.UseVisualStyleBackColor = false;
            deleteproduto_box.Click += deleteproduto_box_Click;
            // 
            // updateproduto_box
            // 
            updateproduto_box.BackColor = Color.Aqua;
            updateproduto_box.BackgroundImageLayout = ImageLayout.None;
            updateproduto_box.FlatStyle = FlatStyle.Flat;
            updateproduto_box.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateproduto_box.ForeColor = Color.Black;
            updateproduto_box.Location = new Point(415, 337);
            updateproduto_box.Margin = new Padding(0);
            updateproduto_box.Name = "updateproduto_box";
            updateproduto_box.Size = new Size(77, 28);
            updateproduto_box.TabIndex = 39;
            updateproduto_box.Text = "UPDATE";
            updateproduto_box.UseMnemonic = false;
            updateproduto_box.UseVisualStyleBackColor = false;
            updateproduto_box.Click += updateproduto_box_Click;
            // 
            // createproduto_box
            // 
            createproduto_box.BackColor = Color.Aqua;
            createproduto_box.BackgroundImageLayout = ImageLayout.None;
            createproduto_box.FlatStyle = FlatStyle.Flat;
            createproduto_box.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createproduto_box.ForeColor = Color.Black;
            createproduto_box.Location = new Point(327, 337);
            createproduto_box.Margin = new Padding(0);
            createproduto_box.Name = "createproduto_box";
            createproduto_box.Size = new Size(77, 28);
            createproduto_box.TabIndex = 38;
            createproduto_box.Text = "CREATE";
            createproduto_box.UseMnemonic = false;
            createproduto_box.UseVisualStyleBackColor = false;
            createproduto_box.Click += createproduto_box_Click;
            // 
            // readproduto_box
            // 
            readproduto_box.BackColor = Color.Aqua;
            readproduto_box.BackgroundImageLayout = ImageLayout.None;
            readproduto_box.FlatStyle = FlatStyle.Flat;
            readproduto_box.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            readproduto_box.ForeColor = Color.Black;
            readproduto_box.Location = new Point(236, 337);
            readproduto_box.Margin = new Padding(0);
            readproduto_box.Name = "readproduto_box";
            readproduto_box.Size = new Size(77, 28);
            readproduto_box.TabIndex = 37;
            readproduto_box.Text = "READ";
            readproduto_box.UseMnemonic = false;
            readproduto_box.UseVisualStyleBackColor = false;
            readproduto_box.Click += readproduto_box_Click;
            // 
            // idproduto_box
            // 
            idproduto_box.Location = new Point(65, 421);
            idproduto_box.Name = "idproduto_box";
            idproduto_box.Size = new Size(59, 27);
            idproduto_box.TabIndex = 42;
            idproduto_box.TextChanged += idproduto_box_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Aqua;
            label9.Location = new Point(65, 388);
            label9.Name = "label9";
            label9.Size = new Size(24, 21);
            label9.TabIndex = 41;
            label9.Text = "ID";
            // 
            // nomeproduto_box
            // 
            nomeproduto_box.Location = new Point(155, 421);
            nomeproduto_box.Name = "nomeproduto_box";
            nomeproduto_box.Size = new Size(158, 27);
            nomeproduto_box.TabIndex = 44;
            nomeproduto_box.TextChanged += nomeproduto_box_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Aqua;
            label10.Location = new Point(155, 388);
            label10.Name = "label10";
            label10.Size = new Size(50, 21);
            label10.TabIndex = 43;
            label10.Text = "Nome";
            // 
            // precoproduto_box
            // 
            precoproduto_box.AutoSize = true;
            precoproduto_box.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            precoproduto_box.ForeColor = Color.Aqua;
            precoproduto_box.Location = new Point(338, 388);
            precoproduto_box.Name = "precoproduto_box";
            precoproduto_box.Size = new Size(51, 21);
            precoproduto_box.TabIndex = 45;
            precoproduto_box.Text = "Preço";
            // 
            // quantidadeproduto_box
            // 
            quantidadeproduto_box.Location = new Point(460, 421);
            quantidadeproduto_box.Name = "quantidadeproduto_box";
            quantidadeproduto_box.Size = new Size(121, 27);
            quantidadeproduto_box.TabIndex = 48;
            quantidadeproduto_box.TextChanged += quantidadeproduto_box_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Aqua;
            label11.Location = new Point(460, 388);
            label11.Name = "label11";
            label11.Size = new Size(92, 21);
            label11.TabIndex = 47;
            label11.Text = "Quantidade";
            // 
            // exportarxmlbd_btn
            // 
            exportarxmlbd_btn.BackColor = Color.Aqua;
            exportarxmlbd_btn.BackgroundImageLayout = ImageLayout.None;
            exportarxmlbd_btn.FlatStyle = FlatStyle.Flat;
            exportarxmlbd_btn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exportarxmlbd_btn.ForeColor = Color.Black;
            exportarxmlbd_btn.Location = new Point(63, 524);
            exportarxmlbd_btn.Margin = new Padding(0);
            exportarxmlbd_btn.Name = "exportarxmlbd_btn";
            exportarxmlbd_btn.Size = new Size(189, 38);
            exportarxmlbd_btn.TabIndex = 49;
            exportarxmlbd_btn.Text = "READ XML";
            exportarxmlbd_btn.UseMnemonic = false;
            exportarxmlbd_btn.UseVisualStyleBackColor = false;
            exportarxmlbd_btn.Click += exportarxmlbd_btn_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Aqua;
            label12.Location = new Point(65, 588);
            label12.Name = "label12";
            label12.Size = new Size(200, 28);
            label12.TabIndex = 51;
            label12.Text = "ID Desserializar XML";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Aqua;
            label13.Location = new Point(375, 588);
            label13.Name = "label13";
            label13.Size = new Size(210, 28);
            label13.TabIndex = 52;
            label13.Text = "ID Desserializar JSON";
            // 
            // iddesserializarxml_box
            // 
            iddesserializarxml_box.Location = new Point(65, 631);
            iddesserializarxml_box.Name = "iddesserializarxml_box";
            iddesserializarxml_box.Size = new Size(200, 27);
            iddesserializarxml_box.TabIndex = 53;
            iddesserializarxml_box.TextChanged += iddesserializarxml_box_TextChanged;
            // 
            // iddesserializarjson_box
            // 
            iddesserializarjson_box.Location = new Point(381, 631);
            iddesserializarjson_box.Name = "iddesserializarjson_box";
            iddesserializarjson_box.Size = new Size(200, 27);
            iddesserializarjson_box.TabIndex = 54;
            iddesserializarjson_box.TextChanged += iddesserializarjson_box_TextChanged;
            // 
            // desserializarxml_btn
            // 
            desserializarxml_btn.BackColor = Color.Aqua;
            desserializarxml_btn.BackgroundImageLayout = ImageLayout.None;
            desserializarxml_btn.FlatStyle = FlatStyle.Flat;
            desserializarxml_btn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            desserializarxml_btn.ForeColor = Color.Black;
            desserializarxml_btn.Location = new Point(65, 684);
            desserializarxml_btn.Margin = new Padding(0);
            desserializarxml_btn.Name = "desserializarxml_btn";
            desserializarxml_btn.Size = new Size(189, 38);
            desserializarxml_btn.TabIndex = 55;
            desserializarxml_btn.Text = "Desserializar XML";
            desserializarxml_btn.UseMnemonic = false;
            desserializarxml_btn.UseVisualStyleBackColor = false;
            desserializarxml_btn.Click += desserializarxml_btn_Click;
            // 
            // desserializarjson_btn
            // 
            desserializarjson_btn.BackColor = Color.Aqua;
            desserializarjson_btn.BackgroundImageLayout = ImageLayout.None;
            desserializarjson_btn.FlatStyle = FlatStyle.Flat;
            desserializarjson_btn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            desserializarjson_btn.ForeColor = Color.Black;
            desserializarjson_btn.Location = new Point(396, 684);
            desserializarjson_btn.Margin = new Padding(0);
            desserializarjson_btn.Name = "desserializarjson_btn";
            desserializarjson_btn.Size = new Size(189, 38);
            desserializarjson_btn.TabIndex = 56;
            desserializarjson_btn.Text = "Desserializar JSON";
            desserializarjson_btn.UseMnemonic = false;
            desserializarjson_btn.UseVisualStyleBackColor = false;
            desserializarjson_btn.Click += desserializarjson_btn_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Aqua;
            label14.Location = new Point(12, 961);
            label14.Name = "label14";
            label14.Size = new Size(121, 28);
            label14.TabIndex = 57;
            label14.Text = "Versão 1.0.1";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Aqua;
            label15.Location = new Point(934, 961);
            label15.Name = "label15";
            label15.Size = new Size(140, 28);
            label15.TabIndex = 58;
            label15.Text = "Dolphin SGDB";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Aqua;
            label16.Location = new Point(1649, 961);
            label16.Name = "label16";
            label16.Size = new Size(220, 28);
            label16.TabIndex = 59;
            label16.Text = "Created by Alerrandro";
            // 
            // exportarjsonbd_btn
            // 
            exportarjsonbd_btn.BackColor = Color.Aqua;
            exportarjsonbd_btn.BackgroundImageLayout = ImageLayout.None;
            exportarjsonbd_btn.FlatStyle = FlatStyle.Flat;
            exportarjsonbd_btn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exportarjsonbd_btn.ForeColor = Color.Black;
            exportarjsonbd_btn.Location = new Point(396, 524);
            exportarjsonbd_btn.Margin = new Padding(0);
            exportarjsonbd_btn.Name = "exportarjsonbd_btn";
            exportarjsonbd_btn.Size = new Size(189, 38);
            exportarjsonbd_btn.TabIndex = 60;
            exportarjsonbd_btn.Text = "READ JSON";
            exportarjsonbd_btn.UseMnemonic = false;
            exportarjsonbd_btn.UseVisualStyleBackColor = false;
            exportarjsonbd_btn.Click += exportarjsonbd_btn_Click;
            // 
            // priceproduto_box
            // 
            priceproduto_box.Location = new Point(338, 421);
            priceproduto_box.Name = "priceproduto_box";
            priceproduto_box.Size = new Size(97, 27);
            priceproduto_box.TabIndex = 61;
            priceproduto_box.TextChanged += priceproduto_box_TextChanged;
            // 
            // gravarxml_btn
            // 
            gravarxml_btn.BackColor = Color.Aqua;
            gravarxml_btn.BackgroundImageLayout = ImageLayout.None;
            gravarxml_btn.FlatStyle = FlatStyle.Flat;
            gravarxml_btn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gravarxml_btn.ForeColor = Color.Black;
            gravarxml_btn.Location = new Point(63, 471);
            gravarxml_btn.Margin = new Padding(0);
            gravarxml_btn.Name = "gravarxml_btn";
            gravarxml_btn.Size = new Size(189, 38);
            gravarxml_btn.TabIndex = 62;
            gravarxml_btn.Text = "GRAVAR XML";
            gravarxml_btn.UseMnemonic = false;
            gravarxml_btn.UseVisualStyleBackColor = false;
            gravarxml_btn.Click += gravarxml_btn_Click;
            // 
            // gravarjson_btn
            // 
            gravarjson_btn.BackColor = Color.Aqua;
            gravarjson_btn.BackgroundImageLayout = ImageLayout.None;
            gravarjson_btn.FlatStyle = FlatStyle.Flat;
            gravarjson_btn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gravarjson_btn.ForeColor = Color.Black;
            gravarjson_btn.Location = new Point(396, 471);
            gravarjson_btn.Margin = new Padding(0);
            gravarjson_btn.Name = "gravarjson_btn";
            gravarjson_btn.Size = new Size(189, 38);
            gravarjson_btn.TabIndex = 63;
            gravarjson_btn.Text = "GRAVAR JSON";
            gravarjson_btn.UseMnemonic = false;
            gravarjson_btn.UseVisualStyleBackColor = false;
            gravarjson_btn.Click += gravarjson_btn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1902, 1033);
            Controls.Add(gravarjson_btn);
            Controls.Add(gravarxml_btn);
            Controls.Add(priceproduto_box);
            Controls.Add(exportarjsonbd_btn);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(desserializarjson_btn);
            Controls.Add(desserializarxml_btn);
            Controls.Add(iddesserializarjson_box);
            Controls.Add(iddesserializarxml_box);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(exportarxmlbd_btn);
            Controls.Add(quantidadeproduto_box);
            Controls.Add(label11);
            Controls.Add(precoproduto_box);
            Controls.Add(nomeproduto_box);
            Controls.Add(label10);
            Controls.Add(idproduto_box);
            Controls.Add(label9);
            Controls.Add(deleteproduto_box);
            Controls.Add(updateproduto_box);
            Controls.Add(createproduto_box);
            Controls.Add(readproduto_box);
            Controls.Add(deletefuncionario_btn);
            Controls.Add(updatefuncionario_btn);
            Controls.Add(createfuncionario_btn);
            Controls.Add(idadevendedor_box);
            Controls.Add(label8);
            Controls.Add(nomevendedor_box);
            Controls.Add(label7);
            Controls.Add(idvendedor_box);
            Controls.Add(label6);
            Controls.Add(readfuncionario_btn);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(gridviewsgdb);
            Controls.Add(executarquery_btn);
            Controls.Add(label1);
            Controls.Add(richTextquery);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridviewsgdb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label5;
        private RichTextBox richTextquery;
        private Label label1;
        private Button executarquery_btn;
        private DataGridView gridviewsgdb;
        private Label label2;
        private Label label4;
        private Label label3;
        private Button readfuncionario_btn;
        private Label label6;
        private TextBox idvendedor_box;
        private TextBox nomevendedor_box;
        private Label label7;
        private TextBox idadevendedor_box;
        private Label label8;
        private Button createfuncionario_btn;
        private Button updatefuncionario_btn;
        private Button deletefuncionario_btn;
        private Button deleteproduto_box;
        private Button updateproduto_box;
        private Button createproduto_box;
        private Button readproduto_box;
        private TextBox idproduto_box;
        private Label label9;
        private TextBox nomeproduto_box;
        private Label label10;
        private Label precoproduto_box;
        private TextBox quantidadeproduto_box;
        private Label label11;
        private Button exportarxmlbd_btn;
        private Label label12;
        private Label label13;
        private TextBox iddesserializarxml_box;
        private TextBox iddesserializarjson_box;
        private Button desserializarxml_btn;
        private Button desserializarjson_btn;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button exportarjsonbd_btn;
        private TextBox priceproduto_box;
        private Button gravarxml_btn;
        private Button gravarjson_btn;
    }
}