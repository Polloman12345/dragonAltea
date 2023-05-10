using asociacionDragon.domain;
using Newtonsoft.Json;

namespace asociacionDragon.infrastructure.repository
{
    public class JsonMemberRepository : MemberRepository
    {
        private readonly string _filePath;

        public JsonMemberRepository(string filePath)
        {
            _filePath = filePath;
        }

        public List<Member> GetAll()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Member>();
            }

            string json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Member>>(json);
        }

        public void Upsert(Member member)
        {
            List<Member> members = GetAll();

            int index = members.FindIndex(m => m.Id == member.Id);
            if (index != -1)
            {
                members[index] = member;
            }
            else
            {
                members.Add(member);
            }

            string json = JsonConvert.SerializeObject(members, (Newtonsoft.Json.Formatting)System.Xml.Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }

        public void Delete(Guid id)
        {
            List<Member> members = GetAll();
            members.RemoveAll(m => m.Id == id);
            string json = JsonConvert.SerializeObject(members, (Newtonsoft.Json.Formatting)System.Xml.Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }
}
