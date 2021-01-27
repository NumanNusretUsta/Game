using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public interface IOyuncuService
    {
        void Kaydet(Oyuncu oyuncu);
        void Guncelle(Oyuncu oyuncu);
        void Sil(Oyuncu oyuncu);

    }
}
