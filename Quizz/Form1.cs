using Newtonsoft.Json;

namespace Quizz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_deck_Click(object sender, EventArgs e)
        {
            addDeckUserControl1.BringToFront();
        }

        private void WriteDecksToFile(List<Deck> decks)
        {
            string deckContent = JsonConvert.SerializeObject(decks);
            File.WriteAllText("decks.json", deckContent);
        }


        private List<Deck> LoadDecksFromFiles()
        {
            string json = File.ReadAllText("decks.json");
            return JsonConvert.DeserializeObject<List<Deck>>(json);
        }

        private void button_start_quizz_Click(object sender, EventArgs e)
        {
            startQuizzUserControl1.BringToFront();
        }

        private void button_modify_deck_Click(object sender, EventArgs e)
        {
            addQuestionUserControl1.BringToFront();
        }
    }
}
