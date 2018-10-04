using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(string nombre) :this()
        {
            this.nombre = nombre;
        }

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                this.directorTecnico = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        /// <summary>
        /// Muestra los datos del equipo
        /// </summary>
        /// <param name="e">instancia de un equipo</param>
        public static explicit operator string(Equipo e)
        {
            StringBuilder myStringBuilder = new StringBuilder();
            myStringBuilder.AppendFormat("{0}", e.nombre);

            if (e.directorTecnico is null)
            {
                myStringBuilder.AppendFormat("{0}", "Sin DT asignado");
                myStringBuilder.AppendLine("");
            }
            else
            {
                myStringBuilder.AppendFormat("{0}", e.directorTecnico);
                myStringBuilder.AppendLine("");
            }

            for (int i = 0; i < e.jugadores.Count; i++)
            {
                myStringBuilder.AppendLine("");
                myStringBuilder.AppendFormat("{0},{1},{2}", e.jugadores[i].Altura, e.jugadores[i].Peso, e.jugadores[i].Posicion);
                myStringBuilder.AppendLine("");
            }
            return myStringBuilder.ToString();
        }

        /// <summary>
        /// Compara si un jugador se encuntra en un equipo
        /// </summary>
        /// <param name="e">equipo</param>
        /// <param name="j">jugador</param>
        /// <returns>true si el jugador pertenece al equipo. False si no pertence </returns>
        public static bool operator ==(Equipo e, Jugador j)
        {
            bool retorno = false;

            for (int i = 0; i < e.jugadores.Count; i++)
            {
                if (e.jugadores[i] == j)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
           if (e.jugadores is null)
            {
                return e;
            }
            
            for (int i = 0; i < e.jugadores.Count; i++)
            {
                if (e.jugadores[i] == j)
                {
                    return e;
                }
            }
            if ((e.jugadores.Count < e.cantidadMaximaJugadores) && (j.ValidarAptitud() == true))
            {
                e.jugadores.Add(j);
            }
            return e;
        }

        public static bool ValidarEquipo(Equipo e)
        {
            if (e.jugadores.Count < e.cantidadMaximaJugadores || e.directorTecnico is null)
            {
                return false;
            }

            for (int i = 0; i < e.jugadores.Count; i++)
            {
               /* if (e.jugadores[i].Posicion == 1)
                {
                    return e;
                }*/
            }

            return true;
        }
    }
}
