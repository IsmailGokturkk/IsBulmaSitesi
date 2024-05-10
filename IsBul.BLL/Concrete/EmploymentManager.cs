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
    public class EmploymentManager : IEmploymentService
    {

        private readonly IEmploymentDal _employmentDal;
        
        public EmploymentManager(IEmploymentDal employmentDal)
        {
            _employmentDal = employmentDal;
        }
        
        public void Create(Employment entity)
        {
            _employmentDal.Create(entity);
        }

        public void Delete(Employment entity)
        {
           _employmentDal.Delete(entity);
        }

        public List<Employment> GetAll(Expression<Func<Employment, bool>> filter = null)
        {
            return _employmentDal.GetAll(filter);
        }

        public Employment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Employment entity)
        {
            _employmentDal.Update(entity);
        }
    }
}
