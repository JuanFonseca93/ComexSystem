namespace ComexSystem
{
    partial class control_de_usuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUsr = new System.Windows.Forms.TextBox();
            this.txtPss = new System.Windows.Forms.TextBox();
            this.DGVUsr = new System.Windows.Forms.DataGridView();
            this.txtSh = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbxRango = new System.Windows.Forms.ComboBox();
            this.btnBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rango";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(53, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtUsr
            // 
            this.txtUsr.Location = new System.Drawing.Point(53, 148);
            this.txtUsr.Name = "txtUsr";
            this.txtUsr.Size = new System.Drawing.Size(200, 20);
            this.txtUsr.TabIndex = 5;
            // 
            // txtPss
            // 
            this.txtPss.Location = new System.Drawing.Point(53, 210);
            this.txtPss.Name = "txtPss";
            this.txtPss.Size = new System.Drawing.Size(200, 20);
            this.txtPss.TabIndex = 6;
            // 
            // DGVUsr
            // 
            this.DGVUsr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsr.Location = new System.Drawing.Point(334, 77);
            this.DGVUsr.Name = "DGVUsr";
            this.DGVUsr.Size = new System.Drawing.Size(387, 289);
            this.DGVUsr.TabIndex = 7;
            this.DGVUsr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUsr_CellClick);
            // 
            // txtSh
            // 
            this.txtSh.Location = new System.Drawing.Point(335, 30);
            this.txtSh.Name = "txtSh";
            this.txtSh.Size = new System.Drawing.Size(172, 20);
            this.txtSh.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(124, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Nuevo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(223, 335);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbxRango
            // 
            this.cbxRango.FormattingEnabled = true;
            this.cbxRango.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Vendedor"});
            this.cbxRango.Location = new System.Drawing.Point(53, 288);
            this.cbxRango.Name = "cbxRango";
            this.cbxRango.Size = new System.Drawing.Size(200, 21);
            this.cbxRango.TabIndex = 13;
            // 
            // btnBT
            // 
            this.btnBT.Location = new System.Drawing.Point(635, 28);
            this.btnBT.Name = "btnBT";
            this.btnBT.Size = new System.Drawing.Size(75, 23);
            this.btnBT.TabIndex = 14;
            this.btnBT.Text = "Ver Todo";
            this.btnBT.UseVisualStyleBackColor = true;
            this.btnBT.Click += new System.EventHandler(this.btnBT_Click);
            // 
            // control_de_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 397);
            this.Controls.Add(this.btnBT);
            this.Controls.Add(this.cbxRango);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSh);
            this.Controls.Add(this.DGVUsr);
            this.Controls.Add(this.txtPss);
            this.Controls.Add(this.txtUsr);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "control_de_usuarios";
            this.Text = "control_de_usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUsr;
        private System.Windows.Forms.TextBox txtPss;
        private System.Windows.Forms.DataGridView DGVUsr;
        private System.Windows.Forms.TextBox txtSh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbxRango;
        private System.Windows.Forms.Button btnBT;
    }
}