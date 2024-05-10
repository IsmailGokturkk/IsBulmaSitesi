using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBul.Entitty
{
    public class CompanyDetail
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Title { get; set; }
        [StringLength(2000)]
        public string  CompanyDescription { get; set; }
        public string Mail {  get; set; }
        [StringLength(10)]
        public string PhoneNumber { get; set; }


        public List<CompanyDetail> CompanyDetails { get;}
      
    }
}
