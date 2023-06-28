using ClubNautico.Business.SociosBusiness.Queries;
using FluentValidation;

namespace ClubNautico.Valdations.Socios.Queries
{
    public class GetSocioByIdQueryValidation : AbstractValidator<GetSocioByIdQuery>
    {
        public GetSocioByIdQueryValidation()
        {
            RuleFor(g => g.Id).NotEmpty();
        }
    }
}
