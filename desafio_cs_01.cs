using System;

namespace cs_test
{
    public class DioAvanadeAcc12sDesafio01
    {
        public static void Program()
        {
            string[] line1 = Console.ReadLine().Split(" ");
            string[] line2 = Console.ReadLine().Split(" ");
            
            int finalExpediente = int.Parse(line1[0]);
            
            int presente1 = int.Parse(line2[0]);
            int presente2 = int.Parse(line2[1]);
            
            //continue a solucao
            int totalNecessario =  presente1 + presente2;
            
            if (totalNecessario > finalExpediente)
            {
            Console.WriteLine("Deixa para amanha!");
            }
            else
            {
            Console.WriteLine("Farei hoje!");
            }
        
        }
    }
}