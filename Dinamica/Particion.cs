using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamica
{
   
    public class Particion
    {
        //Propiedades de la lista
        public bool Ocupada = true;
        public bool SO = false;
        public Particion Siguiente = null;
        public Particion Anterior = null;

        //Propiedades de la particion
        public string id = "";
        public double Size;
        public int Height = 0;
        public double PosicionY;
        public Particion(double _size, int _height)
        {
            Size = _size;
            Height = _height;
        }
        public Particion(double _size, int _height, bool _ocupada)
        {
            Size = _size;
            Ocupada = _ocupada;
            Height = _height;
        }
        public Particion(double _size, int _height, bool _ocupada, string _titulo)
        {
            Size = _size;
            Ocupada = _ocupada;
            Height = _height;
            id = _titulo;
        }


        public Panel GetPanel()
        {

            Panel miPanel = new Panel()
            {
                Dock = DockStyle.Top,
                Height = this.Height
            };
            if (SO)
            {
                Panel Left = new Panel()
                {
                    Dock = DockStyle.Left,
                    Width = 150,
                    BackColor = System.Drawing.Color.White
                };
                Left.Controls.Add(new Label() { Dock = DockStyle.Top, Text = $"{Nucleo.RepresentarKB(Size)}", Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))) });
                Left.Controls.Add(new Panel { Dock = DockStyle.Bottom, Height = 3, BackColor = System.Drawing.Color.Black });
                miPanel.Controls.Add(Left);
                Panel Right = new Panel { Dock = DockStyle.Fill, BackColor = System.Drawing.Color.Black };
                Right.Controls.Add(new Label() {TextAlign = System.Drawing.ContentAlignment.MiddleCenter ,ForeColor = System.Drawing.Color.White, Dock = DockStyle.Fill, Text = "S.O.", Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))) });;
                Right.Controls.Add(new Panel { Dock = DockStyle.Bottom, Height = 3, BackColor = System.Drawing.Color.Black });

                miPanel.Controls.Add(Right);
            }
            else
            {
                if (Ocupada)
                {
                    Panel Left = new Panel()
                    {
                        Dock = DockStyle.Left,
                        Width = 150,
                        BackColor = System.Drawing.Color.White
                    };
                    Left.Controls.Add(new Label() { Dock = DockStyle.Top ,Text = $"{id} ", Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))) });
                    Left.Controls.Add(new Label() {Dock = DockStyle.Top ,Text = $"{Nucleo.RepresentarKB(Size)}", Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))) });
                    Left.Controls.Add(new Panel { Dock = DockStyle.Bottom, Height = 3, BackColor = System.Drawing.Color.Black });
                    miPanel.Controls.Add(Left);
                    Panel Right = new Panel { Dock = DockStyle.Fill, BackColor = System.Drawing.Color.Red };
                    Right.Controls.Add(new Panel { Dock = DockStyle.Bottom, Height = 3, BackColor = System.Drawing.Color.Black });
                    miPanel.Controls.Add(Right);
                }
                else
                {
                    Panel Left = new Panel()
                    {
                        Dock = DockStyle.Left,
                        Width = 150,
                        BackColor = System.Drawing.Color.White
                    };
                    Left.Controls.Add(new Label() { Text = Nucleo.RepresentarKB(Size), Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))) });
                    Left.Controls.Add(new Panel { Dock = DockStyle.Bottom, Height = 3, BackColor = System.Drawing.Color.Black });
                    miPanel.Controls.Add(Left);
                    Panel Right = new Panel { Dock = DockStyle.Fill, BackColor = System.Drawing.Color.Blue };
                    Right.Controls.Add(new Panel { Dock = DockStyle.Bottom, Height = 3, BackColor = System.Drawing.Color.Black });
                    miPanel.Controls.Add(Right);
                }
            }
            
            
            return miPanel;
        }

        public Panel GetPanel(double Posicion)
        {
            PosicionY = Posicion;
            Panel miPanel = new Panel()
            {
                Dock = DockStyle.Top,
                Height = this.Height
            };
            if (SO)
            {
                Panel Left = new Panel()
                {
                    Dock = DockStyle.Left,
                    Width = 150,
                    BackColor = System.Drawing.Color.White
                };
                Left.Controls.Add(new Label() { Dock = DockStyle.Top, Text = $"{ Nucleo.RepresentarKB(Posicion)}", Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))) });
                Left.Controls.Add(new Panel { Dock = DockStyle.Bottom, Height = 3, BackColor = System.Drawing.Color.Black });
                miPanel.Controls.Add(Left);
                Panel Right = new Panel { Dock = DockStyle.Fill, BackColor = System.Drawing.Color.Black };
                Right.Controls.Add(new Label() { TextAlign = System.Drawing.ContentAlignment.MiddleCenter, ForeColor = System.Drawing.Color.White, Dock = DockStyle.Fill, Text = "S.O.", Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))) }); ;
                Right.Controls.Add(new Panel { Dock = DockStyle.Bottom, Height = 3, BackColor = System.Drawing.Color.Black });
                Right.Controls.Add(new Label() { Dock = DockStyle.Top, Text = $"{Nucleo.RepresentarKB(Size)}", Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))) });
                miPanel.Controls.Add(Right);
            }
            else
            {
                if (Ocupada)
                {
                    Panel Left = new Panel()
                    {
                        Dock = DockStyle.Left,
                        Width = 150,
                        BackColor = System.Drawing.Color.White
                    };
                    Left.Controls.Add(new Label() { Dock = DockStyle.Top, Text = $"{id} ", Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))) });
                    Left.Controls.Add(new Label() { Dock = DockStyle.Top, Text = $"{ Nucleo.RepresentarKB(Posicion)}", Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))) });
                    Left.Controls.Add(new Panel { Dock = DockStyle.Bottom, Height = 3, BackColor = System.Drawing.Color.Black });
                    miPanel.Controls.Add(Left);
                    Panel Right = new Panel { Dock = DockStyle.Fill, BackColor = System.Drawing.Color.Red };
                    Right.Controls.Add(new Panel { Dock = DockStyle.Bottom, Height = 3, BackColor = System.Drawing.Color.Black });
                    Right.Controls.Add(new Label() { Dock = DockStyle.Top, Text = $"{Nucleo.RepresentarKB(Size)}", Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))) });
                    miPanel.Controls.Add(Right);
                }
                else
                {
                    Panel Left = new Panel()
                    {
                        Dock = DockStyle.Left,
                        Width = 150,
                        BackColor = System.Drawing.Color.White
                    };

                    Left.Controls.Add(new Label() { Dock = DockStyle.Top, Text = $"{ Nucleo.RepresentarKB(Posicion)}", Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))) });
                    Left.Controls.Add(new Panel { Dock = DockStyle.Bottom, Height = 3, BackColor = System.Drawing.Color.Black });
                    miPanel.Controls.Add(Left);
                    Panel Right = new Panel { Dock = DockStyle.Fill, BackColor = System.Drawing.Color.Blue };
                    Right.Controls.Add(new Panel { Dock = DockStyle.Bottom, Height = 3, BackColor = System.Drawing.Color.Black });
                    Right.Controls.Add(new Label() { Text = Nucleo.RepresentarKB(Size), Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))) });
                    miPanel.Controls.Add(Right);

                }
            }


            return miPanel;
        }


        public override string ToString()
        {
            if (String.IsNullOrEmpty(id))
            {
                return $"Espacio libre -> {Nucleo.RepresentarKB(Size)}"; 
            }
            else 
            {
                return $"{id} -> {Nucleo.RepresentarKB(Size)}"; 
            }
        }

        public static Particion operator +(Particion _p1, Particion _p2)
        {
            Particion _resultante = new Particion((_p1.Size + _p2.Size ), (_p1.Height + _p2.Height));
            return _resultante;
        }
    }
}
