using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Itau_EB4_WebApi_SharedLibrary_Metrics.Models
{
    public class PipelineMetrics
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string Result { get; set; }
    }
}
