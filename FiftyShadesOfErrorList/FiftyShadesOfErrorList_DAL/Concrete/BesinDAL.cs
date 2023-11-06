using FiftyShadesOfErrorList_DAL.Context;
using FiftyShadesOfErrorList_DATA.Entity;

namespace FiftyShadesOfErrorList_DAL.Concrete
{
    public class BesinDAL : BaseDAL<Besin>
    {
        public void Sil(Besin besin)
        {
            DiyetAppContext db = new DiyetAppContext();
            db.Remove(besin);
            db.SaveChanges();
        }
    }
}
