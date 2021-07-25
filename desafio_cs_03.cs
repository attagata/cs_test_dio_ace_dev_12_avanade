using System;

namespace cs_test
{
    class DioAvanadeAcc12sDesafio03
    {
        public static void Program(){
            var maxEntries = long.Parse(Console.ReadLine()); //Get QTY
            long[] arrEntries = new long[maxEntries];

            for (long entry = 0; entry <= maxEntries-1; entry++){
                arrEntries[entry] =  long.Parse(Console.ReadLine());
            }
           
            foreach (int item in arrEntries){
                 if (item >= 0 && item <= 60){
                    Console.Write("Fib(");
                    Console.Write(item); 
                    Console.Write(") = {"); 
                    Console.Write(GetNthFibonacci_Ite(item + 1)); 
                    Console.WriteLine("}"); 
                    }
                 else
                 {
                     Console.WriteLine("Valor [" + item + "] é inválido.");
                 
                 }
                
            }
        }
        public static long GetNthFibonacci_Ite(long n){  
            long number = n - 1; //Need to decrement by 1 since we are starting from 0  
            long[] Fib = new long[number + 1];  

            if (number<=0){
                return 0;
            }
            else if(number==1){
                return 1;
            }

            Fib[0]= 0;
            Fib[1]= 1;  
            for (int i = 2; i <= number;i++)  
            {  
                Fib[i] = Fib[i - 2] + Fib[i - 1]; 
            }  
            
            return Fib[number];  
          
        }
    }
}
