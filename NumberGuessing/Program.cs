using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessing
{

    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            Random random = new Random();

            int randomSayı = random.Next(1, 11);
            
            Console.WriteLine("Sayı Falcısına Hoşgeldiniz! :)");
            Console.WriteLine("Aklımdan 1-10 arasında bir sayı tutacağım");
            Console.WriteLine("Eğer doğru bilirsen, kazanırsın");



            while (!isCorrectGuess)
            {
                Console.WriteLine("Lütfen tahmininizi giriniz.");
                int tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin > randomSayı)
                {
                    Console.WriteLine("Tahmininiz yüksek, daha düşük sayılar deneyin!");
                }
                else if (tahmin < randomSayı) 
                {
                    Console.WriteLine("Tahmininiz düşük, daha yüksek sayılar deneyin!");
                }
                else
                {
                    Console.WriteLine("Doğru tahmin!");
                    isCorrectGuess = true;
                }
            }

            Console.WriteLine("Oyunu kazandınız, tebrikler!");

            

            Console.ReadKey();




        }
    }
}