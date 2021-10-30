using EngineProjeto.Data;
using EngineProjeto.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace EngineProjeto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TesteController : ControllerBase
    {
        private readonly DataBaseContext _DataBaseContext;
        public TesteController(DataBaseContext DBContext)
        {
            _DataBaseContext = DBContext;
        }


        [HttpGet("{id}")]
        public IEnumerable<Teste> GetTeste(int id)
        {
            //var param = new SqlPara
            //var nomes = _DataBaseContext.Teste.FromSqlRaw("select p.PageID, p.PageName, pip.InputTypeID, ipt.Mandatory, isl.Color from Pages p, PageInput pip, InputProperties ipt, InputStyle isl where p.PageID = pip.PageID and pip.InputPropertiesID = ipt.InputPropertiesID and ipt.InputStyleID = isl.InputStyleID; ").ToList();
            var data = _DataBaseContext.Teste.FromSqlRaw("EXECUTE selectPageInfo {0}", id).ToList();
            return data;
        }
    }
}
