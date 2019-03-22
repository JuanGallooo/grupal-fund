namespace Principal.Interfaz
{
    partial class FormPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrestamo));
            this.btnPrestar = new System.Windows.Forms.Button();
            this.txtPocen = new System.Windows.Forms.TextBox();
            this.lbnPorcentaje = new System.Windows.Forms.Label();
            this.txtCuotas = new System.Windows.Forms.TextBox();
            this.lbnCuotas = new System.Windows.Forms.Label();
            this.txtPrestamo = new System.Windows.Forms.TextBox();
            this.labPrestamo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrestar
            // 
            this.btnPrestar.Location = new System.Drawing.Point(76, 220);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(75, 23);
            this.btnPrestar.TabIndex = 17;
            this.btnPrestar.Text = "Prestar";
            this.btnPrestar.UseVisualStyleBackColor = true;
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            // 
            // txtPocen
            // 
            this.txtPocen.Location = new System.Drawing.Point(115, 190);
            this.txtPocen.Name = "txtPocen";
            this.txtPocen.Size = new System.Drawing.Size(100, 20);
            this.txtPocen.TabIndex = 14;
            // 
            // lbnPorcentaje
            // 
            this.lbnPorcentaje.AutoSize = true;
            this.lbnPorcentaje.Location = new System.Drawing.Point(25, 197);
            this.lbnPorcentaje.Name = "lbnPorcentaje";
            this.lbnPorcentaje.Size = new System.Drawing.Size(21, 13);
            this.lbnPorcentaje.TabIndex = 13;
            this.lbnPorcentaje.Text = "% :";
            // 
            // txtCuotas
            // 
            this.txtCuotas.Location = new System.Drawing.Point(115, 157);
            this.txtCuotas.Name = "txtCuotas";
            this.txtCuotas.Size = new System.Drawing.Size(100, 20);
            this.txtCuotas.TabIndex = 12;
            // 
            // lbnCuotas
            // 
            this.lbnCuotas.AutoSize = true;
            this.lbnCuotas.Location = new System.Drawing.Point(25, 164);
            this.lbnCuotas.Name = "lbnCuotas";
            this.lbnCuotas.Size = new System.Drawing.Size(81, 13);
            this.lbnCuotas.TabIndex = 11;
            this.lbnCuotas.Text = "No° de cuotas :";
            this.lbnCuotas.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPrestamo
            // 
            this.txtPrestamo.Location = new System.Drawing.Point(115, 122);
            this.txtPrestamo.Name = "txtPrestamo";
            this.txtPrestamo.Size = new System.Drawing.Size(100, 20);
            this.txtPrestamo.TabIndex = 10;
            // 
            // labPrestamo
            // 
            this.labPrestamo.AutoSize = true;
            this.labPrestamo.Location = new System.Drawing.Point(25, 129);
            this.labPrestamo.Name = "labPrestamo";
            this.labPrestamo.Size = new System.Drawing.Size(81, 13);
            this.labPrestamo.TabIndex = 9;
            this.labPrestamo.Text = "Prestamo en $ :";
            this.labPrestamo.Click += new System.EventHandler(this.labNombre_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 255);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPrestar);
            this.Controls.Add(this.txtPocen);
            this.Controls.Add(this.lbnPorcentaje);
            this.Controls.Add(this.txtCuotas);
            this.Controls.Add(this.lbnCuotas);
            this.Controls.Add(this.txtPrestamo);
            this.Controls.Add(this.labPrestamo);
            this.Name = "FormPrestamo";
            this.Text = "FormPrestamo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrestar;
        private System.Windows.Forms.TextBox txtPocen;
        private System.Windows.Forms.Label lbnPorcentaje;
        private System.Windows.Forms.TextBox txtCuotas;
        private System.Windows.Forms.Label lbnCuotas;
        private System.Windows.Forms.TextBox txtPrestamo;
        private System.Windows.Forms.Label labPrestamo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}