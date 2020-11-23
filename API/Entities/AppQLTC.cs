using System.Collections.Generic;

namespace API.Entities
{
    public class AppQLTC
    {
        public int Id { get; set; }
        public string CardType { get; set; }
        public int Validity { get; set; }
        public double InitialLoad { get; set; }
        public ICollection<AppTransactions> Transactions { get; set; }

        public double GetNewLoad(){
            return 99;
        }
    }
}