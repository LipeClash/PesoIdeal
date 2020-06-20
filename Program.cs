using System;

namespace PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
           Double Altura;
        
           Console.WriteLine("digite sua altura e o seu sexo ('M' para masculino, 'F' para feminino). Calcule e exiba seu peso ideal.\n");
           Console.Write("Digite sua altura em m..........: ");
           Altura = Convert.ToDouble(Console.ReadLine());
           Console.Write("Sexo [M]asculino / [F]eminino...: ");
           string Sexo = Console.ReadLine();

           int resultadoPeso = Convert.ToInt32(Altura * 72.7 - 58.0);
           Console.Write($"Seu peso ideal é {resultadoPeso:C2} kg.\n");



        }

    }
}
