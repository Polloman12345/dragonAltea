using asociacionDragon.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asociacionDragon.infrastructure.repository
{
    public interface GameRepository
    {
        List<Game> GetAll();
        void Upsert(Game game);

        void Delete(Guid id);
    }
}
