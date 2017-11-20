using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependancyInjectionExample.Managers;
using DependancyInjectionExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependancyInjectionExample.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IValuesManager _valuesManager;
        public ValuesController(IValuesManager valuesManager)
        {
            _valuesManager = valuesManager;
        }

        [HttpGet]
        public async Task<Value> Get()
        {
            return await _valuesManager.GetValues();
        }

        [HttpPost]
        public IActionResult Post()
        {
            _valuesManager.AddValue();
            
            return Ok();
        }
    }
}
