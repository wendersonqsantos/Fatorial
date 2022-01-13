using System;

namespace Fatorial
{
    class Program
    {
        public static void imprimir (int numero, int fatorial)
        {
            Console.WriteLine("Fatorial de: "+numero+" é: "+fatorial);
        }
        public static int fatorial(int numero)
        {
            if (numero == 1)
            {
                return 1;
            }
            else return numero * fatorial(numero - 1);

        }
        static void Main(string[] args)
        {
            int numero,fatorial_;
            numero = fatorial_ = 0;
            Console.WriteLine("Informe um número para ser calculado o seu fatorial: ");
            numero = int.Parse(Console.ReadLine());
           fatorial_= fatorial(numero);
            imprimir(numero, fatorial_);
            Console.ReadKey();
        }
    }
}
