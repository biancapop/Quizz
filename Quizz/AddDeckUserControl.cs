using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizz
{
    public partial class AddDeckUserControl : UserControl
    {

        private List<Deck> decks = new List<Deck>();
        public AddDeckUserControl()
        {
            InitializeComponent();
            //decks = LoadDecksFromFiles();
        }

  
        private void btn_add_deck_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_deck_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_deck_Click(object sender, EventArgs e)
        {

        }
    }
}
