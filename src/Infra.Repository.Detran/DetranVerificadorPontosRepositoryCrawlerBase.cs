using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public abstract class DetranVerificadorPontosRepositoryCrawlerBase : IDetranVerificadorPontosRepository
    {
        public async Task<IEnumerable<PontoCnh>> ConsultarPontos(Cnh cnh)
        {
            var html = await RealizarAcesso(cnh);
            return await PadronizarResultado(html);
        }

        protected abstract Task<string> RealizarAcesso(Cnh cnh);
        protected abstract Task<IEnumerable<PontoCnh>> PadronizarResultado(string html);
    }
}
