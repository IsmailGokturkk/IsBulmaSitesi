using IsBul.Entitty;
using System.ComponentModel.DataAnnotations;

namespace IsBulma.Models
{
    public class ResultJobDetailModel
    { 

        [StringLength(200)]

    public int Id { get; set; }
    public DateTime PublichedDate { get; set; }
    public DateTime DateLine { get; set; }
    [StringLength(20)]
    public string Vacancy { get; set; }
    public string JobNature { get; set; }
    [StringLength(1000)]
    public decimal Salary { get; set; }
    public string Location { get; set; }
    public int JobId { get; set; }
    public Job Job { get; set; }

    
}
}
