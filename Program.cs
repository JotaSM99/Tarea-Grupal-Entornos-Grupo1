using System;

namespace CIFPCarlosIII.ED.UT04.Grupo1

{
    /// <summary>
    /// La clase principal donde se ejecuta el programa principal
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BIENVENIDO AL REINO DE LOS HÉROES ===\n");

            Personaje personaje = new Personaje();
            personaje.Nombre = "Héroe Genérico";
            Console.WriteLine("Se ha creado un personaje: " + personaje.Nombre);
            personaje.Atacar();
            personaje.SubirNivel();

            Console.WriteLine("\n--- Guerrero ---");
            Guerrero guerrero = new Guerrero();
            guerrero.Nombre = "Guerrero Valiente";
            guerrero.Atacar();
            guerrero.AtaquePoderoso();
            guerrero.DefenderseConEscudo();

            Console.WriteLine("\n--- Berserker ---");
            Berserker berserker = new Berserker(10, "Hacha", 25);
            berserker.Nombre = "Destructor";
            berserker.EntrarEnFuria();
            berserker.EntrarEnFuria();
            berserker.AtaqueFurioso();
            Console.WriteLine("\n" + berserker.MostrarInfo());
            
            
            Console.WriteLine("\n--- Mago ---");
            Mago magi = new Mago();
            magi.Nombre = "Merlín";
            magi.LanzarHechizo();
            magi.LanzarHechizo();
            magi.Meditar();
            magi.LanzarHechizo();

            Console.WriteLine("\n--- Nigromante ---");
            Nigromante nigromante = new Nigromante(120, "Lanzar Fuego", 40);
            nigromante.Nombre = "Señor Oscuro";
            nigromante.CapturarAlma();
            nigromante.CapturarAlma();
            nigromante.InvocarNoMuerto();
            nigromante.DrenarVida();

            Console.WriteLine("\n=== FIN DE LA DEMOSTRACIÓN ===");
            Console.ReadLine();
        }
    }
}
