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
    public class JobDetailManager : IJobDetailService

    {
        private readonly IJobDetailDal _jobDetailDal;

        public JobDetailManager(IJobDetailDal jobDetailDal)
        {
            _jobDetailDal = jobDetailDal;
        }
        public void Create(JobDetail entity)
        {
            _jobDetailDal.Create(entity);
        }

        public void Delete(JobDetail entity)
        {
            _jobDetailDal.Delete(entity);
        }

        public List<JobDetail> GetAll(Expression<Func<JobDetail, bool>> filter = null)
        {
            return _jobDetailDal.GetAll(filter);
        }

        public JobDetail GetById(int id)
        {
            return _jobDetailDal.GetById(id);
        }

        public void Update(JobDetail entity)
        {
            _jobDetailDal.Update(entity);
        }
    }



}

