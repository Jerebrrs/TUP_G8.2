namespace guia82
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbPatente = new TextBox();
            tbImporte = new TextBox();
            btnConfirmar = new Button();
            button1 = new Button();
            tbImportar = new Button();
            btExportar = new Button();
            button2 = new Button();
            dtpVencimiento = new DateTimePicker();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 29);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Patente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 65);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Venciminto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 95);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 2;
            label3.Text = "Importe";
            // 
            // tbPatente
            // 
            tbPatente.Location = new Point(143, 26);
            tbPatente.Name = "tbPatente";
            tbPatente.Size = new Size(100, 23);
            tbPatente.TabIndex = 3;
            // 
            // tbImporte
            // 
            tbImporte.Location = new Point(143, 95);
            tbImporte.Name = "tbImporte";
            tbImporte.Size = new Size(100, 23);
            tbImporte.TabIndex = 5;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(314, 65);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(75, 23);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(314, 159);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbImportar
            // 
            tbImportar.Location = new Point(314, 241);
            tbImportar.Name = "tbImportar";
            tbImportar.Size = new Size(75, 23);
            tbImportar.TabIndex = 9;
            tbImportar.Text = "Importar";
            tbImportar.UseVisualStyleBackColor = true;
            // 
            // btExportar
            // 
            btExportar.Location = new Point(314, 241);
            btExportar.Name = "btExportar";
            btExportar.Size = new Size(75, 23);
            btExportar.TabIndex = 10;
            btExportar.Text = "Exportar";
            btExportar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(314, 201);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 11;
            button2.Text = "Importar";
            button2.UseVisualStyleBackColor = true;
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.CustomFormat = "dd/MM/yyyy";
            dtpVencimiento.Location = new Point(143, 57);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(100, 23);
            dtpVencimiento.TabIndex = 12;
            dtpVencimiento.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(33, 148);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(251, 154);
            listBox1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 318);
            Controls.Add(listBox1);
            Controls.Add(dtpVencimiento);
            Controls.Add(button2);
            Controls.Add(btExportar);
            Controls.Add(tbImportar);
            Controls.Add(button1);
            Controls.Add(btnConfirmar);
            Controls.Add(tbImporte);
            Controls.Add(tbPatente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbPatente;
        private TextBox tbImporte;
        private Button btnConfirmar;
        private Button button1;
        private Button tbImportar;
        private Button btExportar;
        private Button button2;
        private DateTimePicker dtpVencimiento;
        private ListBox listBox1;
    }
}
