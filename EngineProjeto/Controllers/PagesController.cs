using EngineProjeto.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Http;


namespace EngineProjeto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PagesController : ControllerBase
    {
        private readonly DataBaseContext _dbContext;
        public PagesController(DataBaseContext DBContext)
        {
            _dbContext = DBContext;
        }


        [HttpGet] //Get All Pages
        public async Task<ActionResult<IEnumerable<Pages>>> GetPages() { return await _dbContext.Pages.ToListAsync(); }

        [HttpGet("{id}")] //Get One Page
        public async Task<ActionResult<Pages>> GetPageName(int id)
        {
            var page = await _dbContext.Pages.FindAsync(id);
            if (page == null)
            {
                return NotFound();
            }
            return page;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPage(int id, Pages page)
        {
            if (id != page.PageID)
            {
                return BadRequest();
            }

            _dbContext.Entry(page).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PageExists(id))
                {
                    return NotFound();
                }
                else
                    throw;
            }

            return Ok();
        }

        [HttpPost]

        public async Task<IActionResult> PostPage(Pages page)
        {
            if (PageExists(page.PageID))
            {
                return BadRequest();
            }

            _dbContext.Pages.Add(page);
            await _dbContext.SaveChangesAsync();

           return CreatedAtAction("GetPageName", new { id = page.PageID }, page); 
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePage(int id)
        {
            var page = await _dbContext.Pages.FindAsync(id);
            if (page == null)
            {
                return NotFound();
            }

            _dbContext.Pages.Remove(page);
            await _dbContext.SaveChangesAsync();
            if (PageExists(id))
            {
                return BadRequest();
            }
            return Ok();
        }


        private bool PageExists(int id)
        {
            return _dbContext.Pages.Any(p => p.PageID == id);
        }
    }
}
