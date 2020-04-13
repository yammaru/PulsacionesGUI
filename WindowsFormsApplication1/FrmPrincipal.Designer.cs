namespace WindowsFormsApplication1
{
    partial class FrmPrincipal
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
            this.BttGuardar = new System.Windows.Forms.Button();
            this.BttConsultar = new System.Windows.Forms.Button();
            this.BttEliminar = new System.Windows.Forms.Button();
            this.BttEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bttCalcular = new System.Windows.Forms.Button();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.GrillaConsultar = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaConsultar)).BeginInit();
            this.SuspendLayout();
            // 
            // BttGuardar
            // 
            this.BttGuardar.Location = new System.Drawing.Point(12, 226);
            this.BttGuardar.Name = "BttGuardar";
            this.BttGuardar.Size = new System.Drawing.Size(75, 23);
            this.BttGuardar.TabIndex = 0;
            this.BttGuardar.Text = "Guardar";
            this.BttGuardar.UseVisualStyleBackColor = true;
            this.BttGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BttConsultar
            // 
            this.BttConsultar.Location = new System.Drawing.Point(95, 226);
            this.BttConsultar.Name = "BttConsultar";
            this.BttConsultar.Size = new System.Drawing.Size(75, 23);
            this.BttConsultar.TabIndex = 1;
            this.BttConsultar.Text = "Concultar";
            this.BttConsultar.UseVisualStyleBackColor = true;
            this.BttConsultar.Click += new System.EventHandler(this.button2_Click);
            // 
            // BttEliminar
            // 
            this.BttEliminar.Location = new System.Drawing.Point(176, 226);
            this.BttEliminar.Name = "BttEliminar";
            this.BttEliminar.Size = new System.Drawing.Size(75, 23);
            this.BttEliminar.TabIndex = 2;
            this.BttEliminar.Text = "Eliminar";
            this.BttEliminar.UseVisualStyleBackColor = true;
            this.BttEliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // BttEditar
            // 
            this.BttEditar.Location = new System.Drawing.Point(257, 226);
            this.BttEditar.Name = "BttEditar";
            this.BttEditar.Size = new System.Drawing.Size(75, 23);
            this.BttEditar.TabIndex = 3;
            this.BttEditar.Text = "Editar";
            this.BttEditar.UseVisualStyleBackColor = true;
            this.BttEditar.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Identificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pulsacion:";
            // 
            // bttCalcular
            // 
            this.bttCalcular.Location = new System.Drawing.Point(199, 155);
            this.bttCalcular.Name = "bttCalcular";
            this.bttCalcular.Size = new System.Drawing.Size(75, 27);
            this.bttCalcular.TabIndex = 9;
            this.bttCalcular.Text = "Calcular";
            this.bttCalcular.UseVisualStyleBackColor = true;
            this.bttCalcular.Click += new System.EventHandler(this.bttCalcular_Click);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(129, 47);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 20);
            this.TxtID.TabIndex = 10;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(129, 77);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.TabIndex = 11;
            this.TxtNombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(129, 103);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(100, 20);
            this.TxtEdad.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "F",
            "M"});
            this.comboBox1.Location = new System.Drawing.Point(129, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // GrillaConsultar
            // 
            this.GrillaConsultar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaConsultar.Location = new System.Drawing.Point(329, 33);
            this.GrillaConsultar.Name = "GrillaConsultar";
            this.GrillaConsultar.Size = new System.Drawing.Size(523, 178);
            this.GrillaConsultar.TabIndex = 15;
            this.GrillaConsultar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(814, 218);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 34);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(864, 261);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.GrillaConsultar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.bttCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BttEditar);
            this.Controls.Add(this.BttEliminar);
            this.Controls.Add(this.BttConsultar);
            this.Controls.Add(this.BttGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaConsultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BttGuardar;
        private System.Windows.Forms.Button BttConsultar;
        private System.Windows.Forms.Button BttEliminar;
        private System.Windows.Forms.Button BttEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bttCalcular;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView GrillaConsultar;
        private System.Windows.Forms.Button btnClose;
    }
}

