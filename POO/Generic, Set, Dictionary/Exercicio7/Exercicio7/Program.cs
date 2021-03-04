using System;
using System.Collections.Generic;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "999999999";
            cookies["phone"] = "111111111";

            Console.WriteLine(cookies["email"]);
            cookies.Remove("email");

            Console.WriteLine($"Phone number: {cookies["phone"]}");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine($"Email: {cookies["email"]}");
            }
            else
            {
                Console.WriteLine("There is not email key");
            }

            foreach(KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
