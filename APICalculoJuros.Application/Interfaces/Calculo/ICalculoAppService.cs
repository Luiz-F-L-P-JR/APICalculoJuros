using System.Threading.Tasks;

namespace APICalculoJuros.Application.Interfaces.Calculo
{
    public interface ICalculoAppService
    {
        Task<decimal> PegarCalculoJurosAsync(decimal valorInicial, int tempo);
    }
}
