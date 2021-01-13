using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranSPVerificadorPontosRepository : IDetranVerificadorPontosRepository
    {
        private readonly ILogger _Logger;

        public DetranSPVerificadorPontosRepository(ILogger<DetranSPVerificadorPontosRepository> logger)
        {
            _Logger = logger;
        }

        public Task<IEnumerable<PontoCnh>> ConsultarPontos(Cnh cnh)
        {
            _Logger.LogDebug($"Consultando pontos da CNH número {cnh.Codigo} para o estado de SP.");
            return Task.FromResult<IEnumerable<PontoCnh>>(new List<PontoCnh>() { new PontoCnh() });
        }
    }
}
