using System;

/*Escreva que repita a leitura de uma senha até que ela esteja invalida. Para cada leitura de senha incorreta informada,
 escrever a mensagem senha invalida. Quando a senha for informada corretamente deve ser impressa a mensagem Acesso permitido
e o algoritmo encerrado. Considere que a senha correta é o valor 2002*/

namespace exercicioproposto3_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter with the password: ");
            int password = int.Parse(Console.ReadLine());

            while(password != 2002)
            {
                Console.WriteLine(" Access Denied. \n Enter with the password again");
                password = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Access Allowed");

        }
    }
}
