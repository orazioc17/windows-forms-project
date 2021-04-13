using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asignacion_2_orazio_cappadonna
{
    public partial class form_bienvenida : Form
    {
        public form_bienvenida()
        {
            InitializeComponent();
        }

        private void btn_notas_Click(object sender, EventArgs e)
        {
            form_notas calcular_notas = new form_notas();
            calcular_notas.Show();
            this.Close();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("Desea cerrar la aplicacion?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (opcion == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_comprar_pc_Click(object sender, EventArgs e)
        {
            form_computadoras venta_computadoras = new form_computadoras();
            venta_computadoras.Show();
            this.Close();
        }
    }
}
