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
    public partial class Form_MakeUserAdmin : Form
    {
        public Form_MakeUserAdmin()
        {
            InitializeComponent();

            //bind the enum AdminType to populate the ComboBox dropdown values
            cbAdminLevel.DataSource = Enum.GetValues(typeof(AdminType));
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //get the enum from the selected item
            AdminType selectedAdminType;
            if (!Enum.TryParse(cbAdminLevel.SelectedValue.ToString(), out selectedAdminType))
            {
                throw new Exception("Selected Admin Type is invalid");
            }

            Form_UserList.chosenAdminType = selectedAdminType;
            Form_UserList.isMadeAdmin = true;

            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Form_UserList.isMadeAdmin = false;
            this.Close();
        }

    }
}
