using ClubNautico.Data;
using ClubNautico.Models;
using Microsoft.EntityFrameworkCore;

namespace ClubNautico.ValidationsBack
{
    public class ExisteSocio : IExisteSocio
    {
        private readonly ApplicationContext _context;

        public ExisteSocio(ApplicationContext context)
        {
            _context = context;
        }
        public async Task Validar(Socio socio)
        {
            bool existeSocios = await _context.Socios.AnyAsync(s =>
                s.Nombre == socio.Nombre);

            if (existeSocios)
            {
                throw new Exception("El socio ya existe");
            }
        }
    }
}
