namespace Fundamentos
{
    partial class Form06ValidarMail
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
            label1 = new Label();
            txtCorreo = new TextBox();
            btnComprobarCorreo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 32);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Comprobar Correo+";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(155, 29);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(364, 23);
            txtCorreo.TabIndex = 1;
            // 
            // btnComprobarCorreo
            // 
            btnComprobarCorreo.Location = new Point(525, 29);
            btnComprobarCorreo.Name = "btnComprobarCorreo";
            btnComprobarCorreo.Size = new Size(83, 26);
            btnComprobarCorreo.TabIndex = 2;
            btnComprobarCorreo.Text = "Comprobar";
            btnComprobarCorreo.UseVisualStyleBackColor = true;
            btnComprobarCorreo.Click += btnComprobarCorreo_Click;
            // 
            // Form06ValidarMail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnComprobarCorreo);
            Controls.Add(txtCorreo);
            Controls.Add(label1);
            Name = "Form06ValidarMail";
            Text = "Form06ValidarMail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCorreo;
        private Button btnComprobarCorreo;
    }
}