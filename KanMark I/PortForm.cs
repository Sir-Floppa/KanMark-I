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
    public partial class PortForm : Form
    {
        public PortForm()
        {
            InitializeComponent();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will change your DB connection port and may cause trouble if done incorrectly. Continue?", 
                "Changing DB connection Port.",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Debug.WriteLine("Continues");
                Model.Model.mongoClient = portField.Text;

                foreach (Form form in Application.OpenForms)
                {
                    form.Hide();
                }

                new MainForm().Show();
                this.Close();
            }
            else if(result == DialogResult.No)
            {
                System.Diagnostics.Debug.WriteLine("Doesn't continue");
                this.Close();
            }
        }
    }
}
