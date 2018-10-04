using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador: Persona
    {
        float altura;
        float peso;
        Posicion posicion;

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion) :base(nombre,apellido,edad,dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }

        public float Altura
        {
            get
            {
                return altura;
            }
        }
        public float Peso
        {
            get
            {
                return peso;
            }
        }
        public Posicion Posicion
        {
            get
            {
                return posicion;
            }
        }

        public override string Mostrar()
        {
            StringBuilder myStringbuilder = new StringBuilder();
            myStringbuilder.AppendFormat("{0}, {1}, {2}, {3}", base.Mostrar(), this.Altura,this.Peso,this.Posicion);
            return myStringbuilder.ToString();
        }

        public bool ValidarEstadoFisico()
        {
            bool retorno = false;
            float imc = this.Peso/(this.Altura*this.Altura);
            if (imc >= 18.5 && imc <= 25)
            {
                retorno = true;
            }
            return retorno;
        }

        public bool ValidarAptitud()
        {
            bool retorno = false;
            if ((this.Edad <= 40) && (this.ValidarEstadoFisico() == true))
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
