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
    public partial class form_notas : Form
    {
        List<decimal> lista = new List<decimal>();                
            
        public form_notas()
        {
            InitializeComponent();

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            form_bienvenida bienvenida = new form_bienvenida();
            bienvenida.Show();
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

        private void form_notas_Load(object sender, EventArgs e)
        {
            btn_nuevo.Enabled = false;

        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {
            int contador_aprobados = 0;
            int contador_reprobados = 0;
            decimal acumulador_notas = 0m;
            int total_de_notas = 0;
            list_notas.Items.Clear();
            decimal nota = nueva_nota.Value;
            lista.Add(nota);
            decimal aux= 9.5m;

            list_notas.BeginUpdate();
            foreach (decimal note in lista)
            {
                acumulador_notas = acumulador_notas + note;
                list_notas.Items.Add(note);
                if (note >= aux)
                {
                    contador_aprobados+=1;
                }
                else
                {
                    contador_reprobados+=1;
                }
                total_de_notas += 1;
                txt_total.Text = total_de_notas.ToString();
                txt_aprobados.Text = contador_aprobados.ToString();
                txt_reprobados.Text = contador_reprobados.ToString();
            }
            list_notas.EndUpdate();

            decimal promedio = acumulador_notas / total_de_notas;
            promedio = Math.Round(promedio, 1);
            txt_prom.Text = promedio.ToString();

            btn_nuevo.Enabled = true;


        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_aprobados.Text = "";
            txt_reprobados.Text = "";
            txt_total.Text = "";
            lista.Clear();
            list_notas.BeginUpdate();
            list_notas.Items.Clear();
            list_notas.EndUpdate();
            nueva_nota.Value = 0;
            nueva_nota.Focus();
            btn_nuevo.Enabled = false;
            txt_prom.Text = "";
        }

    }
}
