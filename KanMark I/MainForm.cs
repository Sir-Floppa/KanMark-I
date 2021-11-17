namespace KanMark_I
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void NewCardBtn_Click(object sender, EventArgs e)
        {
            // Spawns the New Card Form
            NewCardForm newTask = new NewCardForm();
            newTask.Show();
        }

        public void ShowNewCard(string title, string desc)
        {
            GroupBox newGrp = new GroupBox();
            newGrp.Text = title;
            newGrp.Parent = todoGrp;
            newGrp.Location = new Point(19 + todoGrp.Location.X, 447 + todoGrp.Location.Y);
            newGrp.Size = new Size(316, 183);
            newGrp.Font = new Font("Segoe UI Black", 10);

            TextBox newBox = new TextBox();
            newBox.Text = desc;
            newBox.Parent = newGrp;
            newBox.Multiline = true;
            newBox.Location = new Point(6 + newGrp.Location.X, 32 + newGrp.Location.Y);
            newBox.Size = new Size(295, 91);
            newBox.ReadOnly = true;

            Controls.Add(newGrp);
            Controls.Add(newBox);

            newGrp.BringToFront();
            newBox.BringToFront();
        }

        private void RmCardBtn_Click(object sender, EventArgs e)
        {
            ShowNewCard("1234", "asdasd");
        }
    }
}