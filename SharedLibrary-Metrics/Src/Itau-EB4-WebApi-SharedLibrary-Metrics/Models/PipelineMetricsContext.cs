using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Itau_EB4_WebApi_SharedLibrary_Metrics.Models
{
    public class PipelineMetricsContext : DbContext
    {
        public PipelineMetricsContext(DbContextOptions<PipelineMetricsContext> options) : base(options)
        {

        }

        public DbSet<PipelineMetrics> PipelineMetrics { get; set; }
    }
}
