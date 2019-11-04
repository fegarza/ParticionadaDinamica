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
            pnMemoria.Controls.Clear();
            //MessageBox.Show($"Memoria Total: {MiMemoria.Height.ToString()}, height respecto{MiMemoria.SO.miPanel.Height.ToString()}");

            lbTareas.Items.Clear();
            MiMemoria.modo = "tareas";
            foreach (Particion p in MiMemoria)
            {
                //MessageBox.Show($"Memoria Total: {MiMemoria.Size.ToString()}, height respecto{p.Height.ToString()}");
                lbTareas.Items.Add(p.ToString());
            }
            MiMemoria.modo = "particiones";
            foreach (Particion p in MiMemoria)
            {
                //MessageBox.Show($"Memoria Total: {MiMemoria.Size.ToString()}, height respecto{p.Height.ToString()}");
                pnMemoria.Controls.Add(p.GetPanel());
            }
            pnMemoria.Controls.Add(MiMemoria.SO.GetPanel());
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

        private void tbSize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double.Parse(tbSize.Text);
            }
            catch
            {
                if (!(tbSize.Text == "."))
                {
                    tbSize.Clear();
                }
            }
        }

        private void tbSO_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double.Parse(tbSO.Text);
            }
            catch
            {
                if (!(tbSO.Text == "."))
                {
                    tbSO.Clear();
                }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
