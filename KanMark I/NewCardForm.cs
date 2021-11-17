using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanMark_I
{
    public partial class NewCardForm : Form
    {
        public NewCardForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string title = titleBox.Text;
            string desc = descBox.Text;

            if (title != "" && desc != "")
            {
                Controller.TaskCard newCard = new Controller.TaskCard(title, desc);

                // Connect with the DB and add the new card
                Model.Model.newTaskDB(newCard);
            }
            else
            {
                MessageBox.Show("Task Title and Description should not be empty.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
