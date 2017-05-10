using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CiSampleNetCore.ViewModel
{
    public class HomeViewModel
    {
        
        public ICollection<TodoViewModel> TodoViewModels { get; set; }
    }
}
