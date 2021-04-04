using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YouTubeNetcoreBankAPI.Models;

namespace YouTubeNetcoreBankAPI.DAL
{
    public class YouBankingDbContext : DbContext
    {
        public YouBankingDbContext(DbContextOptions<YouBankingDbContext> options) : base(options)
        {

        }

        //dbset
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
