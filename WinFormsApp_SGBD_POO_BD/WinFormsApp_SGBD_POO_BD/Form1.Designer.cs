namespace WinFormsApp_SGBD_POO_BD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            host_box = new TextBox();
            database_box = new TextBox();
            senha_box = new TextBox();
            usuario_box = new TextBox();
            conexaobd_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            xml_btn = new Button();
            json_btn = new Button();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            label11 = new Label();
            port_box = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // host_box
            // 
            host_box.Location = new Point(800, 258);
            host_box.Name = "host_box";
            host_box.Size = new Size(416, 27);
            host_box.TabIndex = 0;
            host_box.TextChanged += host_box_TextChanged;
            // 
            // database_box
            // 
            database_box.Location = new Point(800, 423);
            database_box.Name = "database_box";
            database_box.Size = new Size(416, 27);
            database_box.TabIndex = 1;
            database_box.TextChanged += database_box_TextChanged;
            // 
            // senha_box
            // 
            senha_box.Location = new Point(800, 604);
            senha_box.Name = "senha_box";
            senha_box.Size = new Size(416, 27);
            senha_box.TabIndex = 3;
            senha_box.TextChanged += senha_box_TextChanged;
            // 
            // usuario_box
            // 
            usuario_box.Location = new Point(800, 514);
            usuario_box.Name = "usuario_box";
            usuario_box.Size = new Size(416, 27);
            usuario_box.TabIndex = 2;
            usuario_box.TextChanged += usuario_box_TextChanged;
            // 
            // conexaobd_btn
            // 
            conexaobd_btn.BackColor = Color.Aqua;
            conexaobd_btn.BackgroundImageLayout = ImageLayout.None;
            conexaobd_btn.FlatStyle = FlatStyle.Flat;
            conexaobd_btn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            conexaobd_btn.ForeColor = Color.Black;
            conexaobd_btn.Location = new Point(800, 654);
            conexaobd_btn.Margin = new Padding(0);
            conexaobd_btn.Name = "conexaobd_btn";
            conexaobd_btn.Size = new Size(416, 38);
            conexaobd_btn.TabIndex = 4;
            conexaobd_btn.Text = "Conectar";
            conexaobd_btn.UseMnemonic = false;
            conexaobd_btn.UseVisualStyleBackColor = false;
            conexaobd_btn.Click += conexaobd_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Aqua;
            label1.Location = new Point(800, 227);
            label1.Name = "label1";
            label1.Size = new Size(83, 28);
            label1.TabIndex = 5;
            label1.Text = "Host/IP";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Aqua;
            label2.Location = new Point(800, 392);
            label2.Name = "label2";
            label2.Size = new Size(189, 28);
            label2.TabIndex = 6;
            label2.Text = "Database/Schema";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Aqua;
            label3.Location = new Point(800, 483);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 7;
            label3.Text = "Usuário";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Aqua;
            label4.Location = new Point(800, 573);
            label4.Name = "label4";
            label4.Size = new Size(72, 28);
            label4.TabIndex = 8;
            label4.Text = "Senha";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Aqua;
            label5.Location = new Point(907, 41);
            label5.Name = "label5";
            label5.Size = new Size(322, 145);
            label5.TabIndex = 9;
            label5.Text = "SGDB";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Aqua;
            label6.Location = new Point(12, 961);
            label6.Name = "label6";
            label6.Size = new Size(121, 28);
            label6.TabIndex = 10;
            label6.Text = "Versão 1.0.1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Aqua;
            label7.Location = new Point(1670, 961);
            label7.Name = "label7";
            label7.Size = new Size(220, 28);
            label7.TabIndex = 11;
            label7.Text = "Created by Alerrandro";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Aqua;
            label8.Location = new Point(832, 757);
            label8.Name = "label8";
            label8.Size = new Size(126, 75);
            label8.TabIndex = 12;
            label8.Text = "XML";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Aqua;
            label9.Location = new Point(1054, 757);
            label9.Name = "label9";
            label9.Size = new Size(148, 75);
            label9.TabIndex = 13;
            label9.Text = "JSON";
            // 
            // xml_btn
            // 
            xml_btn.BackColor = Color.Aqua;
            xml_btn.BackgroundImageLayout = ImageLayout.None;
            xml_btn.FlatStyle = FlatStyle.Flat;
            xml_btn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            xml_btn.ForeColor = Color.Black;
            xml_btn.Location = new Point(800, 857);
            xml_btn.Margin = new Padding(0);
            xml_btn.Name = "xml_btn";
            xml_btn.Size = new Size(189, 38);
            xml_btn.TabIndex = 14;
            xml_btn.Text = "Consultar";
            xml_btn.UseMnemonic = false;
            xml_btn.UseVisualStyleBackColor = false;
            xml_btn.Click += xml_btn_Click;
            // 
            // json_btn
            // 
            json_btn.BackColor = Color.Aqua;
            json_btn.BackgroundImageLayout = ImageLayout.None;
            json_btn.FlatStyle = FlatStyle.Flat;
            json_btn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            json_btn.ForeColor = Color.Black;
            json_btn.Location = new Point(1027, 857);
            json_btn.Margin = new Padding(0);
            json_btn.Name = "json_btn";
            json_btn.Size = new Size(189, 38);
            json_btn.TabIndex = 15;
            json_btn.Text = "Consultar link";
            json_btn.UseMnemonic = false;
            json_btn.UseVisualStyleBackColor = false;
            json_btn.Click += json_btn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(802, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 112);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Aqua;
            label10.Location = new Point(934, 961);
            label10.Name = "label10";
            label10.Size = new Size(140, 28);
            label10.TabIndex = 17;
            label10.Text = "Dolphin SGDB";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Aqua;
            label11.Location = new Point(802, 308);
            label11.Name = "label11";
            label11.Size = new Size(51, 28);
            label11.TabIndex = 19;
            label11.Text = "Port";
            // 
            // port_box
            // 
            port_box.Location = new Point(802, 339);
            port_box.Name = "port_box";
            port_box.Size = new Size(416, 27);
            port_box.TabIndex = 18;
            port_box.TextChanged += port_box_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1902, 1033);
            Controls.Add(label11);
            Controls.Add(port_box);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(json_btn);
            Controls.Add(xml_btn);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(conexaobd_btn);
            Controls.Add(senha_box);
            Controls.Add(usuario_box);
            Controls.Add(database_box);
            Controls.Add(host_box);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox host_box;
        private TextBox database_box;
        private TextBox senha_box;
        private TextBox usuario_box;
        private Button conexaobd_btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button xml_btn;
        private Button json_btn;
        private PictureBox pictureBox1;
        private Label label10;
        private Label label11;
        private TextBox port_box;
    }
}
