using InnovaDiscs.Context;
using InnovaDiscs.Models;
using InnovaDiscs.Repositories.Interfaces;

namespace InnovaDiscs.Repositories
{
    public class DiscGolferRepository : Repository<DiscGolfer>, IDiscGolferRepository
    {
        public DiscGolferRepository(InnovaDiscsContext dBcontext)
            :base(dBcontext)
        {
              
        }
        
    }
    
}
