using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YouTubeNetcoreBankAPI.Models
{
    public class GetAccountModel
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public decimal CurrentAccountBalance { get; set; }
        public AccountType AccountType { get; set; } // THis will be an Enum to show if the account to be crtteated iis "Savings" or "Current"
        public string AccountNumberGenerated { get; set; } // we shall generate accountNumber here!

        //we'll also store the hash and salt of the Account Transaction pin
        public DateTime DateCreated { get; set; }
        public DateTime DateLastUpdated { get; set; }
    }
}
