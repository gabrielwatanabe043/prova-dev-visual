using APIExemplo.Data;
using APIExemplo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIExemplo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {

        private readonly ExemploContext _context;

        public VeiculoController(ExemploContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Veiculo>>> getVeiculos() {
            if (_context.Veiculos == null) {
                return NotFound();
            }
            return await _context.Veiculos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Veiculo>> getVeiculoId(int id) {

            if (_context.Veiculos == null) {
                return NotFound();
            }
            var veiculo = await _context.Veiculos.FindAsync(id);

            if (veiculo == null) {
                return NotFound();
            }

            return veiculo;
        }

        [HttpPost]
        public async Task<ActionResult<Veiculo>> postVeiculo(Veiculo veiculo) {

            if (_context.Veiculos == null) {
                return BadRequest();
            }
            if (veiculo.ano < 1930) {
                return Problem("ERRO ANO");
            }
            _context.Veiculos.Add(veiculo);
            await _context.SaveChangesAsync();
            return veiculo;
        }
    }
}
