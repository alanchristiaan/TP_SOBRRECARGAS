using Jugador;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Descripcion
            /* El siguiente program se basa en el conocido juego de Quidditch de la saga de Harry Potter  de J. K. Rowling
             * El juego consta de 2 equipos rivales entre si de 7 jugadores cada uno en el campo
             * Tres cazadores que tienen la funcion de marcar goles con la Quaffle
             * Dos golpeadores que tienen la funcion que proteger a los jugadores de las bludgers
             * Un guardian que tiene como objetivo cuidar los aros aliados de que los rivales conviertan los golees (arquero)
             * Un buscador que tiene como objetivo atrapar la Snitch (o Snidget) dorada
             * El juego tiene por definicion 3 tipo de bolas en el juego
             * Quaffle: es la bola que actua de bola normal la cual para generar puntos con ella se debe ingresar a un aro (por campo hay 6 aros, 3 asignadas por equipo)
             * Bludgers: son 2 pelotas que persiguen a los jugadores para evitar la conversion de puntos y afectar la estrategia de los jugadores
             * Snitch dorada: es una bola pequeña con dos alas de colibri a los costados que tiene como funcion escapar, el buscador de cada equipo debe capturarla
             * Una vez capturada la snitch el juego se termina y se suman los puntos a los convertidos por la quaffle
             * En la normalidad se tiene tiene en cuenta que cada gol con la Quaffle cuenta 10 puntos y al agarrar la snitch son 150 puntos al equipo
             * En este caso reduje un 10% a los puntos logrados, por ende 10 = 1 y 150 = 15
             * Se maneja una funcion de bonificacion que va a estar marcada por la variable SNITCH de tipo bool inicialiizada en true
             * En el caso de que un jugador atrape la snitch, simplemente en la funcion se escribira SNITCH en lugar de True
             */

            bool SNITCH = true;
            Console.Title = "Ejercicio PuntosJugador - Sistema de Puntos";

            Console.WriteLine("=== DEMOSTRACIÓN DE CONSTRUCTORES ===");

            // 1. Probamos el constructor sin parámetros
            PuntosJugador j1 = new PuntosJugador();

            // 2. Probamos el constructor con solo Nombre
            PuntosJugador j2 = new PuntosJugador("Harry");

            // 3. Probamos el constructor con Nombre y Puntos
            PuntosJugador j3 = new PuntosJugador("Draco", 10);

            // 4. Probamos el constructor completo (Nombre, Puntos y Nivel)
            PuntosJugador j4 = new PuntosJugador("Krum", 50, 10);

            // Mostramos los estados iniciales
            Console.WriteLine(j1.MostrarInformacion());
            Console.WriteLine(j2.MostrarInformacion());
            Console.WriteLine(j3.MostrarInformacion());
            Console.WriteLine(j4.MostrarInformacion());

            Console.WriteLine("\n=== DEMOSTRACIÓN DE SOBRECARGAS DE AGREGARPUNTOS ===");

            try
            {
                // Versión 1: AgregarPuntos(int)
                Console.WriteLine("Agregando 15 Puntos a Harry (Primer metodo)");
                j2.AgregarPuntos(15);

                // Versión 2: AgregarPuntos(int, string)
                Console.WriteLine("Agregando 10 puntos a Draco por anotaciones con Quaffle (Segundo Metodo)");
                j3.AgregarPuntos(10, "Anotaciones con Quaffle");

                // Versión 3: AgregarPuntos(int, string, bool) -> Con Bonificación por Snitch (+15)
                Console.WriteLine($"Agregando puntos por Quaffle llamando al segundo metodo y bonificacion por SNITCH ={SNITCH}");
                j4.AgregarPuntos(50, "Atrapó la Snitch mas anotaciones con Quaffle", SNITCH);

                Console.WriteLine("\n=== ESTADO FINAL DE LOS JUGADORES ===");
                Console.WriteLine(j2.MostrarInformacion());
                Console.WriteLine(j3.MostrarInformacion());
                Console.WriteLine(j4.MostrarInformacion());

                // Prueba de Validación de Error
                Console.WriteLine("=== PRUEBA DE VALIDACIÓN DE PUNTOS NEGATIVOS ===");
                Console.WriteLine("--> Intentando agregar -5 puntos a Harry...");
                j2.AgregarPuntos(-5);
            }
            catch (ArgumentException ex)
            {
                // Atajamos el error lanzado desde la clase
                Console.WriteLine($"\n[ERROR CAPTURADO]: {ex.Message}");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
