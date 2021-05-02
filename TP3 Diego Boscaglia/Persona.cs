using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Diego_Boscaglia
{
    class Persona
    {
        private string nombre;
        private string email;
        private float sueldo;
        private string sexo;
        private float peso;
        private float altura;

        public Persona(string nombre, string email, float sueldo, string sexo, float peso, float altura)
        {
            this.nombre = nombre;
            this.email = email;
            this.sueldo = sueldo;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
            CrearEmail();

        }
         public string GetNombre()

        {
            return nombre;
        }

        public string GetEmail()

        {
            return email;

        }

        public float GetSueldo()

        {
            return sueldo;

        }

        public string GetSexo()

        {
            return sexo;

        }


        public float GetPeso()

        {
            return peso;

        }

        public float GetAltura()

        {
            return altura;

        }

        private void CrearEmail()

        {
            email = nombre + "@superempresa.com";
        }

    }
}





