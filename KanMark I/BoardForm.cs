using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;


namespace KanMark_I
{
    public partial class BoardForm : Form
    {
        public BoardForm()
        {
            InitializeComponent();

            var collections = Model.Model.GetCols();

            foreach(var collection in collections)
            {
                boardSelector.Items.Add(collection);
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            string selectedBoard = boardSelector.Text;

            if (selectedBoard != "")
            {
                Model.Model.currentCollection = selectedBoard;
                System.Diagnostics.Debug.WriteLine(Model.Model.currentCollection);

                foreach(Form form in Application.OpenForms)
                {
                    form.Hide();
                }

                new MainForm().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Board name should not be empty.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rmBtn_Click(object sender, EventArgs e)
        {
            string selectedBoard = boardSelector.Text;

            if (selectedBoard != "")
            {
                Model.Model.RemoveCollection(selectedBoard);
                this.Close();
            }
            else
            {
                MessageBox.Show("Board name should not be empty.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
