using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagement
{
    public partial class Form_UserRating : Form
    {
        public Form_UserRating()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //get the checked rating (radio button) in the container (group box)
            var checkedRating = ratingGrpBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            //convert the text string to int
            int rating = Convert.ToInt32(checkedRating.Text);

            Form_UserList.chosenRating = rating;
            Form_UserList.ratingIsProvided = true;

            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Form_UserList.ratingIsProvided = false;
            this.Close();
        }

    }
}