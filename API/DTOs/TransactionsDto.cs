using System;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class TransactionsDto
    {
        
        public int Id { get; set; }
        [Required]
        public int CardId { get; set; }
        [Required]
        public int StationFrom { get; set; }
        [Required]
        public int StationTo { get; set; }
        [Required]
        public DateTime Date_In { get; set; }
        [Required]
        public DateTime Date_Out { get; set; }
    }
}