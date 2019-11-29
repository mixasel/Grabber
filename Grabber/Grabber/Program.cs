using System;
using System.IO;
using System.Net;

namespace Grabber
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();

            using (Stream stream = client.OpenRead("https://store.steampowered.com/%22"))
            {
                using (StreamWriter sw = new StreamWriter("grabber.txt"))
                {
                    using (StreamReader sr = new StreamReader(stream))
                    {
                        string line = "";
                        while ((line = sr.ReadLine()) != null)
                        {
                            sw.WriteLine(line);
                        }
                    }
                }
            }
            Console.WriteLine("Запись завершена");
            Console.ReadLine();
        }
    }
}
