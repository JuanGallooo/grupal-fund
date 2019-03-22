namespace Principal.Interfaz
{
    partial class CrearFondo
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
            this.lbnNombre = new System.Windows.Forms.Label();
            this.lbnValorAporte = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbnNombre
            // 
            this.lbnNombre.AutoSize = true;
            this.lbnNombre.Location = new System.Drawing.Point(34, 126);
            this.lbnNombre.Name = "lbnNombre";
            this.lbnNombre.Size = new System.Drawing.Size(83, 13);
            this.lbnNombre.TabIndex = 0;
            this.lbnNombre.Text = "Nombre Fondo :";
            // 
            // lbnValorAporte
            // 
            this.lbnValorAporte.AutoSize = true;
            this.lbnValorAporte.Location = new System.Drawing.Point(34, 173);
            this.lbnValorAporte.Name = "lbnValorAporte";
            this.lbnValorAporte.Size = new System.Drawing.Size(71, 13);
            this.lbnValorAporte.TabIndex = 1;
            this.lbnValorAporte.Text = "Valor Aporte :";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(128, 118);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(128, 173);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 3;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(86, 228);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Guardar";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // CrearFondo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 303);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbnValorAporte);
            this.Controls.Add(this.lbnNombre);
            this.Name = "CrearFondo";
            this.Text = "CrearFondo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnNombre;
        private System.Windows.Forms.Label lbnValorAporte;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnNuevo;
    }
}