using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD2T4ValenteMarco
{
    /// <summary>
    /// Clase que representa un círculo, hereda de Figura.
    /// </summary>
    internal class Circulo : Figura
    {
        // Representa el radio del círculo
        public float Radio { get; set; }

        /// <summary>
        /// Constructor de la clase Circulo.
        /// </summary>
        /// <param name="radio">El radio del círculo.</param>
        public Circulo(float radio)
        {
            // Asigna el radio proporcionado al círculo
            this.Radio = radio;
        }

        /// <summary>
        /// Calcula el perímetro del círculo.
        /// </summary>
        /// <returns>El perímetro del círculo.</returns>
        public override float Perimetro()
        {
            // Utiliza la fórmula del perímetro del círculo: 2 * π * radio
            return 2 * (float)Math.PI * Radio;
        }

        /// <summary>
        /// Calcula el área del círculo.
        /// </summary>
        /// <returns>El área del círculo.</returns>
        public override float Area()
        {
            // Utiliza la fórmula del área del círculo: π * radio * radio
            return (float)Math.PI * Radio * Radio;
        }
    }
}
