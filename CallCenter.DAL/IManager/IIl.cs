using CallCenter.DAL.Islemler;
using CallCenter.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenter.DAL.IManager
{
    public interface IIl:IAdd<Il>,IDelete<Il>,IUpdate<Il>
    {
    }
}
