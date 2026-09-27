using System.Text;
namespace Jugador
{
    public class PuntosJugador
    {
        #region Atributos
        private string nombreJugador;
        private int puntos;
        private int nivel;
        #endregion

        #region Constructores

        // Constructor vacio
        public PuntosJugador()
        {
            this.nombreJugador = "Desconocido";
            this.puntos = 0;
            this.nivel = 1;
        }

        // Constructor nombre (con encadenado vacio)
        public PuntosJugador(string nombre):this()
        {
            this.nombreJugador = nombre;
        }

        // Constructor puntos (con encadenado de nombre)
        public PuntosJugador(string nombre, int puntos) : this(nombre)
        {
            if(puntos >= 0)
            {
                this.puntos = puntos;
            }
            else
            {
                this.puntos = 0;
            }
            
        }

        // Constructor nivel (con encadenado de puntos que a su vez tiene encadenado de nombre)
        public PuntosJugador(string nombre,int puntos,int nivel) : this(nombre, puntos)
        {
            if(nivel >= 1)
            {
                this.nivel = nivel;
            }
            else
            {
                this.nivel = 1;
            }
        }
        #endregion

        #region Metodos
        // Metodo AgregarPuntos

        public void AgregarPuntos(int puntos)
        {
            if (puntos > 0)
            {
                this.puntos += puntos;
            }
            else
            {
                throw new ArgumentException("No se pueden sumar puntos negativos");
            }
        }

        // Metodo AgregarPuntos con motivo
        public void AgregarPuntos(int puntos, string motivo)
        {
            this.AgregarPuntos(puntos);
        }


        // Metodo AgregarPuntos con motivo y bonificacion
        public void AgregarPuntos(int puntos, string motivo, bool bonificacion)
        {
            int total = puntos;
            if (bonificacion)
            {
                total += 15;
            }
            this.AgregarPuntos(total, motivo);
        }

        // Metodo MostrarInformacion

        public string MostrarInformacion ()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\t\t ----INFORMACION----");
            sb.AppendLine($"Nombre: {this.nombreJugador}");
            sb.AppendLine($"Puntos: {this.puntos}");
            sb.AppendLine($"Nivel: {this.nivel}");
            sb.AppendLine("--------");

            return sb.ToString();

        }

        #endregion

    }
}
