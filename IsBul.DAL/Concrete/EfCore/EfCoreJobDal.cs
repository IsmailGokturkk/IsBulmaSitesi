using IsBul.DAL.Abstract;
using IsBul.Entitty;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace IsBul.DAL.Concrete.EfCore
{
    public class EfCoreJobDal : EfCoreGenericRepository<Job, DataContext>, IJobDal
    {
       public override List<Job> GetAll (Expression<Func<Job,bool>> filter)
        {
            using (var context = new DataContext())
            {
                var jobs = context.Jobs.Include(i => i.Category).Include(i => i.CompanyDetail).AsQueryable();


                return filter == null
                    ? jobs.ToList()
                    : jobs.Where(filter).ToList();

            } 
        }
    }
}
