using IsBul.BLL.Abstract;
using IsBul.DAL.Abstract;
using IsBul.Entitty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IsBul.BLL.Concrete
{
    public class JobManager : IJobService
    {
        private readonly IJobDal _jobDal;

        public JobManager(IJobDal jobDal)
        {
            _jobDal = jobDal;
        }
        public void Create(Job entity)
        {
            _jobDal.Create(entity);
        }

        public void Delete(Job entity)
        {
            _jobDal.Delete(entity);
        }

        public List<Job> GetAll(Expression<Func<Job, bool>> filter = null)
        {
            return _jobDal.GetAll(filter);
        }

        public Job GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Job entity)
        {
            _jobDal.Update(entity);
        }
    }
}
