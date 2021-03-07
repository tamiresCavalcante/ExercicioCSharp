using System;
using System.Collections.Generic;

/*Em um portal de cursos online, cada usuário possui um código único, representado por
um número inteiro.
Cada instrutor do portal pode ter vários cursos, sendo que um mesmo aluno pode se
matricular em quantos cursos quiser. Assim, o número total de alunos de um instrutor não
é simplesmente a soma dos alunos de todos os cursos que ele possui, pois pode haver
alunos repetidos em mais de um curso.
O instrutor Alex possui três cursos A, B e C, e deseja saber seu número total de alunos.
Seu programa deve ler os alunos dos cursos A, B e C do instrutor Alex, depois mostrar a
quantidade total e alunos dele, conforme exemplo.
 */

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.WriteLine("Type the quantity of students for course A: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int code = int.Parse(Console.ReadLine());
                courseA.Add(code);
            }

            Console.WriteLine("Type the quantity of students for course B: ");
            n = int.Parse(Console.ReadLine());
            for(int i=0; i< n; i++)
            {
                int code = int.Parse(Console.ReadLine());
                courseB.Add(code);
            }

            Console.WriteLine("Type the quantity of students for course C: ");
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i < n; i++)
            {
                int code = int.Parse(Console.ReadLine());
                courseC.Add(code);
            }

            HashSet<int> all = new HashSet<int>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);
            Console.WriteLine($"Total of students: {all.Count}");
        }
    }
}
