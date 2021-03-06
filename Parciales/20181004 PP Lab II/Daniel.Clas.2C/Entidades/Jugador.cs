﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador:Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public float Altura { get { return this.altura; } }
        public float Peso { get { return this.peso; } }
        public Posicion Posicion { get { return this.posicion; } }

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion):base(nombre, apellido, edad, dni)
        {
            this.posicion = posicion;
            this.peso = peso;
            this.altura = altura;
        }

        public string Mostrar()
        {
            StringBuilder str = new StringBuilder(base.Mostrar());

            str.Append($"{this.Altura}cm, {this.Peso}kg. {Posicion}");

            return str.ToString();
        }

        public override bool ValidarAptitud()
        {
            return (this.ValidarEstadoFisico() && this.Edad < 40);
        }

        public bool ValidarEstadoFisico()
        {
            double imc = 20;

            return (imc >= 18.5 && imc <= 25);
        }

    }

    public enum Posicion
    {
        Arquero, Defensor, Central, Delantero
    }
}
