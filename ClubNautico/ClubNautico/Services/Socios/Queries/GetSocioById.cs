using ClubNautico.Data;
using ClubNautico.Models;
using ClubNautico.Valdations.Socios.Queries;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClubNautico.Business.SociosBusiness.Queries
{
    public class GetSocioByIdQuery : IRequest<Socio>
    {
        public int Id { get; set; }
    }

    public class GetSocioByIdHandler : IRequestHandler<GetSocioByIdQuery, Socio>
    {
        private readonly ApplicationContext _context;
        private readonly GetSocioByIdQueryValidation _validatio;

        public GetSocioByIdHandler(ApplicationContext context, GetSocioByIdQueryValidation vadation)
        {
            _context = context;
            _validatio = vadation;
        }

        public async Task<Socio> Handle(GetSocioByIdQuery request, CancellationToken cancellationToken)
        {
            _validatio.Validate(request);
            try
            {
                var socio = await _context.Socios.FirstOrDefaultAsync(s => s.Id == request.Id);
                if (socio != null)
                    return socio;
                else
                    throw new ArgumentNullException(nameof(socio));
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }

}
