using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.DAL.Islemler
{
    public interface IUpdate<T>
    {
        void UpdateEntity(T item);
    }
}
