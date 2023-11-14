using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD2T4ValenteMarco
{
    /// <summary>
    /// Clase base abstracta que representa una figura geométrica.
    /// </summary>
    internal class Figura
    {
        public float BaseF { get; set; }
        public float AlturaF { get; set; }

        /// <summary>
        /// Método virtual que calcula el perímetro de la figura.
        /// </summary>
        /// <returns>El perímetro de la figura.</returns>
        public virtual float Perimetro()
        {
            // Devuelve un -1 como marcador de error.
            return -1;
        }

        /// <summary>
        /// Método virtual que calcula el área de la figura.
        /// </summary>
        /// <returns>El área de la figura.</returns>
        public virtual float Area()
        {
            // Devuelve un -1 como marcador de error.
            return -1;
        }
    }
}
