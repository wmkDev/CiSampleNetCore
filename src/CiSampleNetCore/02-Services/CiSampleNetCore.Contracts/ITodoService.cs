using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CiSampleNetCore.ViewModel;

namespace CiSampleNetCore.Contracts
{
    public interface ITodoService
    {
        Task<List<TodoViewModel>> GetAllAsync();
    }
}
