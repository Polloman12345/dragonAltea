using asociacionDragon.infrastructure.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using asociacionDragon.domain;

namespace asociacionDragon.application
{
    public class MemberService
    {
        private readonly IMemberRepository _memberRepository;

        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public void SaveMember(Member member)
        {
            _memberRepository.Upsert(member);
        }

        public List<Member> GetAllMember()
        {
            return _memberRepository.GetAll();
        }

        public void DeleteMembers(List<Guid> selectedElements)
        {
            selectedElements.ForEach(memberId => _memberRepository.Delete(memberId));
        }
    }
}
