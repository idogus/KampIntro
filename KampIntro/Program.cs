using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Variables();
        }
        public static void Variables()
        {
            // Tyep Safety - Tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmısMi = GetEnterControl();

            if (sistemeGirisYapmısMi)
            {
                Console.WriteLine("Kullanıcı ayarları buttonu");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Giriş yap buttonu");
                Console.WriteLine();
            }

            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(ogrenciSayisi);
            Console.WriteLine(faizOrani);
            Console.WriteLine(sistemeGirisYapmısMi);
        }

        private static bool GetEnterControl()
        {
            return true;
        }
    }
}
