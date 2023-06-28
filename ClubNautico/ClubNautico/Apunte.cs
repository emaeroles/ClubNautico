using ClubNautico.Data;
using ClubNautico.Models;
using Microsoft.EntityFrameworkCore;

namespace ClubNautico
{
    public class Apunte
    {
        private ApplicationContext _context = new ApplicationContext();

        public async void miFuncion(int id)
        {


            



            
            // LINQ
            
            // La sintaxis de consulta:

            var socio = await(from s in _context.Socios
                              where s.Id == id
                              select s).FirstOrDefaultAsync();


            // La sintaxis de método:

            var socio1 = await _context.Socios.Where(s => s.Id == id)
                                              .FirstOrDefaultAsync();



            /*
              
          
            var socio2 = await(from s in _context.Socios
                               where s.Id == id
                               join t in _context.TipoDni on s.IdTipoDin equals t.Id
                               select new
                               {
                                   IdSocio = s.Id,
                                   NombreSocio = s.Nombre,
                                   Apellido = s.Apellido,
                                   Telefono = s.Telefono,
                                   TipoDni = t.Tipo,
                                   NumDni = s.NumDni
                               }).FirstOrDefaultAsync();
            */

            /*
              
          
            var persona = await(from p in _context.Personas
                                where p.Id == request.id
                                join se in _context.Sexos on p.IdSexo equals se.Id
                                join pa in _context.Paises on p.IdPais equals pa.Id
                                join pr in _context.Provincias on p.IdProvincia equals pr.Id
                                select new
                                {
                                    Id = p.Id,
                                    Nombre = p.Nombre,
                                    Apellido = p.Apellido,
                                    Dni = p.Dni,
                                    Sexo = se.Sexo,
                                    Pais = pa.Pais,
                                    Provincia = pr.Provincia
                                }).FirstOrDefaultAsync();
            
             
             */
        }
    }
}
