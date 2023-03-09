using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace API_ThiagoNascimento.Models.Interfaces
{
    public interface ITabelaService
    {
        List<tabelaModel> GetTabelaList();
    }

    public class tabelaService : ITabelaService
    {
        private readonly IConfiguration _configuration;

        public tabelaService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public List<tabelaModel> GetTabelaList()
        {
            var caminhoArquivo = _configuration.GetValue<string>("DefaultConnection");
            var json = File.ReadAllText(caminhoArquivo);
            var tabela = JsonConvert.DeserializeObject<List<tabelaModel>>(json);
            return tabela;
        }
    }
}
