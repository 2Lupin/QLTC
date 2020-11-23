using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class QLTCDto
    {
        public int Id { get; set; }
        [Required]
        public string CardType { get; set; }
        [Required]
        public int Validity { get; set; }
        public double InitialLoad { get; set; }
    }
}