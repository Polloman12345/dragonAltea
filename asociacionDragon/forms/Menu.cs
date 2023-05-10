using asociacionDragon.application;
using asociacionDragon.infrastructure.repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asociacionDragon.forms
{
    public partial class Menu : Form
    {
        private readonly GameList gameList;

        public Menu(GameList gameList)
        {
            InitializeComponent();
            this.gameList = gameList;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            gameList.ShowDialog();
        }
    }
}
