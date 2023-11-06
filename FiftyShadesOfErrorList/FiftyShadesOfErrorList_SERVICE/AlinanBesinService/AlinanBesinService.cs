﻿using FiftyShadesOfErrorList_DAL.Concrete;
using FiftyShadesOfErrorList_DATA.Entity;
using System.Linq.Expressions;

namespace FiftyShadesOfErrorList_SERVICE.AlinanBesinService
{
    public class AlinanBesinService : IAlinanBesinSERVICE
    {
        public void Ekle(AlinanBesin alinanBesin)
        {
            BaseDAL<AlinanBesin> baseDAL = new BaseDAL<AlinanBesin>();
            baseDAL.Ekle(alinanBesin);
        }

        public void Guncelle(AlinanBesin alinanBesin)
        {
            BaseDAL<AlinanBesin> baseDAL = new BaseDAL<AlinanBesin>();
            baseDAL.Guncelle(alinanBesin);
        }

        public AlinanBesin IdyeGoreGetir(int id)
        {
            BaseDAL<AlinanBesin> baseDAL = new BaseDAL<AlinanBesin>();
            return baseDAL.IdyeGoreGetir(id);
        }


        public List<AlinanBesin> KosulaGoreGetir(Expression<Func<AlinanBesin, bool>> expression)

        {

            BaseDAL<AlinanBesin> baseDAL = new BaseDAL<AlinanBesin>();
            return baseDAL.KosulaGoreGetir(expression);

        }

        public void Sil(AlinanBesin besin)
        {
            AlinanBesinDAL alinanBesinDal=new AlinanBesinDAL();
            alinanBesinDal.Sil(besin);
        }

        public List<AlinanBesin> TumunuGetir()
        {
            BaseDAL<AlinanBesin> baseDAL = new BaseDAL<AlinanBesin>();
            return baseDAL.TumunuGetir();
        }

    }
}
