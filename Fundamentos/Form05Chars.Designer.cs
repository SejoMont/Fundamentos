namespace Fundamentos
{
    partial class Form05Chars
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
            txtLetras = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtSimbolos = new TextBox();
            label3 = new Label();
            txtDigitos = new TextBox();
            label4 = new Label();
            txtPuntuacion = new TextBox();
            btnRecorrerAscii = new Button();
            SuspendLayout();
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(59, 51);
            txtLetras.Multiline = true;
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(205, 124);
            txtLetras.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 33);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "Letras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 187);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "Simbolos";
            // 
            // txtSimbolos
            // 
            txtSimbolos.Location = new Point(59, 205);
            txtSimbolos.Multiline = true;
            txtSimbolos.Name = "txtSimbolos";
            txtSimbolos.Size = new Size(205, 124);
            txtSimbolos.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(304, 33);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 5;
            label3.Text = "Digitos";
            // 
            // txtDigitos
            // 
            txtDigitos.Location = new Point(304, 51);
            txtDigitos.Multiline = true;
            txtDigitos.Name = "txtDigitos";
            txtDigitos.Size = new Size(205, 124);
            txtDigitos.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(304, 187);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 7;
            label4.Text = "Puntuacion";
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPuntuacion.Location = new Point(304, 205);
            txtPuntuacion.Multiline = true;
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(205, 124);
            txtPuntuacion.TabIndex = 6;
            // 
            // btnRecorrerAscii
            // 
            btnRecorrerAscii.Location = new Point(610, 145);
            btnRecorrerAscii.Name = "btnRecorrerAscii";
            btnRecorrerAscii.Size = new Size(123, 98);
            btnRecorrerAscii.TabIndex = 8;
            btnRecorrerAscii.Text = "Recorrer ASCII";
            btnRecorrerAscii.UseVisualStyleBackColor = true;
            btnRecorrerAscii.Click += button1_Click;
            // 
            // Form05Chars
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRecorrerAscii);
            Controls.Add(label4);
            Controls.Add(txtPuntuacion);
            Controls.Add(label3);
            Controls.Add(txtDigitos);
            Controls.Add(label2);
            Controls.Add(txtSimbolos);
            Controls.Add(label1);
            Controls.Add(txtLetras);
            Name = "Form05Chars";
            Text = "Form05Chars";
            Load += Form05Chars_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLetras;
        private Label label1;
        private Label label2;
        private TextBox txtSimbolos;
        private Label label3;
        private TextBox txtDigitos;
        private Label label4;
        private TextBox txtPuntuacion;
        private Button btnRecorrerAscii;
    }
}