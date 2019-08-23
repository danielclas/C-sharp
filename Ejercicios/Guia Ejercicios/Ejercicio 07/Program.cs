using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que pida por pantalla la fecha de nacimiento de una persona(día, mes y año) y
            calcule el número de días vividos por esa persona hasta la fecha actual(tomar la fecha del sistema
            con DateTime.Now).
            Nota: Utilizar estructuras selectivas.Tener en cuenta los años bisiestos.*/

            Console.Title = "Ejercicio 07";

            int anio, mes, dia;
            int dif;
            int acumDias = 0;
            int times = 5;
            double dias = 0;
            DateTime nacimiento;

            do
            {
                dif = 0;
                acumDias = 0;
                dias = 0;

                Console.WriteLine("Año de nacimiento: ");
                anio = int.Parse(Console.ReadLine());

                Console.WriteLine("Mes de nacimiento: ");
                mes = int.Parse(Console.ReadLine());

                Console.WriteLine("Dia de nacimiento: ");
                dia = int.Parse(Console.ReadLine());

                nacimiento = new DateTime(anio, mes, dia);            

                dif = DateTime.Now.Year - nacimiento.Year;

                dias = dif * 365;

                if (nacimiento.Month < DateTime.Now.Month)
                {
                    for (int j = nacimiento.Month; j < DateTime.Now.Month; j++)
                    {
                        acumDias += DiasEnMeses(j);
                    }
                    dias += acumDias;
                }
                else if (DateTime.Now.Month < nacimiento.Month)
                {
                    for (int j = DateTime.Now.Month; j != nacimiento.Month; j++)
                    {
                        acumDias += DiasEnMeses(j);
                        if (j == 12)
                            j = 0;
                    }
                    dias -= acumDias;
                }

                //Corrijo dias del mes corriente
                if (DateTime.Now.Day > nacimiento.Day)
                {
                    dias += DateTime.Now.Day - nacimiento.Day;
                }

                //Agrego dias por años bisiestos
                for (int i = nacimiento.Year; i < DateTime.Now.Year; i++)
                {
                    if (EsBisiesto(i))
                    {
                        dias++;
                    }
                }

                Console.WriteLine($"Tenes {dif} años, viviste {dias} dias");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("---------------------------");
                Console.ResetColor();
                Console.ReadKey();                
                times--;
            } while (times >= 0);
        }

        public static bool EsBisiesto(int i)
        {
            bool b = false;

            if (i > 0 && i % 4 == 0)
            {
                if (i % 100 == 0)
                {
                    if (i % 400 == 0)
                    {
                        b = true;
                    }
                }
                else
                {
                    b = true;
                }
            }

            return b;
        }

        public static int DiasEnMeses(int m)
        {
            int dias = 0;

            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dias = 31;
                    break;
                case 2:
                    dias = 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    dias = 30;
                    break;
                default:
                    break;
            }

            return dias;


        }
    }
}
