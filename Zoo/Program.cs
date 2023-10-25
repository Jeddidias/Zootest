using System;

namespace Zoo
{
    class Program
    {/// <summary>
    /// Jorge Esteban Dawson
    /// 140
    /// programa problema 3
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos animales desea ingresar");
            int cuantos = Convert.ToInt32(Console.In.ReadLine());
            //Lee la cantidad de animales que va a recibir el sistema
            Console.WriteLine("se ingresaran {0} animales ", cuantos);
            Console.WriteLine("Por favor ingrese animal y pais de origen");
            string[] animales = new string[cuantos];
            for (int i = 0; i<animales.Length; i++)
            {
                animales[i] = Console.ReadLine();
            }//Para el registro de los animales según el numero ingresado
            Console.WriteLine("Quedaron resgistrados los siguentes animales:");
            for (int i = 0; i < animales.Length; i++)
            {
                Console.WriteLine(animales[i] + " ");
            }//Imprime la información ingresada en consola
        }
    }
}
