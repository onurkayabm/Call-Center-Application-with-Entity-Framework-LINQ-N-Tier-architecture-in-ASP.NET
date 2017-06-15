using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.DAL.Islemler
{
    public interface IGetAll<T> where T:class
    {
        ICollection<T> GetAllEntities();
    }
}
