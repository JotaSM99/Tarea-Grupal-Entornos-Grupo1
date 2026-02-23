using System;

namespace CIFPCarlosIII.ED.UT04.GrupoX

{
    public class Personaje
    {
        /*
         * Se creo un atributo publico de tipo string llamado nombre
         */
        public string nombre; 
        public int vida;
        public int nivel;

        public Personaje()
        {
            
        }
        public Personaje(string nombre)
        {
            this.nombre = nombre;
            this.vida = 100;
            this.nivel = 1;
        }

        public void Atacar()
        {
            Console.WriteLine(nombre + " realiza un ataque básico!");
        }

        public void RecibirDanio(int danio)
        {
            vida -= danio;
            Console.WriteLine(nombre + " recibe " + danio + " de daño. Vida restante: " + vida);
        }

        public void SubirNivel()
        {
            nivel++;
            vida += 20;
            Console.WriteLine(nombre + " ha subido al nivel " + nivel + "!");
        }
    }
}
