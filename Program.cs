using System;

namespace CIFPCarlosIII.ED.UT04.GrupoX

{
    /// <summary>
    /// La clase principal del programa, donde se ejecuta todo.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BIENVENIDO AL REINO DE LOS HÉROES ===\n");

            Personaje personaje = new Personaje();
            personaje.nombre = "Héroe Genérico";
            Console.WriteLine("Se ha creado un personaje: " + personaje.nombre);
            personaje.Atacar();
            personaje.SubirNivel();

            Console.WriteLine("\n--- Guerrero ---");
            Guerrero guerrero = new Guerrero();
            guerrero.nombre = "Guerrero Valiente";
            guerrero.Atacar();
            guerrero.AtaquePoderoso();
            guerrero.DefenderseConEscudo();

            Console.WriteLine("\n--- Berserker ---");
            Berserker berserker = new Berserker(10, "Hacha", 25);
            berserker.nombre = "Destructor";
            berserker.EntrarEnFuria();
            berserker.EntrarEnFuria();
            berserker.AtaqueFurioso();
            Console.WriteLine("\n" + berserker.MostrarInfo());
            
            
            Console.WriteLine("\n--- Mago ---");
            Mago magi = new Mago();
            magi.nombre = "Merlín";
            magi.LanzarHechizo();
            magi.LanzarHechizo();
            magi.Meditar();
            magi.LanzarHechizo();

            Console.WriteLine("\n--- Nigromante ---");
            Nigromante nigromante = new Nigromante(120, "Lanzar Fuego", 40);
            nigromante.nombre = "Señor Oscuro";
            nigromante.CapturarAlma();
            nigromante.CapturarAlma();
            nigromante.InvocarNoMuerto();
            nigromante.DrenarVida();

            Console.WriteLine("\n=== FIN DE LA DEMOSTRACIÓN ===");
            Console.ReadLine();
        }
    }
}
