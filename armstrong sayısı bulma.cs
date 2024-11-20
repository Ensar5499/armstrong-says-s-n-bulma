using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {


        
           
            {
                Console.WriteLine("Bir sayı giriniz:");
                int n = int.Parse(Console.ReadLine()); 

                int toplam = 0;
                int orijinalSayi = n;  
                
                while (n > 0)
                {
                    int basamak = n % 10;  
                    toplam += basamak * basamak * basamak;  
                    n /= 10; 
                }

              
                if (toplam == orijinalSayi)
                {
                    Console.WriteLine("{0} bir Armstrong sayısıdır.", orijinalSayi);
                }
                else
                {
                    Console.WriteLine("{0} bir Armstrong sayısı değildir.", orijinalSayi);
                }

                Console.ReadLine();  
            }
        }
    }









}
    

