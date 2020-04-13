using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Persona
    {
        public string Identificacon { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public decimal Pulsacion
        {
            get
            {
                if (Sexo == "f" || Sexo == "F")
                {
                    return (220 - Edad) / 10;
                }
                else
                {
                    return (210 - Edad) / 10;
                }
            }
            set { }
        }
        public override string ToString()
        {
            return $"Identificacion: {Identificacon} Nombre: {Nombre} Edad: {Edad} Sexo: {Sexo} Pulsacion/10seg: {Pulsacion}";
        }
    }
}
