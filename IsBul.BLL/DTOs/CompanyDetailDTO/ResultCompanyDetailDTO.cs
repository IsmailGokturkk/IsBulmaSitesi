using IsBul.Entitty;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBul.BLL.DTOs.CompanyDetailDTO
{
    public class ResultCompanyDetailDTO
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Title { get; set; }
        [StringLength(2000)]
        public string CompanyDescription { get; set; }
        public string Mail { get; set; }
        [StringLength(10)]
        public string PhoneNumber { get; set; }

        public List<Job> Jobs { get; set; }
    }
}
