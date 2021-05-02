using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_Diego_Boscaglia
{
    class Program
    {
        static void Main(string[] args)
        {

            string nombre; string email; float sueldo; string sexo; float peso; float altura;

            Console.WriteLine("Ingrese Nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Email:");
            email = Console.ReadLine();
            Console.WriteLine("Ingrese Sexo:");
            sexo = Console.ReadLine();
            Console.WriteLine("Ingrese Sueldo:");
            sueldo = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Peso:");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Altura:");
            altura = float.Parse(Console.ReadLine());


            Persona miPersona = new Persona(nombre, email, sueldo, sexo, peso, altura) ;
            

            Console.WriteLine(nombre);
            Console.WriteLine(email);
            Console.WriteLine(sueldo);
            Console.WriteLine(sexo);
            Console.WriteLine(peso);
            Console.WriteLine(altura);
            Console.WriteLine("Los datos ingresados son");
            Console.WriteLine(miPersona.GetNombre());
            Console.WriteLine(miPersona.GetEmail());
            Console.WriteLine(miPersona.GetSueldo());
            Console.WriteLine(miPersona.GetSexo());
            Console.WriteLine(miPersona.GetPeso());
            Console.WriteLine(miPersona.GetAltura());
            Console.ReadKey();






        }

    }
}
