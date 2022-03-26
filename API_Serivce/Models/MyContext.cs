using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Serivce.Models
{
    internal class MyContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseMySQL("server=mysqlstudenti.litv.sssvt.cz;database=bucina_db1;user=bucinaread;password=clashroyale1;SslMode=none");
        }
    }
}
