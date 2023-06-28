using FluentValidation;
using static ClubNautico.Services.Socios.Commands.DeleteSocio;

namespace ClubNautico.Valdations.Socios.Commands
{
    public class DeleteSocioCommandValidation : AbstractValidator<DeleteSocioCommand>
    {
        public DeleteSocioCommandValidation()
        {
            RuleFor(s => s.Id).NotEmpty();
        }
    }
}
