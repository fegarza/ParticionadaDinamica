using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamica
{
    public partial class Form1 : Form
    {
        Memoria MiMemoria = null;
        List<string> Unidades = new List<string>() { "KB", "MB", "GB" };

        public Form1()
        {
            InitializeComponent();
            cbUnidad.DataSource = Unidades;
            
        }

        public void DibujarGrafica()
        {
            double Cant = MiMemoria.MemoriaTotal;
            dtgLibres.Rows.Clear();
            dtgTareas.Rows.Clear();
            pnMemoria.Controls.Clear();
            int i = 0;
            //MessageBox.Show($"Memoria Total: {MiMemoria.Height.ToString()}, height respecto{MiMemoria.SO.miPanel.Height.ToString()}");

            lbTareas.Items.Clear();

            MiMemoria.modo = "particiones";
            foreach (Particion p in MiMemoria)
            {
                
                //MessageBox.Show($"Memoria Total: {MiMemoria.Size.ToString()}, height respecto{p.Height.ToString()}");
                Cant -= p.Size;
                pnMemoria.Controls.Add(p.GetPanel(Cant));
                if (!p.Ocupada)
                {
                    i++;
                    dtgLibres.Rows.Add(i, p.PosicionY, p.Size);
                }
            }
            i = 0;
            MiMemoria.modo = "tareas";
            foreach (Particion p in MiMemoria)
            {

                //MessageBox.Show($"Memoria Total: {MiMemoria.Size.ToString()}, height respecto{p.Height.ToString()}");
                dtgTareas.Rows.Add(p.id, p.PosicionY, p.Size);
                lbTareas.Items.Add(p.ToString());
            }
            pnMemoria.Controls.Add(MiMemoria.SO.GetPanel(0));
            MiMemoria.MostrarMemoriaDisponible();
            lblDisponible.Text = Nucleo.RepresentarKB(MiMemoria.MemoriaDisponible);

        }

        private void BtnAgregarSO_Click(object sender, EventArgs e)
        {
            try
            {
                double SOValue = Nucleo.TransformarAKB(double.Parse(tbSO.Text), cbUnidad.Text);
                if (SOValue != 0)
                {
                    if (MiMemoria.AgregarSO(SOValue))
                    {
                        DibujarGrafica();
                        pnSO.Visible = false;
                        pnTareas.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el sistema operativo");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error al agregar el sistema operativo");
            }

        }

        private void BtnSize_Click(object sender, EventArgs e)
        {
            try
            {
                MiMemoria = new Memoria(Nucleo.TransformarAKB(double.Parse(tbSize.Text), cbUnidad.Text), pnMemoria.Height);
                pnSize.Visible = false;
                pnSO.Visible = true;
                lblSize.Text = Nucleo.RepresentarKB(MiMemoria.Size);
            }
            catch
            {
                MessageBox.Show("Error al agregar la memoria");
            }
               
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            if (!jPanel.Visible)
            {
                jPanel.Visible = true;
            }
            if (MiMemoria.AgregarParticion(Nucleo.TransformarAKB(double.Parse(tbTarea.Text), cbUnidad.Text), true, tbTitle.Text))
            {
                DibujarGrafica();
            }
            else
            {
                lbSB.DataSource = MiMemoria.StandBy;
                //MessageBox.Show("Error al agregar la tarea, no hay suficiente espacio disponible");
            }
        }

        private void btnLiberarTarea_Click(object sender, EventArgs e)
        {
            //MiMemoria.Particiones].Ocupada = false; 

            if (lbTareas.SelectedIndex != -1)
            {
                MessageBox.Show(lbTareas.SelectedIndex.ToString());
                MiMemoria.Librear(lbTareas.SelectedIndex);
                DibujarGrafica();
            }

        }

        private void tbSO_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && tbSO.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void tbTarea_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && tbTarea.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void tbSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && tbSize.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lbSB.SelectedIndex != -1)
            {
                MessageBox.Show(lbSB.SelectedIndex.ToString());
                MiMemoria.StandBy.RemoveAt(lbSB.SelectedIndex);
            }
        }
    }
}
