using ClubNautico.Models;

namespace ClubNautico.ValidationsBack
{
    public interface IExisteSocio
    {
        Task Validar(Socio socio);
    }
}
