using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiEPharmacy.Data;
using ApiEPharmacy.Models;
using ApiEPharmacy.Services;


namespace ApiEPharmacy.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;
        // Construtor para injeção de dependência do contexto do banco de dados.
        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UsuarioSistema loginRequest)
        {
            // Verifica usuário no banco.
            var usuario = await _context.UsuarioSistema
                .FirstOrDefaultAsync(u => u.Login == loginRequest.Login && u.Senha == loginRequest.Senha);

            if (usuario == null)
                return Unauthorized("Usuário ou senha inválidos.");

            // Gera o token.

            var token = TokenService.GerarToken(usuario.Login, usuario.Nome);

            return Ok(new
            {
                usuario.Id,
                usuario.Nome,
                usuario.Login,
                token
            });
        }
    }
}
