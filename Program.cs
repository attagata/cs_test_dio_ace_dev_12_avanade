using System;

namespace cs_test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio #1 Digite TEMPO ex: '100' e TEMPO PARA CADA ITEM ex: '50 50'");

            DioAvanadeAcc12sDesafio01.Program();
            
            Console.WriteLine("Desafio #1 Concluido");

            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("");

            Console.WriteLine("Desafio #2 - Informe 4 nrs separando com ENTERs (a*b - c*d) ");

            DioAvanadeAcc12sDesafio02.Program();
            
            Console.WriteLine("Desafio #2 Concluido");

            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("");
            Console.WriteLine("Desafio #3 - fibonacci ");
            Console.WriteLine("Primeiro informe a quantidade de itens para calculo e ENTER");
            Console.WriteLine("Em seguida, digite um nr [0~60] e ENTER para receber o fibonacci calculado:");

            DioAvanadeAcc12sDesafio03.Program();
            
            Console.WriteLine("Desafio #3 Concluido");

            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("");
        }
    }
}
