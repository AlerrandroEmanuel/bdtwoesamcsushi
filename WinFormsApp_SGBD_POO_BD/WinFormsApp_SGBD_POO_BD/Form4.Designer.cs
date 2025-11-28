namespace WinFormsApp_SGBD_POO_BD
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label3 = new Label();
            JSONdesserializadodataGridView = new DataGridView();
            label4 = new Label();
            linkJSON_box = new TextBox();
            desserializarjson_btn = new Button();
            label6 = new Label();
            label7 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)JSONdesserializadodataGridView).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(268, 88);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 112);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Aqua;
            label5.Location = new Point(373, 72);
            label5.Name = "label5";
            label5.Size = new Size(322, 145);
            label5.TabIndex = 19;
            label5.Text = "SGDB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Aqua;
            label3.Location = new Point(431, 231);
            label3.Name = "label3";
            label3.Size = new Size(75, 37);
            label3.TabIndex = 27;
            label3.Text = "JSON";
            // 
            // JSONdesserializadodataGridView
            // 
            JSONdesserializadodataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            JSONdesserializadodataGridView.Location = new Point(22, 378);
            JSONdesserializadodataGridView.Name = "JSONdesserializadodataGridView";
            JSONdesserializadodataGridView.RowHeadersWidth = 51;
            JSONdesserializadodataGridView.Size = new Size(895, 459);
            JSONdesserializadodataGridView.TabIndex = 28;
            JSONdesserializadodataGridView.CellContentClick += JSONdesserializadodataGridView_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Aqua;
            label4.Location = new Point(22, 288);
            label4.Name = "label4";
            label4.Size = new Size(323, 28);
            label4.TabIndex = 31;
            label4.Text = "Copie e cole seu link json abaixo:";
            // 
            // linkJSON_box
            // 
            linkJSON_box.Location = new Point(22, 333);
            linkJSON_box.Name = "linkJSON_box";
            linkJSON_box.Size = new Size(631, 27);
            linkJSON_box.TabIndex = 32;
            linkJSON_box.TextChanged += linkJSON_box_TextChanged;
            // 
            // desserializarjson_btn
            // 
            desserializarjson_btn.BackColor = Color.Aqua;
            desserializarjson_btn.BackgroundImageLayout = ImageLayout.None;
            desserializarjson_btn.FlatStyle = FlatStyle.Flat;
            desserializarjson_btn.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            desserializarjson_btn.ForeColor = Color.Black;
            desserializarjson_btn.Location = new Point(680, 333);
            desserializarjson_btn.Margin = new Padding(0);
            desserializarjson_btn.Name = "desserializarjson_btn";
            desserializarjson_btn.Size = new Size(240, 27);
            desserializarjson_btn.TabIndex = 33;
            desserializarjson_btn.Text = "Desserializar JSON";
            desserializarjson_btn.UseMnemonic = false;
            desserializarjson_btn.UseVisualStyleBackColor = false;
            desserializarjson_btn.Click += desserializarjson_btn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Aqua;
            label6.Location = new Point(21, 961);
            label6.Name = "label6";
            label6.Size = new Size(121, 28);
            label6.TabIndex = 34;
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
            label7.TabIndex = 35;
            label7.Text = "Created by Alerrandro";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Aqua;
            label10.Location = new Point(398, 961);
            label10.Name = "label10";
            label10.Size = new Size(140, 28);
            label10.TabIndex = 36;
            label10.Text = "Dolphin SGDB";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(942, 1033);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(desserializarjson_btn);
            Controls.Add(linkJSON_box);
            Controls.Add(label4);
            Controls.Add(JSONdesserializadodataGridView);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)JSONdesserializadodataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label5;
        private Label label3;
        private DataGridView JSONdesserializadodataGridView;
        private Label label4;
        private TextBox linkJSON_box;
        private Button desserializarjson_btn;
        private Label label6;
        private Label label7;
        private Label label10;
    }
}