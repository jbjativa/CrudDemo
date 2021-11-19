using System;
using Microsoft.EntityFrameworkCore;
namespace CrudDemo.Data
{
    public class CrudDemoContext :DbContext
    {
        public CrudDemoContext(DbContextOptions<CrudDemoContext> options) : base(options)
        {
            
        }
        
    }
}