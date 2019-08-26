using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear la clase Alumno de acuerdo al siguiente diagrama: ...
            //a.Se pide crear 3 instancias de la clase Alumno(3 objetos) en la función Main. Colocarle
            //nombre, apellido y legajo a cada uno de ellos.
            //b.Sólo se podrá ingresar las notas(nota1 y nota2) a través del método Estudiar.
            //c.El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o             iguales a 4, caso contrario la inicializará con - 1.Para darle un valor a la nota final utilice
            //el método de instancia Next de la clase Random.
            //d.El método Mostrar, expondrá en la consola todos los datos de los alumnos. La nota final se
            //mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda "Alumno
            //desaprobado".

            Console.Title = "Ejercicio 16";

            Alumno alumno1 =new Alumno("Daniel", "Clas", 1001);
            Alumno alumno2 = new Alumno("Jorge", "Lopez", 1002);
            Alumno alumno3 = new Alumno("Juan", "Perez", 1003);

            alumno1.Estudiar(1, 10);
            alumno2.Estudiar(4, 6);
            alumno3.Estudiar(8, 8);

            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());

            Console.ReadKey();

        }
    }

    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;

        string nombre;
        string apellido;
        int legajo;

        public void Estudiar(byte nota1, byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;

        }

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public string Mostrar()
        {
            string str = "";
            string final = "";

            if (notaFinal==-1)
            {
                final = "Alumno desaprobado";
            }
            else
            {
                final = notaFinal.ToString();
            }

            str += ($"{apellido}, {nombre}. Nota 1: {nota1}, Nota 2: {nota2}. Final: {final}");

            return str;
        }

        //El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores
        //o iguales a 4, caso contrario la inicializará con - 1.Para darle un valor a la nota final utilice
        ////el método de instancia Next de la clase Random.
        ///

        public void CalcularFinal()
        {
            Random next = new Random();

            if (nota1 >= 4 && nota2 >= 4)
            {
                notaFinal = next.Next(1, 10);
            }
            else
            {
                notaFinal = -1;
            }

        }

    }
}
