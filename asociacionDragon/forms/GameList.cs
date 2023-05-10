using asociacionDragon.application;
using asociacionDragon.domain;
using asociacionDragon.forms;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System.Linq;

namespace asociacionDragon
{
    public partial class GameList : Form
    {
        private readonly GameService _gameService;

        public GameList(GameService gameService) : base()
        {
            InitializeComponent();
            _gameService = gameService;

            listView1.Columns.Add("Id", 230);
            listView1.Columns.Add("Nombre", 300);
            listView1.Columns.Add("Precio", 100);
            listView1.Columns.Add("Fecha", 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var addGameForm = new AddGameForm();

            if (addGameForm.ShowDialog() != DialogResult.OK)
                return;

            Game game = addGameForm.game;
            _gameService.SaveGame(game);
            refreshList();
        }

        private void refreshList()
        {
            listView1.Items.Clear();
            var games = _gameService.GetAllGames();
            foreach (var game in games)
            {
                var item = new ListViewItem(game.Id.ToString());
                item.SubItems.Add(game.Name);
                item.SubItems.Add(game.Price);
                item.SubItems.Add(game.CreationDate.ToString());
                listView1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedElements = listView1.Items.Cast<ListViewItem>()
                                              .Where(item => item.Checked)
                                              .Select(item => item.SubItems[0].Text)
                                              .Select(id => Guid.Parse(id))
                                              .ToList();

            _gameService.DeleteGames(selectedElements);
            refreshList();
        }

        private void GameList_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
            //Menu menu = new();
            //menu.Show(); 
            //this.Hide();
        }

        private void GameList_Load(object sender, EventArgs e)
        {

            refreshList();
        }
    }
}