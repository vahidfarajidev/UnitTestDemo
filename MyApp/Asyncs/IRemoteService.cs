using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Asyncs
{
    public interface IRemoteService
    {
        Task<string> FetchDataAsync();
        Task<int> GetStatusCodeAsync();
    }
}
