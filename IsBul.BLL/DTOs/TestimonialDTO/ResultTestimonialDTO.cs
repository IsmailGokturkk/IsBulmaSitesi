using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBul.BLL.DTOs.TestimonialDTO
{
    public class ResultTestimonialDTO
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Profession { get; set; }
        [StringLength(1100)]
        public string Comment { get; set; }
        public string ImageUrl { get; set; }

    }
}
