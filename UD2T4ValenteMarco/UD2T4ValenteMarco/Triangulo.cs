using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD2T4ValenteMarco
{
    /// <summary>
    /// Clase que representa un triángulo, hereda de Figura.
    /// </summary>
    internal class Triangulo : Figura
    {
        // Lados del triángulo
        private float Lado1 { get; set; }
        private float Lado2 { get; set; }

        /// <summary>
        /// Constructor de la clase Triangulo.
        /// </summary>
        /// <param name="lado1">Longitud del primer lado del triángulo.</param>
        /// <param name="lado2">Longitud del segundo lado del triángulo.</param>
        public Triangulo(float lado1, float lado2)
        {
            // Asigna las longitudes de los lados proporcionados al triángulo
            this.Lado1 = lado1;
            this.Lado2 = lado2;
        }

        /// <summary>
        /// Calcula el perímetro del triángulo.
        /// </summary>
        /// <returns>El perímetro del triángulo.</returns>
        public override float Perimetro()
        {
            // Calcula la hipotenusa utilizando el teorema de Pitágoras
            float hipotenusa = (float)Math.Sqrt(Math.Pow(Lado1, 2) + Math.Pow(Lado2, 2));

            // Suma las longitudes de los tres lados
            return Lado1 + Lado2 + hipotenusa;
        }

        /// <summary>
        /// Calcula el área del triángulo.
        /// </summary>
        /// <returns>El área del triángulo.</returns>
        public override float Area()
        {
            // Utiliza la fórmula del área del triángulo rectángulo: 0.5 * lado1 * lado2
            return 0.5f * Lado1 * Lado2;
        }
    }
}
