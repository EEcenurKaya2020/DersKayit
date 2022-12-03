using System;
using EntityLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLOgr
    {
        public static int OgrEkleBLL(EntityOgr p)
        {
            if(p.Ad != null && p.Soyad != null && p.No != null && p.Sifre != null && p.Foto != null)
            {
                return DALOgr.OgrEkle(p);
            }
            return -1;
        } 
    }
}
