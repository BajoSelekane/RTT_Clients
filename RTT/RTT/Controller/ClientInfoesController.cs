using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RTT.Data;
using RTT.Entities;

namespace RTT.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientInfoesController : ControllerBase
    {
        private readonly DataContext _context;

        public ClientInfoesController(DataContext context)
        {
            _context = context;
        }

       
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientInfo>>> GetClientInfos()
        {
            return await _context.ClientInfos.ToListAsync();
        }
        [HttpGet]
        //In order to export the file kindly navigate to this controller named ExportClient!
        public FileResult ExportClient()
        {
            string[] columnNames = new string[] { "Id", "Name", "Surname", "Gender" };
            var clients = new List<ClientInfo>();
            string csv = string.Empty;

            foreach (string column in columnNames)
            {
                csv += column + ',';
            }
            csv += "\r\n";

            foreach (var client in _context.ClientInfos) 
            {
                csv += client.Name.ToString().Replace(",", ";") + ',';
                csv += client.Surname.ToString().Replace(",", ";") + ',';
                csv += client.Gender.ToString().Replace(",", ";") + ',';

                csv += "\r\n";
            }
            byte[] bytes = Encoding.ASCII.GetBytes(csv);
            return File(bytes, "text/csv", "ImportClientInfo.csv");
        }
      
        [HttpGet("{id}")]
        public async Task<ActionResult<ClientInfo>> GetClientInfo(Guid id)
        {
            var clientInfo = await _context.ClientInfos.FindAsync(id);

            if (clientInfo == null)
            {
                return NotFound();
            }

            return clientInfo;
        }

       
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClientInfo(Guid id, ClientInfo clientInfo)
        {
            if (id != clientInfo.Id)
            {
                return BadRequest();
            }

            _context.Entry(clientInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientInfoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

       
        [HttpPost]
        public async Task<ActionResult<ClientInfo>> PostClientInfo(ClientInfo clientInfo)
        {
            _context.ClientInfos.Add(clientInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClientInfo", new { id = clientInfo.Id }, clientInfo);
        }

       
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClientInfo(Guid id)
        {
            var clientInfo = await _context.ClientInfos.FindAsync(id);
            if (clientInfo == null)
            {
                return NotFound();
            }

            _context.ClientInfos.Remove(clientInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClientInfoExists(Guid id)
        {
            return _context.ClientInfos.Any(e => e.Id == id);
        }
    }
}
