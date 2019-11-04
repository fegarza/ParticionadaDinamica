using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinamica
{
    class Lista<Tipo> : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Tipo Primero;
        public Tipo Ultimo; 
        public Lista()
        {

        }
       
    }
}
