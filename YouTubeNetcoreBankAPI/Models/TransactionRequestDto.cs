using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouTubeNetcoreBankAPI.Models
{
    public class TransactionRequestDto
    {
     
        public decimal TransactionAmount { get; set; }
        public string TransactionSourceAccount { get; set; }
        public string TransactionDestinationAccount { get; set; }
        public TranType TransactionType { get; set; } // this is another enum
        public DateTime TransactionDate { get; set; }

    }
}
