using ClubNautico.Business.SociosBusiness.Commands;
using FluentValidation;

namespace ClubNautico.Valdations.Socios.Commands
{
    public class SaveSocioCommandValidation : AbstractValidator<SaveSocioCommand>
    {
        public SaveSocioCommandValidation()
        {
            RuleFor(s => s.Nombre).NotEmpty();
            RuleFor(s => s.Apellido).NotEmpty();
            RuleFor(s => s.Telefono).NotEmpty();
        }
    }
}
