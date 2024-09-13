using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiRestAula.Models;

namespace ApiRestAula.Data
{
    public class ApiRestAulaContext : DbContext
    {
        public ApiRestAulaContext (DbContextOptions<ApiRestAulaContext> options)
            : base(options)
        {
        }

        public DbSet<ApiRestAula.Models.Produto> Produto { get; set; } = default!;
    }
}
