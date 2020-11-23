using System;

namespace API.Entities
{
    public class AppTransactions
    {
        
        public int Id { get; set; }
        public int CardId { get; set; }
        public int StationFrom { get; set; }
        public int StationTo { get; set; }
        public DateTime Date_In { get; set; }
        public DateTime Date_Out { get; set; }
    }
}