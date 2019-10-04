using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Animal
    {
        protected int cantidadPatas;
        protected static Random distanciaRecorrida;
        protected int velocidadMaxima;

        public int CantidadPatas
        {
            get { return this.cantidadPatas; }
            set
            {
                if (value<=4)
                {
                    this.cantidadPatas = value;
                }
                else
                {
                    cantidadPatas = 4;
                }
            }
        }
        public int DistanciaRecorrida { get { return distanciaRecorrida.Next(10, this.VelocidadMaxima); } }
        public int VelocidadMaxima
        {
            get { return this.velocidadMaxima; }
            set
            {
                if (value <= 60)
                {
                    this.velocidadMaxima = value;
                }
                else
                {
                    this.velocidadMaxima = 60;
                }
            }
        }
        static Animal()
        {
            distanciaRecorrida = new Random();
        }

        public Animal(int cantidadPatas, int velocidadMaxima)
        {
            this.CantidadPatas = cantidadPatas;
            this.VelocidadMaxima = velocidadMaxima;
        }

        public string MostrarDatos()
        {
            return ($"Patas: {this.CantidadPatas} VMax: {this.VelocidadMaxima} Distancia: {this.DistanciaRecorrida}");
        }

    }
}
