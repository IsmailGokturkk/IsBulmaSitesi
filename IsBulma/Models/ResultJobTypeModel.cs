using IsBul.Entitty;

namespace IsBulma.Models
{
    public class ResultJobTypeModel //category
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        public string Icon { get; set; }

        public List<Job> Jobs { get; set; }
    }
}
