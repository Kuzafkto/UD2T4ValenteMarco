using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD2T4ValenteMarco
{
    /// <summary>
    /// Clase que representa un rectángulo.
    /// </summary>
    internal class Rectangulo : Figura
    {
        // Lados del rectángulo
        public float Lado1 { get; set; }
        public float Lado2 { get; set; }

        /// <summary>
        /// Constructor de la clase Rectangulo.
        /// </summary>
        /// <param name="lado1">Longitud del primer lado del rectángulo.</param>
        /// <param name="lado2">Longitud del segundo lado del rectángulo.</param>
        public Rectangulo(float lado1, float lado2)
        {
            // Asigna las longitudes de los lados proporcionados al rectángulo
            this.Lado1 = lado1;
            this.Lado2 = lado2;
        }

        /// <summary>
        /// Calcula el perímetro del rectángulo.
        /// </summary>
        /// <returns>El perímetro del rectángulo.</returns>
        public override float Perimetro()
        {
            // Utiliza la fórmula del perímetro del rectángulo: 2 * (lado1 + lado2)
            return 2 * (Lado1 + Lado2);
        }

        /// <summary>
        /// Calcula el área del rectángulo.
        /// </summary>
        /// <returns>El área del rectángulo.</returns>
        public override float Area()
        {
            // Utiliza la fórmula del área del rectángulo: lado1 * lado2
            return Lado1 * Lado2;
        }
    }
}
