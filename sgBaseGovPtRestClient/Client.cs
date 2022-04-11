using System.Net.Http.Json;
using sgBaseGovPtRestClient.Entities;

namespace sgBaseGovPtRestClient
{
    public class Client
    {
        const string Url = @"http://www.base.gov.pt/base2/rest";
        static HttpClient _client = new HttpClient();
        static Dictionary<Type, string> _TypeSubUrlMap = new Dictionary<Type, string>() 
        {
            { typeof(Asset), "bensmoveis" },
            { typeof(Entity), "entidades" },
            { typeof(ContractSummary), "contratos" },
            { typeof(Contract), "contratos" },
        };

        public Client()
        {
        }

        public async Task<T?> GetById<T>(int id)
        {
            var url = $"{Url}/{_TypeSubUrlMap[typeof(T)]}/{id}";
            return await _client.GetFromJsonAsync<T>(url);
        }

        public async Task<IEnumerable<T>?> List<T>(int pageNumber, int pageSize = 10, bool ascending = true)
        {
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Add("range", $"items={(pageNumber - 1) * pageSize}-{pageNumber * pageSize - 1}");
            var url = $"{Url}/{_TypeSubUrlMap[typeof(T)]}?sort({(ascending ? "+" : "-")}id)";
            return await _client.GetFromJsonAsync<IEnumerable<T>>(url);
        }
    }
}