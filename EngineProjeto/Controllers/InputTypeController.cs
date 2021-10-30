using EngineProjeto.Data;
using EngineProjeto.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EngineProjeto.Controllers
{
    [Route("[controller]")]
    [ApiController]


 
    public class InputTypeController : ControllerBase
    {
        private readonly DataBaseContext _DataBaseContext;

        public InputTypeController(DataBaseContext context) { _DataBaseContext = context; }

        [HttpGet]
        [Route("all")]
        public IEnumerable<InputType> GetInputs() { return _DataBaseContext.InputType; }
    }



}
