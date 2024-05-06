using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ekrandan bir string bir de sayı alan (aralarında virgül ile), ilgili string ifade içerisinden
//verilen indexteki karakteri çıkartıp ekrana yazdıran console uygulasını yazınız.

//Örnek: Input: Algoritma,3 Algoritma,5 Algoritma,22 Algoritma,0
namespace Algoritma
{
    internal class Program
    {
        static string RemoveCharacterAtIndex(string text, int index)
        {
            if (index < 0 || index >= text.Length)
            {
                Console.WriteLine("Hatalı giriş! Verilen indeks metin uzunluğu içinde olmalıdır.");
                return text;
            }

            return text.Remove(index, 1);
            Console.ReadKey();
        }
    
    static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir metin ve bir tamsayı girin (aralarında virgülle):");
            string kelime = Console.ReadLine();

            string[] ayir = kelime.Split(',');
            if (ayir.Length != 2)
            { 
                Console.WriteLine("Hatalı giriş! Metin ve sayıyı birbirinden virgülle ayırarak giriniz.");
                return;
            }

            string text = ayir[0].Trim();
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("Hatalı giriş! Metin boş olamaz.");
                return;
            }
            if (!int.TryParse(ayir[1], out int index))
            {
                Console.WriteLine("Hatalı giriş! İkinci değer tamsayı olmalıdır.");
                return;
            }

            string result = RemoveCharacterAtIndex(text, index);

            Console.WriteLine($"Metindeki {index}. indeksteki karakter çıkarıldıktan sonra:\n{result}");
            Console.ReadKey();
        }




    }
}

