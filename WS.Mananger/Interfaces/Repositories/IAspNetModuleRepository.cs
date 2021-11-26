﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WS.Core.Domain;

namespace WS.Mananger.Interfaces
{
    public interface IAspNetModuleRepository
    {
        Task<bool> ExistsAsync(int id);
        Task<AspNetModule> GetAspNetModuleAsync(int id);
        Task<IEnumerable<AspNetModule>> GetAspNetModulesAsync();
        Task<AspNetModule> InsertAspNetModule(AspNetModule aspNetModule);
        Task<AspNetModule> UpdateAspNetModule(AspNetModule aspNetModule);
        Task DeleteAspNetModule(int id);

    }
}