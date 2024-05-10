using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBul.Entitty
{
    public class Client
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
