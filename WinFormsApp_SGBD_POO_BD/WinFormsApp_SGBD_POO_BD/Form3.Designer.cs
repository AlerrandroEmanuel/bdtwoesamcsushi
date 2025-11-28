namespace WinFormsApp_SGBD_POO_BD
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox1 = new PictureBox();
            label5 = new Label();
            listarxml_DataGridView = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            desserializarxml_DataGridView = new DataGridView();
            digitarxml_box = new TextBox();
            listarxml_btn = new Button();
            label4 = new Label();
            desserializarxmlform2_btn = new Button();
            label6 = new Label();
            label7 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)listarxml_DataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)desserializarxml_DataGridView).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(261, 90);
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
            label5.Location = new Point(366, 74);
            label5.Name = "label5";
            label5.Size = new Size(322, 145);
            label5.TabIndex = 17;
            label5.Text = "SGDB";
            // 
            // listarxml_DataGridView
            // 
            listarxml_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listarxml_DataGridView.Location = new Point(21, 296);
            listarxml_DataGridView.Name = "listarxml_DataGridView";
            listarxml_DataGridView.RowHeadersWidth = 51;
            listarxml_DataGridView.Size = new Size(300, 510);
            listarxml_DataGridView.TabIndex = 20;
            listarxml_DataGridView.CellContentClick += listarxml_DataGridView_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Aqua;
            label2.Location = new Point(30, 246);
            label2.Name = "label2";
            label2.Size = new Size(282, 37);
            label2.TabIndex = 24;
            label2.Text = "Listar os arquivos XML";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Aqua;
            label1.Location = new Point(641, 246);
            label1.Name = "label1";
            label1.Size = new Size(250, 37);
            label1.TabIndex = 25;
            label1.Text = "XML Desserializado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Aqua;
            label3.Location = new Point(445, 296);
            label3.Name = "label3";
            label3.Size = new Size(63, 37);
            label3.TabIndex = 26;
            label3.Text = "XML";
            // 
            // desserializarxml_DataGridView
            // 
            desserializarxml_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            desserializarxml_DataGridView.Location = new Point(617, 296);
            desserializarxml_DataGridView.Name = "desserializarxml_DataGridView";
            desserializarxml_DataGridView.RowHeadersWidth = 51;
            desserializarxml_DataGridView.Size = new Size(300, 510);
            desserializarxml_DataGridView.TabIndex = 27;
            desserializarxml_DataGridView.CellContentClick += desserializarxml_DataGridView_CellContentClick;
            // 
            // digitarxml_box
            // 
            digitarxml_box.Location = new Point(355, 507);
            digitarxml_box.Name = "digitarxml_box";
            digitarxml_box.Size = new Size(240, 27);
            digitarxml_box.TabIndex = 28;
            digitarxml_box.TextChanged += digitarxml_box_TextChanged;
            // 
            // listarxml_btn
            // 
            listarxml_btn.BackColor = Color.Aqua;
            listarxml_btn.BackgroundImageLayout = ImageLayout.None;
            listarxml_btn.FlatStyle = FlatStyle.Flat;
            listarxml_btn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listarxml_btn.ForeColor = Color.Black;
            listarxml_btn.Location = new Point(355, 352);
            listarxml_btn.Margin = new Padding(0);
            listarxml_btn.Name = "listarxml_btn";
            listarxml_btn.Size = new Size(240, 38);
            listarxml_btn.TabIndex = 29;
            listarxml_btn.Text = "Listar XML";
            listarxml_btn.UseMnemonic = false;
            listarxml_btn.UseVisualStyleBackColor = false;
            listarxml_btn.Click += listarxml_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Aqua;
            label4.Location = new Point(389, 450);
            label4.Name = "label4";
            label4.Size = new Size(177, 28);
            label4.TabIndex = 30;
            label4.Text = "Escolha o arquivo";
            // 
            // desserializarxmlform2_btn
            // 
            desserializarxmlform2_btn.BackColor = Color.Aqua;
            desserializarxmlform2_btn.BackgroundImageLayout = ImageLayout.None;
            desserializarxmlform2_btn.FlatStyle = FlatStyle.Flat;
            desserializarxmlform2_btn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            desserializarxmlform2_btn.ForeColor = Color.Black;
            desserializarxmlform2_btn.Location = new Point(355, 551);
            desserializarxmlform2_btn.Margin = new Padding(0);
            desserializarxmlform2_btn.Name = "desserializarxmlform2_btn";
            desserializarxmlform2_btn.Size = new Size(240, 38);
            desserializarxmlform2_btn.TabIndex = 31;
            desserializarxmlform2_btn.Text = "Desserializar XML";
            desserializarxmlform2_btn.UseMnemonic = false;
            desserializarxmlform2_btn.UseVisualStyleBackColor = false;
            desserializarxmlform2_btn.Click += desserializarxmlform2_btn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Aqua;
            label6.Location = new Point(21, 961);
            label6.Name = "label6";
            label6.Size = new Size(121, 28);
            label6.TabIndex = 32;
            label6.Text = "Versão 1.0.1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Aqua;
            label7.Location = new Point(697, 961);
            label7.Name = "label7";
            label7.Size = new Size(220, 28);
            label7.TabIndex = 33;
            label7.Text = "Created by Alerrandro";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Aqua;
            label10.Location = new Point(404, 961);
            label10.Name = "label10";
            label10.Size = new Size(140, 28);
            label10.TabIndex = 34;
            label10.Text = "Dolphin SGDB";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(942, 1033);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(desserializarxmlform2_btn);
            Controls.Add(label4);
            Controls.Add(listarxml_btn);
            Controls.Add(digitarxml_box);
            Controls.Add(desserializarxml_DataGridView);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(listarxml_DataGridView);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)listarxml_DataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)desserializarxml_DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label5;
        private DataGridView listarxml_DataGridView;
        private Label label2;
        private Label label1;
        private Label label3;
        private DataGridView desserializarxml_DataGridView;
        private TextBox digitarxml_box;
        private Button listarxml_btn;
        private Label label4;
        private Button desserializarxmlform2_btn;
        private Label label6;
        private Label label7;
        private Label label10;
    }
}