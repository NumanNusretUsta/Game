using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class KampanyaManager : IKampanyaService
    {
        public void KampanyaEkle(Kampanya kampanya)
        {
            Console.WriteLine(kampanya.KampanyaAdi + " kampanyası eklendi");
        }

        public void KampanyaGuncelle(Kampanya kampanya)
        {
            Console.WriteLine(kampanya.KampanyaAdi + " kampanyası güncellendi");
        }

        public void KampanyaSil(Kampanya kampanya)
        {
            Console.WriteLine(kampanya.KampanyaAdi + " kampanyası silindi");
        }
    }
}
