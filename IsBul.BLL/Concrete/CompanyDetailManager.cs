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
    public class CompanyDetailManager : ICompanyDetailService
    {

        private readonly ICompanyDetailDal _companyDetailDal;

        public CompanyDetailManager(ICompanyDetailDal companyDetailDal)
        {
            _companyDetailDal = companyDetailDal;
        }
        public void Create(CompanyDetail entity)
        {
            _companyDetailDal.Create(entity);
        }

        public void Delete(CompanyDetail entity)
        {
           _companyDetailDal.Delete(entity);
        }

        public List<CompanyDetail> GetAll(Expression<Func<CompanyDetail, bool>> filter = null)
        {
            return _companyDetailDal.GetAll(filter);
        }

        public CompanyDetail GetById(int id)
        {
            return _companyDetailDal.GetById(id);
        }

        public void Update(CompanyDetail entity)
        {
            _companyDetailDal.Update(entity);
        }
    }
}
