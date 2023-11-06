﻿using FiftyShadesOfErrorList_DATA.Entity;
using System.Linq.Expressions;

namespace FiftyShadesOfErrorList_SERVICE.AlinanBesinService
{
    public interface IAlinanBesinSERVICE
    {
        void Ekle(AlinanBesin alinanBesin);
        void Guncelle(AlinanBesin alinanBesin);
        void Sil(AlinanBesin alinanBesin);
        AlinanBesin IdyeGoreGetir(int id);
        List<AlinanBesin> TumunuGetir();
        List<AlinanBesin> KosulaGoreGetir(Expression<Func<AlinanBesin, bool>> expression);
    }
}
