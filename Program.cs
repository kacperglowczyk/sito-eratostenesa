using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę n, do której chcesz znaleźć wszystkie liczby pierwsze:");
        int n = int.Parse(Console.ReadLine());
        
        // Wywołanie metody Sito Eratostenesa
        bool[] primes = SieveOfEratosthenes(n);

        Console.WriteLine($"Liczby pierwsze mniejsze lub równe {n}:");

        for (int i = 2; i <= n; i++)
        {
            if (primes[i])
            {
                Console.Write(i + " ");
            }
        }
    }

    static bool[] SieveOfEratosthenes(int n)
    {
        bool[] isPrime = new bool[n + 1];

        // Inicjalizacja: zakładamy, że wszystkie liczby są pierwsze
        for (int i = 2; i <= n; i++)
        {
            isPrime[i] = true;
        }

        // Implementacja algorytmu Sito Eratostenesa
        for (int p = 2; p * p <= n; p++)
        {
            if (isPrime[p])
            {
                for (int i = p * p; i <= n; i += p)
                {
                    isPrime[i] = false;
                }
            }
        }

        return isPrime;
    }
}