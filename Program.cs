using System;

namespace Calculo_media
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1,nota2,nota3;
            double media;

            Console.WriteLine("Digite a primeira nota:");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota:");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota:");
            nota3 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 2;

            if (media >= 7)
            {
                Console.WriteLine("Aluno Aprovado");

            } else
            {
                Console.WriteLine("Aluno Reprovado");
            }
            Console.ReadKey(); 

             
        }
    }
}
