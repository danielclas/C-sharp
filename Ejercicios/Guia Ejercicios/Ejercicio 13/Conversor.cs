using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        public static string DecimalBinario(double num)
        {
            string bin = "";
            string auxBin = "";
            StringBuilder aux = new StringBuilder("");
            int module;
            int result = (int)num;
            int divInt;
            int times = 0;
            double fract = num % 1;

            do
            {
                module = result % 2;
                result = result / 2;
                aux.Append(module.ToString());

            } while (result / 2 != 1);

            module = result % 2;
            result = result / 2;
            aux.Append(module.ToString());
            aux.Append(result.ToString());
            auxBin = aux.ToString();

            for (int i = auxBin.Length - 1; i >= 0; i--)
            {
                bin += auxBin[i];
            }

            if (fract != 0)
            {
                bin += '.';
                //La parte fraccionaria por dos, guardo el entero
                do
                {
                    fract = fract * 2;
                    divInt = (int)fract;
                    if (fract >= 1)
                    {
                        fract = fract % 1;
                    }
                    bin += divInt.ToString();
                    times++;
                } while (times < 4);
            }

            return bin;

        }

        public static double BinarioDecimal(string num)
        {
            double dec = 0;

            for (int i = num.Length - 1, exp = 0; i >= 0; i--, exp++)
            {
                if (num[i] == '1')
                {
                    dec += Math.Pow(2, exp);
                }
            }

            return dec;

        }

        public static string FormatearBinario(string bin)
        {
            string newBin = "";
            int resto = 0;
            int i;
            int len = 0;

            if (bin.Contains('.')) {
                len = bin.IndexOf('.');
            }
            else
            {
                len = bin.Length;
            }

            if (len >= 5)
            {
                resto = len % 4;

                for (i = 0; i < resto; i++)
                {
                    newBin += bin[i];
                }

                newBin += ' ';
                for (int j = 1; i < len; i++, j++)
                {
                    newBin += bin[i];
                    if (j % 4 == 0)
                    {
                        if (i != len - 1)
                        {
                            newBin += ' ';
                        }

                        j = 0;
                    }
                }

                if (bin.Contains('.'))
                {
                    //Agrego substring del nro. desde el punto en adelante
                    newBin += ' ';
                    newBin += bin.Substring(len);
                }

            }
            else
            {
                newBin = bin;
            }

            return newBin;

        }
    }
}
