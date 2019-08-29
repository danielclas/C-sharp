using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //a.La cantidad máxima de tinta para todos los bolígrafos será de 100.Generar una constante
            //en el Boligrafo llamada cantidadTintaMaxima donde se guardará dicho valor.
            //b.Generar los métodos GetColor y GetTinta para los correspondientes atributos(sólo
            //retornarán el valor del mismo).
            //c.Generar el método privado SetTinta que valide el nivel de tinta y asigne en el atributo.
            //i.tinta será el valor a agregar de tinta, pudiendo ser positivo(cargar tinta) o negativo
            //(gastar tinta)
            //ii.Se deberá validar que el nivel de tinta quede entre los valores válidos mayor o igual a
            //0 y menor o igual a cantidadTintaMaxima.
            //d.Recargar() colocará a tinta en su nivel máximo de tinta.Reutilizar código.
            //e.En el Main, crear un bolígrafo de tinta azul(ConsoleColor.Blue) y una cantidad inicial de tinta
            //de 100 y otro de tinta roja(ConsoleColor.Red) y 50 de tinta.
            //f.El método Pintar(short, out string) restará la tinta gastada(reutilizar código SetTinta), sin
            //poder quedar el nivel en negativo, avisando si pudo pintar(nivel de tinta mayor a 0).
            //También informará mediante el out string tantos "*" como haya podido "gastar" del nivel de
            //tinta.O sea, si nivel de tinta es 10 y gasto es 2 valdrá "**" y si nivel de tinta es 3 y gasto es
            //10 "***".
            //g.Utilizar todos los métodos en el Main.
            //h.Al utilizar Pintar, si corresponde, se deberá dibujar por pantalla con el color de dicho
            //bolígrafo.

            Console.Title = "Ejercicio 17";            string dibujo = "";            Boligrafo boligrafo1 = new Boligrafo(100, ConsoleColor.DarkBlue);            Boligrafo boligrafo2 = new Boligrafo(90, ConsoleColor.DarkRed);            Boligrafo boligrafo3 = new Boligrafo(30, ConsoleColor.DarkGreen);            Boligrafo boligrafo4 = new Boligrafo(0, ConsoleColor.DarkCyan);            Console.WriteLine($"Boligrafo 1: {boligrafo1.GetColor()}, {boligrafo1.GetTinta()}");
            Console.WriteLine($"Boligrafo 2: {boligrafo2.GetColor()}, {boligrafo2.GetTinta()}");
            Console.WriteLine($"Boligrafo 3: {boligrafo3.GetColor()}, {boligrafo3.GetTinta()}");
            Console.WriteLine($"Boligrafo 4: {boligrafo4.GetColor()}, {boligrafo4.GetTinta()}");            boligrafo1.Pintar(80, out dibujo);            Console.BackgroundColor = boligrafo1.GetColor();            Console.WriteLine(dibujo);            boligrafo2.Pintar(100, out dibujo);            Console.BackgroundColor = boligrafo2.GetColor();            Console.WriteLine(dibujo);

            Console.WriteLine("Recargando");            boligrafo2.Recargar();
            boligrafo2.Pintar(99, out dibujo);            Console.WriteLine(dibujo);                   boligrafo3.Pintar(20, out dibujo);            Console.BackgroundColor = boligrafo3.GetColor();            Console.WriteLine(dibujo);            boligrafo4.Pintar(10, out dibujo);            Console.BackgroundColor = boligrafo4.GetColor();            Console.WriteLine(dibujo);            Console.ReadKey();
        }
    }

    class Boligrafo
    {
        const short cantidadTintaMaxima = 100;

        private ConsoleColor color;
        private short tinta;

        public short GetTinta()
        {
            return tinta;
        }

        public ConsoleColor GetColor()
        {
            return color;
        }

        private void SetTinta(short tinta)
        {
            int sum = this.tinta+tinta;

            if (sum <= cantidadTintaMaxima && sum>=0)
            {
                this.tinta += tinta;
            }
            else if (sum>=cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        //El método Pintar(short, out string) restará la tinta gastada(reutilizar código SetTinta), sin
        //poder quedar el nivel en negativo, avisando si pudo pintar(nivel de tinta mayor a 0).
        //También informará mediante el out string tantos "*" como haya podido "gastar" del nivel de
        //tinta.O sea, si nivel de tinta es 10 y gasto es 2 valdrá "**" y si nivel de tinta es 3 y gasto es
        //10 "***".

        public bool Pintar(short gasto, out string Dibujo)
        {
            bool k = false;
            short neg = 0;
            int i = 0;
            string cant = "";            

            if (gasto < tinta)
            {
                neg = gasto;
                neg *= -1;
                SetTinta(neg);
                k = true;
            }

            if (k)
            {
                for (; i < gasto; i++)
                {
                    cant += ' ';
                }

                cant += i;
            }
            else
            {
                cant = "No se pudo pintar";
            }

            Dibujo = cant;

            return k;
        }
    }
}
