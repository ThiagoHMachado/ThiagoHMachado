using System;

namespace Teste_Global_Tecnologia
{
    class Program
    {
        /*
        2520 é o menor número que pode ser dividido por cada um dos números de 1 a 10, sem qualquer resto.
        O que é o menor número positivo que é divisível por todos os números de 1 a 20?
        */

        static void Main(string[] args)
        {            
            int iNumero = 1, i=20;

            //i = Convert.ToInt32(Console.ReadLine());

            while (iNumero % i != 0)
            {
                iNumero++;
                i--;
                Console.WriteLine(iNumero.ToString(), i);                
            }
            Console.Read();
        }
    }
}
