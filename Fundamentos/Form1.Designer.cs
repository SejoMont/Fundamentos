namespace Fundamentos
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
            btnPulsar = new Button();
            txtNombre = new TextBox();
            Label = new Label();
            SuspendLayout();
            // 
            // btnPulsar
            // 
            btnPulsar.Location = new Point(93, 71);
            btnPulsar.Name = "btnPulsar";
            btnPulsar.Size = new Size(125, 45);
            btnPulsar.TabIndex = 0;
            btnPulsar.Text = "Pulsar";
            btnPulsar.UseVisualStyleBackColor = true;
            btnPulsar.Click += btnPulsar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(93, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(350, 23);
            txtNombre.TabIndex = 1;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Location = new Point(93, 24);
            Label.Name = "Label";
            Label.Size = new Size(51, 15);
            Label.TabIndex = 2;
            Label.Text = "Nombre";
            Label.Click += Label_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Label);
            Controls.Add(txtNombre);
            Controls.Add(btnPulsar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPulsar;
        private TextBox txtNombre;
        private Label Label;
    }
}