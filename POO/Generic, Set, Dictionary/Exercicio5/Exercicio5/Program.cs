﻿using System;
using System.IO;
using Exercicio5.Entities;
using System.Collections.Generic;

/*Um site de internet registra um log de acessos dos usuários. Um
registro de log consiste no nome de usuário e o instante em que o
usuário acessou o site no padrão ISO 8601, separados por espaço,
conforme exemplo. Fazer um programa que leia o log de acessos a
partir de um arquivo, e daí informe quantos usuários distintos
acessaram o site.
 */

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecords> set = new HashSet<LogRecords>();
            Console.WriteLine("Type the file full path: ");
            string path = Console.ReadLine();

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecords { Username = name , Instant = instant});
                        Console.WriteLine(line);
                    }
                    Console.WriteLine($"Total user: {set.Count}");
                }
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
