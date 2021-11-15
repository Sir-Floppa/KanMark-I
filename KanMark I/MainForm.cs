namespace KanMark_I
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void newCardBtn_Click(object sender, EventArgs e)
        {
            // Spawns the New Card Form
            NewCardForm newTask = new NewCardForm();
            newTask.Show();
        }
    }
}