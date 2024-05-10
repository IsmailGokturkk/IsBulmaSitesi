using IsBul.Entitty;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IsBulma.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        [DisplayName("Kategori Adı")]
        public string Name { get; set; }
     
        [Required]
        [DisplayName("Durum")]
        public bool Status { get; set; }

        [StringLength(100)]
        [Required]
        [DisplayName("İkon")]
        public string Icon { get; set; }

        public List<Job> jobs { get; set; }


    }
}
