using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios.Commons
{
    public class Comparator
    {
        public bool IsBetween_Int(int valor, int menor, int mayor)
        {
            return (valor >= menor && valor <= mayor);
        }
        public bool IsBetween_Double(double valor, double menor, double mayor)
        {
            return (valor >= menor && valor <= mayor);
        }

        public bool IsEqual_Int(int valor, int comparador)
        {
            return valor == comparador;
        }

        public bool IsEqual_Double(double valor, double comparador)
        {
            return valor == comparador;
        }

        //public bool NumIsDiferent(int value, int[] numbers)
        //{
            
        //}
    }
}
