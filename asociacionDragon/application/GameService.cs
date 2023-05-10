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
    public class GameService
    {
        private readonly IGameRepository _gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public void SaveGame(Game game)
        {
            _gameRepository.Upsert(game);
        }

        public List<Game> GetAllGames()
        {
            return _gameRepository.GetAll();
        }

        public void DeleteGames(List<Guid> selectedElements)
        {
            selectedElements.ForEach(gameId => _gameRepository.Delete(gameId));
        }
    }
}
