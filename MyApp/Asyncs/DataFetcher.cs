using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Asyncs
{
    public class DataFetcher
    {
        private readonly IRemoteService _remoteService;

        public DataFetcher(IRemoteService remoteService)
        {
            _remoteService = remoteService;
        }

        public async Task<string> GetFormattedData()
        {
            var data = await _remoteService.FetchDataAsync();
            return $"[DATA]: {data}";
        }

        public async Task<string> GetStatusMessage()
        {
            var status = await _remoteService.GetStatusCodeAsync();
            return status == 200 ? "OK" : "FAIL";
        }        
    }
}
