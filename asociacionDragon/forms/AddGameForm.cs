using asociacionDragon.domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asociacionDragon
{
    public partial class AddGameForm : Form
    {
        public Game game { get; set; }
        public AddGameForm()
        {
            InitializeComponent();
            this.game = new Game();
            game.Id = Guid.NewGuid();
            game.CreationDate = DateTime.Now;
        }

        private void AddGameForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            game.Name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            game.Price = textBox2.Text;
        }
    }
}
