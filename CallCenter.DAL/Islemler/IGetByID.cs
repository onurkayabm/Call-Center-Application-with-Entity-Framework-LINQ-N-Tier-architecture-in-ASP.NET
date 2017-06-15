using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.DAL.Islemler
{
    public interface IGetByID<T,ID> where T:class where ID:struct
    {
        T GetByID(ID id);
    }
}
