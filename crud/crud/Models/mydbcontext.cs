using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crud.Models
{
    public class mydbcontext:DbContext
    {
        public mydbcontext(DbContextOptions<mydbcontext> options) : base(options)
        {

        }
        public DbSet<nhanvien> nhanviens { get; set; }
    }
}
