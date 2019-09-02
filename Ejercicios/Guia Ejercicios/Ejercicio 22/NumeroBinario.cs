using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_13;

namespace Ejercicio_22
{
    class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public string GetNumero() { return numero; }

        //Recibe un binario y un decimal, hace la suma y devuelve binario
        public static string operator +(NumeroBinario b, NumeroDecimal d)
        {
            string result;
            double num=d.GetNumero();
            double num2 = Conversor.BinarioDecimal(b.GetNumero());

            num += num2;

            result = Conversor.DecimalBinario(num);       

            return result;
        }

        //Recibe un binario y un decimal, hace la resta y devuelve binario
        public static string operator -(NumeroBinario b, NumeroDecimal d)
        {
            string result;
            double num = d.GetNumero();
            double num2 = Conversor.BinarioDecimal(b.GetNumero());

            num -= num2;

            if (num <= 0)
            {
                result = "Valor negativo";
            }
            else
            {
                result = Conversor.DecimalBinario(num);
            }

            return result;
        }

        public static bool operator ==(NumeroBinario b, NumeroDecimal d)
        {
            double num = Conversor.BinarioDecimal(b.GetNumero());
            bool rtnVal = false;

            if (num == d.GetNumero())
            {
                rtnVal = true;
            }

            return rtnVal;
        }

        public static bool operator !=(NumeroBinario b, NumeroDecimal d)
        {
            double num = Conversor.BinarioDecimal(b.GetNumero());
            bool rtnVal = false;

            if (num != d.GetNumero())
            {
                rtnVal = true;
                Console.WriteLine(num);
                Console.WriteLine(d.GetNumero());
            }

            return rtnVal;
        }

        //        e.NumeroBinario objBinario = "1001";
        //        f.NumeroDecimal objDecimal = 9;
        //        Agregar conversiones explícitas para poder ejecutar:
        //g. (string)objBinario
        //h. (double)objDecimal

        public static implicit operator NumeroBinario(string s)
        {
            NumeroBinario bin=new NumeroBinario(s);                                
            
            return bin;
        }

        public static explicit operator string(NumeroBinario b)
        {
            string rtn = b.GetNumero();

            return rtn;
        }


    }
}
