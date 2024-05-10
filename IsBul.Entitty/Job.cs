using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBul.Entitty
{
    public class Job
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        public decimal Salary { get; set; }
        [StringLength(100)]
        public string City { get; set; }
        public string Location { get; set; }
        public string CoverImage { get; set; }
        [StringLength(100)]
        public string JobNature { get; set; }       
        [StringLength(1000)]
        public string JobDescription { get; set; }       
        [StringLength(1000)]
        public string Responsibility { get; set; }       
        [StringLength(1000)]
        public string Qualifications { get; set; }
        public string DateLine { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
