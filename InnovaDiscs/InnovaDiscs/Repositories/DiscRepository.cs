using InnovaDiscs.Context;
using InnovaDiscs.Models;
using InnovaDiscs.Repositories.Interfaces;

namespace InnovaDiscs.Repositories
{
    public class DiscRepository : Repository<Disc>, IDiscRepository
    {
        public DiscRepository(InnovaDiscsContext dBcontext)
            : base(dBcontext)
        {   
        }

    }
}
