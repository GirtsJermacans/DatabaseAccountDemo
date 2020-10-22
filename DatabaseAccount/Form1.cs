using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DatabaseAccount
{
    public partial class Form1 : Form
    {

        // DATA
        AdminPrivileges admin;
        UserPrivileges user;

        public Form1()
        {
            InitializeComponent();
            Database database = new Database();
            admin = new AdminPrivileges(database);
            user = new UserPrivileges(database);
        }

        // OPERATIONS
        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Please Insert Account Name: ");
            if (name != "")
            {
                if (user.SearchAccount(name))
                {
                    MessageBox.Show("Account : " + name + " Is In System!", "GREAT");
                }
                else
                {
                    MessageBox.Show("Account : " + name + " Is Not In System!", "TERRIBLE");
                }
            }
            else
                MessageBox.Show("No value inserted", "MESSAGE");
        }

        private void btnSearchAdmin_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Please Insert Account Name: ");
            if (name != "")
            {
                if (admin.SearchAccount(name))
                {
                    MessageBox.Show("Account : " + name + " Is In System!", "GREAT");
                }
                else
                {
                    MessageBox.Show("Account : " + name + " Is Not In System!", "TERRIBLE");
                }
            }
            else
                MessageBox.Show("No value inserted", "MESSAGE");
        }

        private void btnChangeName_Click(object sender, EventArgs e)
        {
            string oldName = Interaction.InputBox("Insert Account Name: ");
            if (oldName != "")
            {
                string newName = Interaction.InputBox("Insert New Account Name: ");
                if (newName != "")
                {
                    if (admin.SearchAccount(oldName))
                    {
                        admin.ChangeName(oldName, newName);
                        MessageBox.Show("Account name changed", "MESSAGE");
                    }
                    else
                        MessageBox.Show("No such account", "MESSAGE");
                }
                else
                    MessageBox.Show("No value inserted", "MESSAGE");
            }
            else
                MessageBox.Show("No value inserted", "MESSAGE");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = Interaction.InputBox("Input Username: ");
            string password = Interaction.InputBox("Input Password: ");

            if ((admin.CheckUsername(userName)) && (admin.CheckPassword(password)))
            {
                MessageBox.Show("Correct Details!", "WELCOME");
                btnChangeName.Enabled = true;
                btnSearchAdmin.Enabled = true;
                btnAddAccount.Enabled = true;
                btnLogin.Visible = false;
                btnLogOut.Visible = true;
                btnSearchUser.Enabled = false;
                btnRemoveAccount.Enabled = true;
                lblMessage.Text = userName;
            }
            else
                MessageBox.Show("Wrong Details!", "NO NO NO");
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Insert Account Name: ");
            if (name != "")
                admin.AddAccount(name);
            else
                MessageBox.Show("No value inserted", "MESSAGE");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are now logged out", "Bye");
            btnChangeName.Enabled = false;
            btnSearchAdmin.Enabled = false;
            btnAddAccount.Enabled = false;
            btnLogin.Visible = true;
            btnLogOut.Visible = false;
            btnSearchUser.Enabled = true;
            btnRemoveAccount.Enabled = false;
            lblMessage.Text = "Welcome";
        }

        private void btnRemoveAccount_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Insert Account Name: ");
            if (name != "")
            {
                if (admin.SearchAccount(name))
                {
                    admin.RemoveAccount(name);
                    MessageBox.Show("Account removed", "MESSAGE");
                }
                else
                    MessageBox.Show("No such account", "MESSAGE");
            }
            else
                MessageBox.Show("No value inserted", "MESSAGE");
        }
    }
}
