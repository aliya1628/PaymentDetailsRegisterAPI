using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreWebAPIDemo.Models
{
    public class PaymentDetailsContext:DbContext
    {
        /*options: In this parameters we have to pass information like DBProvider(i.e. SQL SERVER,MYSQL etc), Connection strings
          how we can pass values those values into this constructor parameter for that we will use "Dependency Injection" */
        public PaymentDetailsContext(DbContextOptions<PaymentDetailsContext> options):base(options)
        {

        }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
