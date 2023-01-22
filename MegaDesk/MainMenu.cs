namespace MegaDesk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MegaDesk_Load(object sender, EventArgs e)
        {

        }

        private void addQuote_Click(object sender, EventArgs e)
        {
            AddQuote openAddQuote = new AddQuote();
            openAddQuote.Tag = this;
            openAddQuote.Show(this);
            Hide();
        }

        private void viewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes openViewAllQuotes = new ViewAllQuotes();
            openViewAllQuotes.Tag = this;
            openViewAllQuotes.Show(this);
            Hide();
        }

        private void searchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes openSearchQuotes = new SearchQuotes();
            openSearchQuotes.Tag = this;
            openSearchQuotes.Show(this);
            Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //Close();
            Application.Exit();
        }
    }
}