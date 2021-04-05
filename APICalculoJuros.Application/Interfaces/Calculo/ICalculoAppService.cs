using System.Threading.Tasks;

namespace APICalculoJuros.Application.Interfaces.Calculo
{
    public interface ICalculoAppService
    {
        Task<decimal> GetCalculoJurosAsync(decimal valorInicial, int tempo);
    }
}
