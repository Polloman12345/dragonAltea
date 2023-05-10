using asociacionDragon.domain;
using Newtonsoft.Json;

namespace asociacionDragon.infrastructure.repository
{
    public class JsonGameRepository : GameRepository
    {
        private readonly string _filePath;

        public JsonGameRepository(string filePath)
        {
            _filePath = filePath;
        }

        public List<Game> GetAll()
        {
            if (!File.Exists(_filePath))
            {
                return new List<Game>();
            }

            string json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Game>>(json);
        }

        public void Upsert(Game game)
        {
            List<Game> games = GetAll();

            int index = games.FindIndex(g => g.Id == game.Id);
            if (index != -1)
            {
                games[index] = game;
            }
            else
            {
                games.Add(game);
            }

            string json = JsonConvert.SerializeObject(games, (Newtonsoft.Json.Formatting)System.Xml.Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }

        public void Delete(Guid id)
        {
            List<Game> games = GetAll();
            games.RemoveAll(g => g.Id == id);
            string json = JsonConvert.SerializeObject(games, (Newtonsoft.Json.Formatting)System.Xml.Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }
}
