using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class OyuncuManager : IOyuncuService
    {
        public void Guncelle(Oyuncu oyuncu)
        {
            Console.WriteLine("Oyuncu " + oyuncu.NickName + " güncellendi");
        }

        public void Kaydet(Oyuncu oyuncu)
        {
            static void TcKontrolEt(Oyuncu oyuncu)
            {
                if (oyuncu.NationalId.Length == 11)
                {
                    Console.WriteLine("Oyuncu " + oyuncu.NickName + " kaydedildi");
                }
                else
                {
                    Console.WriteLine("Oyuncu TC no eksik");
                }
            }
            
        }

        public void Sil(Oyuncu oyuncu)
        {
            Console.WriteLine("Oyuncu " + oyuncu.NickName + " silindi");
        }
    }
}
