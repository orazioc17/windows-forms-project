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

    public partial class form_computadoras : Form
    {

        List<string> procesadores_intel = new List<string>();
        List<string> precios_procesadores_intel = new List<string>();
        List<string> procesadores_amd = new List<string>();
        List<string> precios_procesadores_amd = new List<string>();
        List<string> monitores_lcd = new List<string>();
        List<string> precios_monitores_lcd = new List<string>();
        List<string> monitores_crt = new List<string>();
        List<string> precios_monitores_crt = new List<string>();
        

        public form_computadoras()
        {
            InitializeComponent();

            procesadores_intel.Add("Intel Pentium");
            procesadores_intel.Add("Intel Core i3");
            procesadores_intel.Add("Intel Core i7");
            procesadores_amd.Add("AMD Ryzen 5000");
            procesadores_amd.Add("AMD Athlon PRO");
            procesadores_amd.Add("AMD Ryzen 3");
            precios_procesadores_intel.Add("60");
            precios_procesadores_intel.Add("200");
            precios_procesadores_intel.Add("500");
            precios_procesadores_amd.Add("600");
            precios_procesadores_amd.Add("400");
            precios_procesadores_amd.Add("250");
            monitores_lcd.Add("Lenovo Thinkvision E2054");
            monitores_lcd.Add("MSI Optix");
            monitores_lcd.Add("Dell Se2717h");
            monitores_crt.Add("Samsung 793s");
            monitores_crt.Add("Samsung Syncmaster");
            monitores_crt.Add("Dell 8294");
            precios_monitores_lcd.Add("210");
            precios_monitores_lcd.Add("350");
            precios_monitores_lcd.Add("152");
            precios_monitores_crt.Add("95");
            precios_monitores_crt.Add("83");
            precios_monitores_crt.Add("64");
            
        }

        private void form_computadoras_Load(object sender, EventArgs e)
        {
            btn_intel.Checked = false;
            btn_amd.Checked = false;
            btn_lcd.Checked = false;
            btn_crt.Checked = false;
            txt_num_fac.Text = "1";
            btn_nueva_factura.Enabled = false;
            btn_eliminar.Enabled = false;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("Desea cerrar la aplicacion?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            
            if (opcion == DialogResult.Yes)
            {
                Application.Exit();
            }            
        }

        private void btn_intel_CheckedChanged(object sender, EventArgs e)
        {
            
            if (btn_intel.Checked == true)
            {
                btn_lcd.Enabled = false;
                btn_crt.Enabled = false;
                list_procesador.Enabled = true;
                list_procesador.Items.Clear();
                list_procesador.BeginUpdate();
                foreach (string procesador in procesadores_intel)
                {
                    list_procesador.Items.Add(procesador);
                }
                list_procesador.EndUpdate();
            }
            
        }

        private void btn_amd_CheckedChanged(object sender, EventArgs e)
        {
            
            if (btn_amd.Checked == true)
            {
                btn_lcd.Enabled = false;
                btn_crt.Enabled = false;
                list_procesador.Enabled = true;
                list_procesador.Items.Clear();
                list_procesador.BeginUpdate();
                foreach (string procesador in procesadores_amd)
                {
                    list_procesador.Items.Add(procesador);
                }
                list_procesador.EndUpdate();
            }

        }

        private void btn_lcd_CheckedChanged(object sender, EventArgs e)
        {
            
            if (btn_lcd.Checked == true)
            {
                btn_intel.Enabled = false;
                btn_amd.Enabled = false;
                list_procesador.Enabled = false;
                list_monitor.Items.Clear();
                list_monitor.BeginUpdate();
                foreach (string monitor in monitores_lcd)
                {
                    list_monitor.Items.Add(monitor);
                }
                list_monitor.EndUpdate();
            }

        }

        private void btn_crt_CheckedChanged(object sender, EventArgs e)
        {
            
            if (btn_crt.Checked == true)
            {
                btn_intel.Enabled = false;
                btn_amd.Enabled = false;
                list_procesador.Enabled = false;
                list_monitor.Items.Clear();
                list_monitor.BeginUpdate();
                foreach (string monitor in monitores_crt)
                {
                    list_monitor.Items.Add(monitor);
                }
                list_monitor.EndUpdate();
            }

        }

        private void list_procesador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_procesador.SelectedIndex != -1)
            {
                int indice = list_procesador.SelectedIndex;

                if (btn_intel.Checked == true)
                {
                    list_descripcion.BeginUpdate();
                    list_descripcion.Items.Add(procesadores_intel[indice]);
                    list_descripcion.EndUpdate();
                    list_precio.BeginUpdate();
                    list_precio.Items.Add(precios_procesadores_intel[indice]);
                    list_precio.EndUpdate();
                }
                else if (btn_amd.Checked == true)
                {
                    list_descripcion.BeginUpdate();
                    list_descripcion.Items.Add(procesadores_amd[indice]);
                    list_descripcion.EndUpdate();
                    list_precio.BeginUpdate();
                    list_precio.Items.Add(precios_procesadores_amd[indice]);
                    list_precio.EndUpdate();
                }
                int precio_total = 0;
                foreach (string precio in list_precio.Items)
                {
                    int aux_precio = int.Parse(precio);
                    precio_total += aux_precio;
                }
                txt_total.Text = precio_total.ToString();
                btn_crt.Enabled = true;
                btn_lcd.Enabled = true;
                btn_amd.Checked = false;
                btn_intel.Checked = false;
                list_monitor.Enabled = true;
            }

            
        }

        private void list_monitor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_monitor.SelectedIndex != -1)
            {
                int indice = list_monitor.SelectedIndex;

                if (btn_lcd.Checked == true)
                {
                    list_descripcion.BeginUpdate();
                    list_descripcion.Items.Add(monitores_lcd[indice]);
                    list_descripcion.EndUpdate();
                    list_precio.BeginUpdate();
                    list_precio.Items.Add(precios_monitores_lcd[indice]);
                    list_precio.EndUpdate();
                }
                else if (btn_crt.Checked == true)
                {
                    list_descripcion.BeginUpdate();
                    list_descripcion.Items.Add(monitores_crt[indice]);
                    list_descripcion.EndUpdate();
                    list_precio.BeginUpdate();
                    list_precio.Items.Add(precios_monitores_crt[indice]);
                    list_precio.EndUpdate();
                }
                int precio_total = 0;
                foreach (string precio in list_precio.Items)
                {
                    int aux_precio = int.Parse(precio);
                    precio_total += aux_precio;
                }
                txt_total.Text = precio_total.ToString();
                btn_amd.Enabled = true;
                btn_intel.Enabled = true;
                btn_crt.Checked = false;
                btn_lcd.Checked = false;
                list_monitor.Enabled = true;
            }
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (list_procesador.SelectedIndex != -1)
            {
                int indice = list_descripcion.SelectedIndex;

                list_descripcion.Items.RemoveAt(indice);
                list_precio.Items.RemoveAt(indice);

                int precio_total = 0;
                foreach (string precio in list_precio.Items)
                {
                    int aux_precio = int.Parse(precio);
                    precio_total += aux_precio;
                }

                txt_total.Text = precio_total.ToString();
                btn_eliminar.Enabled = false;
            }
            
        }

        private void btn_nueva_factura_Click(object sender, EventArgs e)
        {
            btn_nueva_factura.Enabled = false;
            btn_intel.Enabled = true;
            btn_amd.Enabled = true;
            btn_lcd.Enabled = true;
            btn_crt.Enabled = true;
            list_descripcion.Enabled = true;
            txt_cedula.Enabled = true;
            txt_direccion.Enabled = true;
            txt_nombre.Enabled = true;
            int num_fac = int.Parse(txt_num_fac.Text);
            num_fac += 1;
            txt_num_fac.Text = num_fac.ToString();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

            if (txt_cedula.Text.Trim() != string.Empty || txt_direccion.Text.Trim() != string.Empty || txt_nombre.Text.Trim() != string.Empty || txt_total.Text.Trim() != string.Empty)
            {
                limpiar_txt_listas();
                errorProvider1.SetError(btn_cancelar, "");
            }
            else
            {
                errorProvider1.SetError(btn_cancelar, "No tiene valores ingresados en la facturacion");
            }
        }

        private void generar_factura()
        {
            MessageBox.Show("Factura generada con exito", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txt_cedula.Enabled = false;
            txt_nombre.Enabled = false;
            txt_direccion.Enabled = false;
            btn_amd.Enabled = false;
            btn_crt.Enabled = false;
            btn_intel.Enabled = false;
            btn_lcd.Enabled = false;
            list_descripcion.Enabled = false;
            list_monitor.Enabled = false;
            list_procesador.Enabled = false;
            btn_nueva_factura.Enabled = true;
        }

        private void limpiar_txt_listas()
        {
            txt_cedula.Text="";
            txt_nombre.Text = "";
            txt_direccion.Text = "";
            list_descripcion.BeginUpdate();
            list_descripcion.Items.Clear();
            list_descripcion.EndUpdate();
            list_monitor.BeginUpdate();
            list_monitor.Items.Clear();
            list_monitor.EndUpdate();
            list_procesador.BeginUpdate();
            list_procesador.Items.Clear();
            list_procesador.EndUpdate();
            list_precio.BeginUpdate();
            list_precio.Items.Clear();
            list_precio.EndUpdate();
            txt_total.Text = "";
            
        }

        private void control_txt()
        {
            if (txt_cedula.Text.Trim() != string.Empty && txt_direccion.Text.Trim() != string.Empty && txt_nombre.Text.Trim() != string.Empty && txt_total.Text.Trim() != string.Empty && txt_total.Text != "0")
            {
                errorProvider1.SetError(btn_generar_factura, "");
                generar_factura();
                limpiar_txt_listas();
            }
            else
            {
                errorProvider1.SetError(btn_generar_factura, "Debe proporcionar todos los datos");
            }
        }
        

        private void btn_generar_factura_Click(object sender, EventArgs e)
        {
            control_txt();
        }

        private void list_descripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_eliminar.Enabled = true;
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txt_direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void btn__atras_Click(object sender, EventArgs e)
        {
            form_bienvenida bienvenida = new form_bienvenida();
            bienvenida.Show();
            this.Close();
        }
    }
}
