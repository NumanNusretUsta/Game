using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    interface IKampanyaService
    {
        void KampanyaEkle(Kampanya kampanya);
        void KampanyaSil(Kampanya kampanya);
        void KampanyaGuncelle(Kampanya kampanya);

    }
}
