using System;

namespace ProyectoRPG
{
    public class Mago : Personaje
    {
        /*
         Se encapsulo el atributo mediante una propiedad publica con 
         acceso a get y un internal set 
         */
        public int Mana { get; internal set; } 
        public string hechizo;

        /*
         * Se paso el parametro nombre de la clase base
         */
        public Mago(string nombre) :base(nombre)
        {
            Mana = 100;
            this.hechizo = "Bola de fuego";
        }

        public void LanzarHechizo()
        {
            if (Mana >= 20)
            {
                Console.WriteLine(nombre + " lanza " + hechizo + "!");
                Mana -= 20;
                Console.WriteLine("Mana restante: " + Mana);
            }
            else
            {
                Console.WriteLine("Mana insuficiente para lanzar el hechizo.");
            }
        }

        public void Meditar()
        {
            Mana += 30;
            if (Mana > 100) Mana = 100;
            Console.WriteLine(nombre + " medita y recupera mana. Mana actual: " + Mana);
        }
    }
}
