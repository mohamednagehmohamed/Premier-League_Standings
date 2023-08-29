using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using allLeagues.Shared.DTOS;

namespace allLeagues.Shared.Services
{
    public class GetScorerService : IGetScorer
    {
        private readonly HttpClient httpClient;

        public GetScorerService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }


    }
}
