namespace DatabaseAccount
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.btnChangeName = new System.Windows.Forms.Button();
            this.btnSearchAdmin = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchUser);
            this.groupBox1.Location = new System.Drawing.Point(65, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users";
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(33, 120);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(168, 37);
            this.btnSearchUser.TabIndex = 2;
            this.btnSearchUser.Text = "Search Account";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoveAccount);
            this.groupBox2.Controls.Add(this.btnAddAccount);
            this.groupBox2.Controls.Add(this.btnChangeName);
            this.groupBox2.Controls.Add(this.btnSearchAdmin);
            this.groupBox2.Controls.Add(this.btnLogin);
            this.groupBox2.Controls.Add(this.btnLogOut);
            this.groupBox2.Location = new System.Drawing.Point(333, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 268);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Admin";
            // 
            // btnRemoveAccount
            // 
            this.btnRemoveAccount.Enabled = false;
            this.btnRemoveAccount.Location = new System.Drawing.Point(37, 163);
            this.btnRemoveAccount.Name = "btnRemoveAccount";
            this.btnRemoveAccount.Size = new System.Drawing.Size(168, 37);
            this.btnRemoveAccount.TabIndex = 8;
            this.btnRemoveAccount.Text = "Remove Account";
            this.btnRemoveAccount.UseVisualStyleBackColor = true;
            this.btnRemoveAccount.Click += new System.EventHandler(this.btnRemoveAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Enabled = false;
            this.btnAddAccount.Location = new System.Drawing.Point(37, 34);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(168, 37);
            this.btnAddAccount.TabIndex = 6;
            this.btnAddAccount.Text = "Add Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnChangeName
            // 
            this.btnChangeName.Enabled = false;
            this.btnChangeName.Location = new System.Drawing.Point(37, 120);
            this.btnChangeName.Name = "btnChangeName";
            this.btnChangeName.Size = new System.Drawing.Size(168, 37);
            this.btnChangeName.TabIndex = 4;
            this.btnChangeName.Text = "Change Account Name";
            this.btnChangeName.UseVisualStyleBackColor = true;
            this.btnChangeName.Click += new System.EventHandler(this.btnChangeName_Click);
            // 
            // btnSearchAdmin
            // 
            this.btnSearchAdmin.Enabled = false;
            this.btnSearchAdmin.Location = new System.Drawing.Point(37, 77);
            this.btnSearchAdmin.Name = "btnSearchAdmin";
            this.btnSearchAdmin.Size = new System.Drawing.Size(168, 37);
            this.btnSearchAdmin.TabIndex = 3;
            this.btnSearchAdmin.Text = "Search Account";
            this.btnSearchAdmin.UseVisualStyleBackColor = true;
            this.btnSearchAdmin.Click += new System.EventHandler(this.btnSearchAdmin_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(37, 220);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(168, 37);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "LogIn";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(37, 220);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(168, 37);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Visible = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(280, 317);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(66, 17);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Welcome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 358);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnChangeName;
        private System.Windows.Forms.Button btnSearchAdmin;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnRemoveAccount;
        private System.Windows.Forms.Label lblMessage;
    }
}

