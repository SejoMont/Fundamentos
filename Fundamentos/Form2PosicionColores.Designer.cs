namespace Fundamentos
{
    partial class Form2PosicionColores
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
            txtPosX = new TextBox();
            txtPosY = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtRojo = new TextBox();
            txtVerde = new TextBox();
            label4 = new Label();
            txtAzul = new TextBox();
            label5 = new Label();
            btnColor = new Button();
            btnPosicion = new Button();
            SuspendLayout();
            // 
            // txtPosX
            // 
            txtPosX.Location = new Point(77, 62);
            txtPosX.Name = "txtPosX";
            txtPosX.Size = new Size(189, 23);
            txtPosX.TabIndex = 0;
            // 
            // txtPosY
            // 
            txtPosY.Location = new Point(289, 62);
            txtPosY.Name = "txtPosY";
            txtPosY.Size = new Size(189, 23);
            txtPosY.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 65);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 2;
            label1.Text = "Posicion";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 70);
            label2.Name = "label2";
            label2.Size = new Size(10, 15);
            label2.TabIndex = 3;
            label2.Text = ",";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 137);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "Rojo";
            label3.Click += label3_Click;
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(77, 134);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(189, 23);
            txtRojo.TabIndex = 5;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(77, 163);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(189, 23);
            txtVerde.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 166);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 6;
            label4.Text = "Verde";
            label4.Click += label4_Click;
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(77, 192);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(189, 23);
            txtAzul.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 195);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 8;
            label5.Text = "Azul";
            label5.Click += label5_Click;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(80, 225);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(187, 22);
            btnColor.TabIndex = 10;
            btnColor.Text = "Cambiar Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // btnPosicion
            // 
            btnPosicion.Location = new Point(489, 62);
            btnPosicion.Name = "btnPosicion";
            btnPosicion.Size = new Size(164, 23);
            btnPosicion.TabIndex = 11;
            btnPosicion.Text = "Cambiar Posicion";
            btnPosicion.UseVisualStyleBackColor = true;
            btnPosicion.Click += btnPosicion_Click;
            // 
            // Form2PosicionColores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPosicion);
            Controls.Add(btnColor);
            Controls.Add(txtAzul);
            Controls.Add(label5);
            Controls.Add(txtVerde);
            Controls.Add(label4);
            Controls.Add(txtRojo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPosY);
            Controls.Add(txtPosX);
            Name = "Form2PosicionColores";
            Text = "Form2PosicionColores";
            Load += Form2PosicionColores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPosX;
        private TextBox txtPosY;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtRojo;
        private TextBox txtVerde;
        private Label label4;
        private TextBox txtAzul;
        private Label label5;
        private Button btnColor;
        private Button btnPosicion;
    }
}