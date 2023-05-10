using asociacionDragon.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asociacionDragon.infrastructure.repository
{
    public interface IMemberRepository
    {
        List<Member> GetAll();
        void Upsert(Member member);

        void Delete(Guid id);
    }
}
