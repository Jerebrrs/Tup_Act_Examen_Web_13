namespace Guia_Examen_13
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
            groupBox1 = new GroupBox();
            btnImportarPaquete = new Button();
            listBox3 = new ListBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            btnDescargar = new Button();
            btnEnviar = new Button();
            btnInciar = new Button();
            label2 = new Label();
            tbKg = new TextBox();
            cbCamiones = new ComboBox();
            label1 = new Label();
            btnAgregar = new Button();
            lbCarga = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnImportarPaquete);
            groupBox1.Controls.Add(listBox3);
            groupBox1.Controls.Add(listBox2);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(625, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Deposito";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnImportarPaquete
            // 
            btnImportarPaquete.Location = new Point(501, 37);
            btnImportarPaquete.Name = "btnImportarPaquete";
            btnImportarPaquete.Size = new Size(100, 124);
            btnImportarPaquete.TabIndex = 3;
            btnImportarPaquete.Text = "Importar Paquete";
            btnImportarPaquete.UseVisualStyleBackColor = true;
            btnImportarPaquete.Click += btnImportarPaquete_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(332, 37);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(148, 124);
            listBox3.TabIndex = 2;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(178, 37);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(148, 124);
            listBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(24, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(148, 124);
            listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDescargar);
            groupBox2.Controls.Add(btnEnviar);
            groupBox2.Controls.Add(btnInciar);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(tbKg);
            groupBox2.Controls.Add(cbCamiones);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(lbCarga);
            groupBox2.Location = new Point(12, 218);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(625, 200);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Deposito";
            // 
            // btnDescargar
            // 
            btnDescargar.Location = new Point(501, 84);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(100, 41);
            btnDescargar.TabIndex = 10;
            btnDescargar.Text = "Descargar";
            btnDescargar.UseVisualStyleBackColor = true;
            btnDescargar.Click += btnDescargar_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(136, 84);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(78, 24);
            btnEnviar.TabIndex = 9;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnInciar
            // 
            btnInciar.Location = new Point(37, 84);
            btnInciar.Name = "btnInciar";
            btnInciar.Size = new Size(75, 24);
            btnInciar.TabIndex = 8;
            btnInciar.Text = "Iniciar";
            btnInciar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 143);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 7;
            label2.Text = "Peso Acumulado";
            // 
            // tbKg
            // 
            tbKg.Location = new Point(136, 135);
            tbKg.Name = "tbKg";
            tbKg.Size = new Size(78, 23);
            tbKg.TabIndex = 6;
            // 
            // cbCamiones
            // 
            cbCamiones.FormattingEnabled = true;
            cbCamiones.Location = new Point(24, 55);
            cbCamiones.Name = "cbCamiones";
            cbCamiones.Size = new Size(201, 23);
            cbCamiones.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 19);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 4;
            label1.Text = "Lista de Camiones";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(501, 37);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 41);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lbCarga
            // 
            lbCarga.FormattingEnabled = true;
            lbCarga.ItemHeight = 15;
            lbCarga.Location = new Point(263, 37);
            lbCarga.Name = "lbCarga";
            lbCarga.Size = new Size(217, 124);
            lbCarga.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 441);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnImportarPaquete;
        private ListBox listBox3;
        private ListBox listBox2;
        private ListBox listBox1;
        private GroupBox groupBox2;
        private TextBox tbKg;
        private ComboBox cbCamiones;
        private Label label1;
        private Button btnAgregar;
        private ListBox lbCarga;
        private Button btnEnviar;
        private Button btnInciar;
        private Label label2;
        private Button btnDescargar;
    }
}
