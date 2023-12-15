using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrypographyPractice.net7.Models;

namespace CrypographyPractice.net7.Data
{
    public class CrypographyPracticenet7Context : DbContext
    {
        public CrypographyPracticenet7Context (DbContextOptions<CrypographyPracticenet7Context> options)
            : base(options)
        {
        }

        public DbSet<CrypographyPractice.net7.Models.Kid> Kids { get; set; } = default!;
    }
}
