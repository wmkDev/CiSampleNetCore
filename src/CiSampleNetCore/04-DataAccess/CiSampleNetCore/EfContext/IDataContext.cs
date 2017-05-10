using CiSampleNetCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace CiSampleNetCore.Data.EfContext
{
    public interface IDataContext
    {
        DbSet<Todo> Todos { get; set; }
    }
}