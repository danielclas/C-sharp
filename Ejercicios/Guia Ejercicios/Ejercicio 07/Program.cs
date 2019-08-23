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
      int i;
      int acumDias = 0;
      bool b = false;
      double dias = 0;
      DateTime nacimiento;

      Console.WriteLine("Año de nacimiento: ");
      anio = int.Parse(Console.ReadLine());

      Console.WriteLine("Mes de nacimiento: ");
      mes = int.Parse(Console.ReadLine());

      Console.WriteLine("Dia de nacimiento: ");
      dia = int.Parse(Console.ReadLine());

      nacimiento = new DateTime(anio, mes, dia);

      Console.Clear();

      dif = DateTime.Now.Year - nacimiento.Year;

      if (DateTime.Now.Month <= nacimiento.Month)
      {
        if (DateTime.Now.Month == nacimiento.Month)
        {
          if (DateTime.Now.Day < nacimiento.Day)
          {
            dif--;
          }
        }
        else
        {
          dif--;
        }
      }

      dias = dif * 365;

      for (int j = nacimiento.Month ; j < DateTime.Now.Month; j++)
      {
        if (j % 2 == 0)
        {
          if (j == 2) {
            acumDias += 28;
          }
          else
          {
            acumDias += 30;
          }          
        }
        else
        {
          acumDias += 31;
        }
      }

      dias += acumDias;

      if (DateTime.Now.Day>nacimiento.Day)
      {
        dias += DateTime.Now.Day - nacimiento.Day;
      }
      

      for (i = nacimiento.Year; i < DateTime.Now.Year; i++)
      {      
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

        if (b)
        {
          dias++;
        }

        b = false;
      }

      Console.WriteLine($"Tenes {dif} años, viviste {dias} dias");

      Console.ReadKey();
    }
  }
}
