using System;

namespace ejercicio_1_numeros_primos_ajsinoga
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = usage();

            switch(opcion)
            {
                case "1":
                    Console.WriteLine("Suma 50 primeros números primos = " + sumOf50FirstPrimeNumbers().ToString());
                    break;
                case "2":
                    Console.WriteLine("Suma de los primos que hay en los 50 primeros números = " + sumOfPrimeNumbersIn50FirstNumbers().ToString());
                    break;
                default:
                    break;
            }
        }

        static string usage()
        {
            string opcion = "";

            do
            {
                Console.WriteLine("\nElige 1 para la suma de los 50 primeros números primos.\nElige 2 para la suma de los primos que hay en los 50 primeros números...");
                opcion = Console.ReadLine();
            }
            while (!opcion.Equals("1") && !opcion.Equals("2"));                    
                       
            return opcion;            
        }

        static int sumOf50FirstPrimeNumbers()
        {
            int number = 1;
            int totalPrimeNumbers = 0;
            int sumTotal = 0;
            
            while (totalPrimeNumbers <= 50)
            {
                if (isPrime(number))
                {
                    sumTotal = sumTotal + number;
                    totalPrimeNumbers ++;
                }
                number ++;
            }

            return sumTotal;
        }   /* resultado 5350 */

        static int sumOfPrimeNumbersIn50FirstNumbers()
        {    
            int sumTotal = 0;
            
            for (int number = 1; number <= 50; number++)
            {
                if (isPrime(number))
                {
                    sumTotal = sumTotal + number;
                }
            }

            return sumTotal;    
        }  /* resultado 328 */

        static bool isPrime(int number)
        {   
            if (number < 2)
            {
                return false;
            }
            /* Un número es primo si es divisible únicamente por 1 y por si mismo */
            /* pero cuando superamos la mitad ya no tiene divisores de resto 0 */
            for (int divisor = 2; divisor <= number / 2; divisor++)
            { 
                if (number % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
