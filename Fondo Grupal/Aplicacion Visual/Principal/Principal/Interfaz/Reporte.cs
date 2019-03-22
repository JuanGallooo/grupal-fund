using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.Interfaz
{
    public partial class Reporte : Form
    {
        public Reporte(String texto)
        {
            InitializeComponent();

            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.AcceptsReturn = true;
            textBox1.AcceptsTab = true;
            textBox1.WordWrap = true;
            textBox1.Text = texto;
        }

        private void Reporte_Load(object sender, EventArgs e)
        {

        }
        public void actualizarTexto(String texto)
        {
            textBox1.Text = texto;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
