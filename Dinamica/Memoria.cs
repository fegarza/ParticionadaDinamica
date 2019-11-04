using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamica
{
    public class Memoria : IEnumerable
    {

        //Lista enlazada doble
        public Particion Primera;
        public Particion Ultima;
        public int Count = 0;
        public double MemoriaDisponible = 0;
        public string modo = "particiones";
        public List<string> nombresUsados = new List<string>();
        /// <summary>
        /// Altura total
        /// </summary>
        public int Height;
        /// <summary>
        /// Tamaño dado de KB
        /// </summary>
        public double Size = 0;
        /// <summary>
        /// Sistema operativo
        /// </summary>
        public Particion SO = null;
        /// <summary>
        /// Particiones
        /// </summary>
        public BindingList<Particion> StandBy = new BindingList<Particion>();
        /// <summary>
        /// Constructor para inicializar valores de la memoria
        /// </summary>
        /// <param name="_size">Tamaño en KB de la memoria</param>
        /// <param name="_height"> Altura  </param>
        public Memoria(double _size, int _height)
        {
            Size = _size;
            Height = _height;
            MemoriaDisponible = Size;
        }
        public void MostrarMemoriaDisponible()
        {
            modo = "libres";
            MemoriaDisponible = 0;
            foreach (Particion e in this)
            {
                MemoriaDisponible += e.Size;
            }
        }
        public Particion CrearParticion(double _size, bool _estado)
        {
            double value = (_size * 100) / Size;
            value = Nucleo.Truncate(value, 0);
            double porcentaje = 0;
            if (value.ToString().Length == 1)
            {
                porcentaje = double.Parse(".0" + value.ToString());
            }
            else
            {
                porcentaje = double.Parse("." + value.ToString());
            }

            double height = porcentaje * Height;
            int heightInt = (int)height;
            Particion P = new Particion(_size, heightInt, _estado);
            return P;
        }
        public Particion CrearParticion(double _size, bool _estado, string _titulo)
        {
            double value = (_size * 100) / Size;
            value = Nucleo.Truncate(value, 0);
            double porcentaje = 0;
            if (value.ToString().Length == 1)
            {
                porcentaje = double.Parse(".0" + value.ToString());
            }
            else
            {
                porcentaje = double.Parse("." + value.ToString());
            }

            double height = porcentaje * Height;
            int heightInt = (int)height;
            Particion P = new Particion(_size, heightInt, _estado, _titulo);
            return P;
        }
        public Particion TraerUltimo()
        {
            Particion actual = Primera;
            while (actual.Siguiente != null)
            {
                 
                actual = actual.Siguiente;
            }
            return actual;

        }
        public bool AgregarParticion(double _size, bool _estado, string _titulo)
        {

            bool encontradoTitulo = false;
            Particion actual = Primera;
            while (actual != null && !encontradoTitulo)
            {
                if (actual.id == _titulo)
                {
                    encontradoTitulo = true;
                    MessageBox.Show("El nombre de la tarea ya existe");
                }
                actual = actual.Siguiente;
            }
            if (!encontradoTitulo)
            {
                foreach (string x in nombresUsados)
                {
                    if (x == _titulo)
                    {
                        encontradoTitulo = true;
                        MessageBox.Show("El nombre de la tarea ya ha sido utilizado con anterioridad");

                    }
                }
            }
            if (!encontradoTitulo)
            {
                //En caso de no existir ninguna particion
                if (Primera == null)
                {
                    if (_size <= MemoriaDisponible)
                    {
                        Particion P = CrearParticion(_size, _estado, _titulo);
                        Primera = P;
                        Ultima = TraerUltimo();
                        nombresUsados.Add(_titulo);
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("No hay memoria disponible");
                        return false;
                    }
                }
                else
                {
                    bool insertado = false;
                    actual = Primera;
                    if (actual.Siguiente == null)
                    {
                        if (!actual.Ocupada)
                        {
                            if (_size <= actual.Size)
                            {
                                insertado = true;
                                if ((actual.Size - _size) != 0)
                                {
                                    Particion P = CrearParticion(_size, _estado, _titulo);
                                    nombresUsados.Add(_titulo);
                                    Particion next = CrearParticion((actual.Size - _size), false);
                                    next.Anterior = P;
                                    P.Siguiente = next;
                                    Primera = P;
                                    Ultima = TraerUltimo();
                                }
                                else
                                {
                                    Particion P = CrearParticion(_size, _estado, _titulo);
                                    nombresUsados.Add(_titulo);
                                    Primera = P;
                                    Ultima = TraerUltimo();
                                }
                            }
                        }
                    }
                    while (actual != null && !insertado)
                    {
                        if (actual.Ocupada)
                        {
                            actual = actual.Siguiente;
                        }
                        else
                        {
                            if (_size <= actual.Size)
                            {
                                //Tiene un anterior
                                if (actual.Anterior != null)
                                {
                                    //Particion con la tarea
                                    Particion P = CrearParticion(_size, _estado, _titulo);
                                    nombresUsados.Add(_titulo);
                                    Particion anterior = actual.Anterior;



                                    if ((actual.Size - _size) != 0)
                                    {
                                        //Particion con  el espacio libre
                                        Particion aux = CrearParticion((actual.Size - _size), false);
                                        aux.Siguiente = actual.Siguiente;
                                        aux.Anterior = P;
                                        P.Siguiente =
                                            aux;
                                        P.Anterior = anterior;
                                        anterior.Siguiente = P;
                                        Ultima = TraerUltimo();
                                        insertado = true;
                                    }
                                    else
                                    {
                                        //Solo la particion completa

                                        P.Siguiente = actual.Siguiente;
                                        P.Anterior = anterior;
                                        anterior.Siguiente = P;
                                        Ultima = TraerUltimo();
                                        insertado = true;
                                    }

                                }
                                else
                                {
                                    if ((actual.Size - _size) != 0)
                                    {
                                        Particion P = CrearParticion(_size, _estado, _titulo);
                                        nombresUsados.Add(_titulo);
                                        P.Siguiente = CrearParticion((actual.Size - _size), false).Siguiente = actual.Siguiente;
                                        Primera = P;
                                        Ultima = TraerUltimo();
                                    }
                                    else
                                    {
                                        Particion P = CrearParticion(_size, _estado, _titulo);
                                        nombresUsados.Add(_titulo);
                                        P.Siguiente = actual.Siguiente;
                                        Primera = P;
                                        Ultima = TraerUltimo();
                                    }
                                }


                            }
                            else
                            {
                                actual = actual.Siguiente;
                            }
                        }
                    }

                    return insertado;
                }

            }
            else
            {
                return false;
            }

        }
        public bool Librear(int _cont)
        {
            bool liberado = false;
            bool encontrado = false;
            Particion actual = Primera;
            int count = -1;
            while (actual != null && !encontrado)
            {
                
                if (actual.Ocupada )
                {
                    count++;

                }
              
                //MessageBox.Show($"-->({count}) id: {actual.id} ");
                if (count == _cont)
                {
                    
                    encontrado = true;
                    //en caso de que tenga los dos espacios libres
                    if (actual.Anterior != null && !actual.Anterior.Ocupada && actual.Siguiente != null && !actual.Siguiente.Ocupada)
                    {
                        //MessageBox.Show("Dos espacios libres para combinar");
                        double SizeTotal = actual.Anterior.Size + actual.Size + actual.Siguiente.Size;
                        Particion p = CrearParticion(SizeTotal, false);
                        p.Siguiente = actual.Siguiente.Siguiente;
                        if (actual.Siguiente.Siguiente != null)
                        {
                            actual.Siguiente.Siguiente.Anterior = p;
                        }
                        else
                        {

                            Ultima = p;
                        }
                        p.Anterior = actual.Anterior.Anterior;
                        if (actual.Anterior.Anterior != null)
                        {
                            actual.Anterior.Anterior.Siguiente = p;
                        }
                        else
                        {

                            Primera = p;
                        }
                        
                           

                    }
                    else if ((actual.Anterior != null && !actual.Anterior.Ocupada) || (actual.Siguiente != null && !actual.Siguiente.Ocupada))
                    {
                        //En caso de que tenga un espacio liberado anterior
                        if (actual.Anterior != null && !actual.Anterior.Ocupada)
                        {
                         //   MessageBox.Show($"Espacio libre a anterior de {actual.id} detectado");
                            //En caso de que se trate del primer elemento
                            if (actual.Anterior.Anterior == null)
                            {
                                double SizeTotal = actual.Anterior.Size + actual.Size;
                                Particion p = CrearParticion(SizeTotal, false);
                                p.Siguiente = actual.Siguiente;
                                if (actual.Siguiente != null)
                                {
                                    actual.Siguiente.Anterior = p;
                                }
                                actual.Anterior = p;
                                Primera = p;
                                encontrado = true;
                            }
                            else
                            {
                                double SizeTotal = actual.Anterior.Size + actual.Size;
                                Particion p = CrearParticion(SizeTotal, false);
                                p.Siguiente = actual.Siguiente;
                                if(actual.Siguiente != null)
                                {
                                    actual.Siguiente.Anterior = p;
                                }
                                else
                                {
                                    Ultima = p;
                                }
                                p.Anterior = actual.Anterior.Anterior;
                                actual.Anterior.Anterior.Siguiente = p;
                                encontrado = true;
                            }

                        }
                        //En caso de que tenga un espacio liberado siguiente
                        if (actual.Siguiente != null && !actual.Siguiente.Ocupada)
                        {
                           // MessageBox.Show("Espacio libre al siguiente detectado");                            //En caso de que se trate del primer elemento
                            if (actual.Anterior == null)
                            {
                                double SizeTotal = actual.Size + actual.Siguiente.Size;
                                Particion p = CrearParticion(SizeTotal, false);
                                p.Siguiente = actual.Siguiente.Siguiente;
                                if (actual.Siguiente.Siguiente != null)
                                {
                                    actual.Siguiente.Siguiente.Anterior = p;
                                }
                                else
                                {

                                    Ultima = p;
                                }
                                Primera = p;
                                liberado = true;
                                encontrado = true;
                            }
                            else
                            {
                                double SizeTotal = actual.Size + actual.Siguiente.Size;
                                Particion p = CrearParticion(SizeTotal, false);
                                p.Siguiente = actual.Siguiente.Siguiente;
                                if (actual.Siguiente.Siguiente != null)
                                {
                                    actual.Siguiente.Siguiente.Anterior = p;
                                }
                                else
                                {

                                    Ultima = p;
                                }

                                p.Anterior = actual.Anterior;
                                actual.Anterior.Siguiente = p;
                                liberado = true;
                                encontrado = true;
                            }
                        }
                    }
                    //No tiene espaciso libres a los lados
                    else
                    {
                        //MessageBox.Show("Aqui entra");
                        Particion na = new Particion(actual.Size, actual.Height);
                        na.Ocupada = false;
                        na.Siguiente = actual.Siguiente;
                        na.Anterior = actual.Anterior;
                        if(actual.Siguiente != null || actual.Anterior != null)
                        {
                            if (actual.Anterior != null)
                            {
                                actual.Anterior.Siguiente = na;
                            }
                            else
                            {
                                Primera = na;
                            }
                            if (actual.Siguiente != null)
                            {
                                actual.Siguiente.Anterior = na;
                            }
                            else
                            {
                                Ultima = na;
                            }
                            
                        }
                        
                      
                        liberado = true;
                    }
                }
                else
                {
                    actual = actual.Siguiente;
                }
            }


            return liberado;
        }
      
        public IEnumerator GetEnumerator()
        {
            if (modo == "particiones")
            {
                Particion actual = Ultima;
                while (actual != null)
                {
                    yield return actual;
                    actual = actual.Anterior;
                }
            }
            else if (modo == "tareas")
            {
                Particion actual = Primera;
                while (actual != null)
                {
                    if (actual.Ocupada)
                    {
                        yield return actual;
                    }
                    actual = actual.Siguiente;
                }
            }
            else if (modo == "libres")
            {
                Particion actual = Ultima;
                while (actual != null)
                {
                    if (!actual.Ocupada)
                    {
                        yield return actual;
                    }
                    actual = actual.Anterior;
                }
            }
        }
        /// <summary>
        /// Agrega el sistema operativo
        /// </summary>
        /// <param name="_size">Tamaño dado en KB</param>
        /// <returns></returns>
        public bool AgregarSO(double _size)
        {
            if (_size <= (Size * .3))
            {
                double value = (_size * 100) / Size;
                value = Dinamica.Nucleo.Truncate(value, 0);
                double porcentaje = 0;
                if (value.ToString().Length == 1)
                {
                    porcentaje = double.Parse(".0" + value.ToString());
                }
                else
                {
                    porcentaje = double.Parse("." + value.ToString());
                }

                double height = porcentaje * Height;
                int heightInt = (int)height;
                if (_size <= (Size * .3))
                {
                    SO = new Particion(_size, heightInt);
                    SO.SO = true;
                    MemoriaDisponible -= SO.Size;
                    AgregarParticion(MemoriaDisponible, false, "Sistema operativo");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
