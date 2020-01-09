using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Itau_EB4_WebApi_SharedLibrary_Metrics.Models;

namespace Itau_EB4_WebApi_SharedLibrary_Metrics.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PipelineMetricsController : ControllerBase
    {
        private readonly PipelineMetricsContext _context;

        public PipelineMetricsController(PipelineMetricsContext context)
        {
            _context = context;
            if(_context.PipelineMetrics.Count() == 0)
            {
                _context.PipelineMetrics.Add(new PipelineMetrics { Name = "teste" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<PipelineMetrics>> GetAll()
        {
            return _context.PipelineMetrics.ToList();
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public ActionResult<PipelineMetrics> GetById(long id)
        {
            var item = _context.PipelineMetrics.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }
    }
}
