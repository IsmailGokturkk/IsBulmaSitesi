using IsBul.DAL.Abstract;
using IsBul.Entitty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBul.DAL.Concrete.EfCore
{
    public class EfCoreClientDal:EfCoreGenericRepository<Client,DataContext>,IClientDal
    {

    }
}
