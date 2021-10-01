using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeruStars_2.Domain.Persistence.Repositories
{
    public interface IUnitofWork
    {
        Task CompleteAsync();
    }
}
