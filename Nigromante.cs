using System;

namespace CIFPCarlosIII.ED.UT04.GrupoX

{
    /// <summary>
    /// Clase del tipo de personaje Nigromante
    /// </summary>
    public class Nigromante : Mago
    {
        /// <summary>
        /// Atributo que indica las almas capturadas
        /// </summary>
        public int almasCapturadas;
        
        /// <summary>
        /// Constructor vacio que inicializa los atributos de manera predetermianda
        /// </summary>
        public Nigromante()
        {
            this.almasCapturadas = 0;
            this.hechizo = "Drenar vida";
            Mana = 120;
        }
        
        /// <summary>
        /// Constructor con parámetros para tener atributos propios
        /// </summary>
        /// <param name="almasCapturadas">La cantidad de almas capturadas</param>
        /// <param name="hechizo">El tipo de hechizo que posee</param>
        /// <param name="mana">La cantidad de mana qie tiene</param>
        public Nigromante(int almasCapturadas, string hechizo, int mana)
        {
            this.almasCapturadas = 0;
            this.hechizo = "Drenar vida";
            Mana = 120;
        }

        /// <summary>
        /// Un método que ejecuta una acción dependiendo de las estadisticas del personaje
        /// </summary>
        public void InvocarNoMuerto()
        {
            if (Mana >= 40 && almasCapturadas >= 1)
            {
                Console.WriteLine(nombre + " invoca un no-muerto usando un alma capturada!");
                Mana -= 40;
                almasCapturadas--;
                Console.WriteLine("Almas restantes: " + almasCapturadas);
            }
            else
            {
                Console.WriteLine("No hay suficiente mana o almas para invocar.");
            }
        }

        /// <summary>
        /// Metodo para aunmentar las almas capturadas
        /// </summary>
        public void CapturarAlma()
        {
            almasCapturadas++;
            Console.WriteLine(nombre + " ha capturado un alma. Total: " + almasCapturadas);
        }

        /// <summary>
        /// Metodo para drenar la vida del enemigo
        /// </summary>
        public void DrenarVida()
        {
            if (Mana >= 25)
            {
                Console.WriteLine(nombre + " drena la vida de su enemigo!");
                Mana -= 25;
                vida += 15;
                Console.WriteLine("Vida recuperada. Vida actual: " + vida);
            }
        }
    }
}
