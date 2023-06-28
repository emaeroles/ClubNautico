using ClubNautico.Services.Socios.Commands;
using FluentValidation;

namespace ClubNautico.Valdations.Socios.Commands
{
    public class UpdateSocioCommandValidation : AbstractValidator<UpdateSocioCommand>
    {
        public UpdateSocioCommandValidation()
        {
            RuleFor(s => s.Id).NotEmpty();
            RuleFor(s => s.Nombre).NotEmpty();
            RuleFor(s => s.Apellido).NotEmpty();
            RuleFor(s => s.Telefono).NotEmpty();
        }
    }
}
