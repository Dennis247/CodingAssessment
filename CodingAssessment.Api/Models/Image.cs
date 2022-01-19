using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingAssessment.Api.Models
{
    public class Image
    {
        [Key]
        public string Id { get; set; }
        [ForeignKey("CatId")]
        public string CatId { get; set; }
       
        public int Width { get; set; }
        public int Height { get; set; }
        public string Url { get; set; }
    }
}
