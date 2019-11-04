using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinamica
{
    public  static class Nucleo
    {
        public static double Truncate(double value, int decimales)
        {
            double aux_value = Math.Pow(10, decimales);
            return (Math.Truncate(value * aux_value) / aux_value);
        }
        public static double TransformarAKB(double _cantidad, string _tipo)
        {
            _tipo = _tipo.ToLower();
            switch (_tipo)
            {
                case "mb":
                    _cantidad = _cantidad * 1024;
                    break;
                case "gb":
                    _cantidad = _cantidad * 1024 * 1024;
                    break;
            }
            return _cantidad;
        }
        public static string RepresentarKB(double _cantidad)
        {
            string unidad = "KB";
            if(_cantidad >= 1024)
            {
                _cantidad = _cantidad / 1024;
                unidad = "MB";
                if(_cantidad >= 1024)
                {
                    unidad = "GB";
                    _cantidad = _cantidad / 1024;
                    if(_cantidad >= 1024)
                    {
                        unidad = "TB";
                        _cantidad = _cantidad / 1024;
                    }
                }
            }
            return $"{_cantidad.ToString()} {unidad}";

            
        }
    }
}
