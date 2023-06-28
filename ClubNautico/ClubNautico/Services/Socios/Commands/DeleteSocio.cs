using ClubNautico.Data;
using ClubNautico.Models;
using ClubNautico.Valdations.Socios.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClubNautico.Services.Socios.Commands
{
    public class DeleteSocio
    {
        public class DeleteSocioCommand : IRequest<Socio>
        {
            public int Id { get; set; }
        }

        public class DeleteSocioHandler : IRequestHandler<DeleteSocioCommand, Socio>
        {
            private readonly ApplicationContext _context;
            private readonly DeleteSocioCommandValidation _validation;

            public DeleteSocioHandler(ApplicationContext context, DeleteSocioCommandValidation vadation)
            {
                _context = context;
                _validation = vadation;
            }

            public async Task<Socio> Handle(DeleteSocioCommand request, CancellationToken cancellationToken)
            {
                _validation.Validate(request);
                try
                {
                    var socio = await _context.Socios.FirstOrDefaultAsync(s => s.Id == request.Id);
                    if (socio != null)
                    {
                        _context.Socios.Remove(socio);

                        await _context.SaveChangesAsync();

                        return socio;
                    }
                    else
                    {
                        throw new ArgumentNullException(nameof(socio));
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
