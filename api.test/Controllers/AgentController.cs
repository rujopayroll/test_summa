using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using domain.test.services;
using domain.test.interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace api.test.Controllers
{
    [Route("api/[controller]")]
    public class AgentController : Controller
    {
        private  IAgentFactory agentFactory;

        public AgentController(AgentFactory agentFactory)
        {
            this.agentFactory = agentFactory;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

    }
}

