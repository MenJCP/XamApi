using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamapi.Models;

namespace Xamapi.Services
{
    public interface IStateApiService
    {
        Task<StateInfo> GetStateAsync();
         
    }

}
