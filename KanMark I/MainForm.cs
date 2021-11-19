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
            newTask.FormClosing += (e, sender) =>
            {
                System.Diagnostics.Debug.WriteLine("Form Closing");
                ShowNewCard(newTask.title, newTask.desc, new Point(19, todoGrp.Height - 195), "To do");
            };
        }

        public void ShowNewCard(string title, string desc, Point grpLocation, string status)
        {
            GroupBox parent;
            switch (status)
            {
                case "To do": parent = todoGrp; break;
                case "Doing": parent = doingGrp; break;
                case "Done": parent = doneGrp; break;
                default: parent = todoGrp; break;
            }

            GroupBox newGrp = new GroupBox();
            newGrp.Text = title;
            newGrp.Location = new Point(19, todoGrp.Height - 195);
            newGrp.Size = new Size(316, 183);
            newGrp.Font = new Font("Segoe UI Black", 10);
            ControlExtension.Draggable(newGrp, true);
            newGrp.Click += (sender, e) =>
            {
                if (Cursor == Cursors.Cross)
                {
                    newGrp.Hide();
                    Cursor = Cursors.Default;
                }
            };

            TextBox newBox = new TextBox();
            newBox.Text = desc;
            newBox.Multiline = true;
            newBox.Location = new Point(6, 32);
            newBox.Size = new Size(295, 91);
            newBox.ReadOnly = true;
            newBox.Font = new Font("Segoe UI", 10);

            Button newLeftBtn = new Button();
            newLeftBtn.Text = "<";
            newLeftBtn.Location = new Point(6, 133);
            newLeftBtn.Size = new Size(107, 38);
            

            Button newRightBtn = new Button();
            newRightBtn.Text = ">";
            newRightBtn.Location = new Point(197, 133);
            newRightBtn.Size = new Size(107, 38);

            if(parent == todoGrp)
            {
                newLeftBtn.Enabled = false;
                newRightBtn.Enabled = true;
            }
            else if(parent == doingGrp)
            {
                newLeftBtn.Enabled = true;
                newRightBtn.Enabled = true;
            }
            else if(parent == doneGrp)
            {
                newLeftBtn.Enabled = true;
                newRightBtn.Enabled = false;
            }

            // Add buttons functionality
            newRightBtn.Click += (sender, e) =>
            {
                if(newRightBtn.Parent.Parent == todoGrp)
                {
                    newRightBtn.Parent.Parent = doingGrp;
                    newLeftBtn.Enabled = true;
                }
                else if(newRightBtn.Parent.Parent == doingGrp)
                {
                    newRightBtn.Parent.Parent = doneGrp;
                    newRightBtn.Enabled = false;
                }
            };

            newLeftBtn.Click += (sender, e) =>
            {
                if (newLeftBtn.Parent.Parent == doneGrp)
                {
                    newLeftBtn.Parent.Parent = doingGrp;
                    newRightBtn.Enabled = true;
                }

                else if (newLeftBtn.Parent.Parent == doingGrp)
                {
                    newLeftBtn.Parent.Parent = todoGrp;
                    newLeftBtn.Enabled = false;
                }
            };

            // Makes sure the GroupBox is never disaligned
            newGrp.MouseUp += (sender, e) =>
            {
                newGrp.Location = new Point(19, newGrp.Location.Y);
            };

            // Show all the new controls
            Controls.Add(newGrp);
            Controls.Add(newBox);
            Controls.Add(newLeftBtn);
            Controls.Add(newRightBtn);

            newGrp.BringToFront();
            newBox.BringToFront();
            newLeftBtn.BringToFront();
            newRightBtn.BringToFront();

            // Corrects the hierarchy
            newGrp.Parent = parent;
            newBox.Parent = newGrp;
            newLeftBtn.Parent = newGrp;
            newRightBtn.Parent = newGrp;
        }

        private void RmCardBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Remove Card Button");

            Cursor = Cursors.Cross;
        }
    }
}