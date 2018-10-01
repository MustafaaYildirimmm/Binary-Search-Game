using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberSearchGame_Consol_
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int randomNumber , guessNumber, hak = 10;
            char c;
            
            try
            {
                do
                {
                    Console.Clear();
                    randomNumber = rnd.Next(0, 51);
                    Console.WriteLine("bir sayi tahmin ediniz.");
                    do
                    {
                        guessNumber = Convert.ToInt32(Console.ReadLine());
                        hak--;
                        if (hak == 0)
                        {
                            Console.WriteLine("hakkiniz bitmiştir");
                            break;
                        }
                        else if (guessNumber > randomNumber)
                        {
                            Console.WriteLine("daha kücük bir sayi giriniz");
                        }
                        else if (guessNumber < randomNumber)
                        {
                            Console.WriteLine("daha buyuk bir sayi giriniz");
                        }
                        else
                        {
                            Console.WriteLine("tebrikler {0}. hakkinizda buldunuz", (10 - hak));
                            break;
                        }


                    } while (true);
                    Console.WriteLine("tekrar oynamak istermisiniz e/h");
                    c = Convert.ToChar(Console.ReadLine());
                    if (c == 'e')
                    {
                        hak = 10;
                    }
                    else if (c == 'h')
                        Environment.Exit(1);
                } while (true);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
