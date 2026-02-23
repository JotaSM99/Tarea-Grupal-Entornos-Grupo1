using System;

namespace ProyectoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== BIENVENIDO AL REINO DE LOS HÉROES ===\n");

            Personaje pers = new Personaje();
            pers.nombre = "Héroe Genérico";
            Console.WriteLine("Se ha creado un personaje: " + pers.nombre);
            pers.Atacar();
            pers.SubirNivel();

            Console.WriteLine("\n--- Guerrero ---");
            Guerrero guer = new Guerrero();
            guer.nombre = "Guerrero Valiente";
            guer.Atacar();
            guer.AtaquePoderoso();
            guer.DefenderseConEscudo();

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
