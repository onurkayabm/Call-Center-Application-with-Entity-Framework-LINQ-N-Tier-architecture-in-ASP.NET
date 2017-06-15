using CallCenter.DAL.Islemler;
using CallCenter.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.DAL.IManager
{
    public interface IMusteri:IAdd<Musteri>,IDelete<Musteri>,IUpdate<Musteri>,IGetByID<Musteri,int>,IGetAll<Musteri>
    {
    }
}
