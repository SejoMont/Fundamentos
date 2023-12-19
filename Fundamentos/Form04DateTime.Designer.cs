namespace Fundamentos
{
    partial class Form04DateTime
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbxCambiarFeca = new CheckBox();
            cbxDias = new CheckBox();
            cbxMeses = new CheckBox();
            cbxAnios = new CheckBox();
            txtFechaActual = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtIncremento = new TextBox();
            btnIncrementar = new Button();
            txtNuevaFecha = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 68);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha Actual";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(265, 20);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 2;
            label3.Text = "Incremento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 282);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "Nueva Fecha";
            // 
            // cbxCambiarFeca
            // 
            cbxCambiarFeca.AutoSize = true;
            cbxCambiarFeca.Location = new Point(30, 16);
            cbxCambiarFeca.Name = "cbxCambiarFeca";
            cbxCambiarFeca.Size = new Size(153, 19);
            cbxCambiarFeca.TabIndex = 4;
            cbxCambiarFeca.Text = "Cambiar Formato Fecha";
            cbxCambiarFeca.UseVisualStyleBackColor = true;
            cbxCambiarFeca.CheckedChanged += cbxCambiarFeca_CheckedChanged;
            // 
            // cbxDias
            // 
            cbxDias.AutoSize = true;
            cbxDias.Location = new Point(66, 41);
            cbxDias.Name = "cbxDias";
            cbxDias.Size = new Size(48, 19);
            cbxDias.TabIndex = 5;
            cbxDias.Text = "Dias";
            cbxDias.UseVisualStyleBackColor = true;
            // 
            // cbxMeses
            // 
            cbxMeses.AutoSize = true;
            cbxMeses.Location = new Point(66, 66);
            cbxMeses.Name = "cbxMeses";
            cbxMeses.Size = new Size(59, 19);
            cbxMeses.TabIndex = 6;
            cbxMeses.Text = "Meses";
            cbxMeses.UseVisualStyleBackColor = true;
            // 
            // cbxAnios
            // 
            cbxAnios.AutoSize = true;
            cbxAnios.Location = new Point(66, 91);
            cbxAnios.Name = "cbxAnios";
            cbxAnios.Size = new Size(53, 19);
            cbxAnios.TabIndex = 7;
            cbxAnios.Text = "Años";
            cbxAnios.UseVisualStyleBackColor = true;
            // 
            // txtFechaActual
            // 
            txtFechaActual.Location = new Point(39, 95);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(216, 23);
            txtFechaActual.TabIndex = 8;
            txtFechaActual.TextChanged += txtFechaActual_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(265, 41);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(153, 23);
            txtIncremento.TabIndex = 10;
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(263, 85);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(157, 23);
            btnIncrementar.TabIndex = 11;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // txtNuevaFecha
            // 
            txtNuevaFecha.Location = new Point(88, 301);
            txtNuevaFecha.Name = "txtNuevaFecha";
            txtNuevaFecha.Size = new Size(288, 23);
            txtNuevaFecha.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnIncrementar);
            groupBox1.Controls.Add(txtIncremento);
            groupBox1.Controls.Add(cbxAnios);
            groupBox1.Controls.Add(cbxMeses);
            groupBox1.Controls.Add(cbxDias);
            groupBox1.Controls.Add(cbxCambiarFeca);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(55, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(483, 155);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Incrementar Fecha";
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(txtNuevaFecha);
            Controls.Add(txtFechaActual);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            Load += Form04DateTime_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private CheckBox cbxCambiarFeca;
        private CheckBox cbxDias;
        private CheckBox cbxMeses;
        private CheckBox cbxAnios;
        private TextBox txtFechaActual;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txtIncremento;
        private Button btnIncrementar;
        private TextBox txtNuevaFecha;
        private GroupBox groupBox1;
    }
}