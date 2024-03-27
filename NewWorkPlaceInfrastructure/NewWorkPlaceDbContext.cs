using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWorkPlaceInfrastructure
{
    public class NewWorkPlaceDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-JD2U15O\\\\MSSQL1;Database=NewsLetterApi;Integrated Security=True; TrustServerCertificate=true;");
        }
    }
}
