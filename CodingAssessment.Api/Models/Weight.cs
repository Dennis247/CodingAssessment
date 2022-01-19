using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingAssessment.Api.Models
{
    public class Weight
    {
        [Key]
        public string Id { get; set; }
        [ForeignKey("CatId")]
      
        public virtual Cat Cat { get; set; }
        public string Imperial { get; set; }
        public string Metric { get; set; }
    }
}
