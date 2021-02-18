
namespace AcmeDrone
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtLoginPass = new System.Windows.Forms.TextBox();
            this.lblLoginPass = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pnlReg = new System.Windows.Forms.Panel();
            this.btnRegConfirm = new System.Windows.Forms.Button();
            this.lblRegConfirm = new System.Windows.Forms.Label();
            this.txtRegFname = new System.Windows.Forms.TextBox();
            this.txtRegPassConfirm = new System.Windows.Forms.TextBox();
            this.lblRegLname = new System.Windows.Forms.Label();
            this.lblRegFname = new System.Windows.Forms.Label();
            this.txtRegLname = new System.Windows.Forms.TextBox();
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.txtProfileConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblProfileConfirmPass = new System.Windows.Forms.Label();
            this.txtPcode = new System.Windows.Forms.TextBox();
            this.lblPcode = new System.Windows.Forms.Label();
            this.btnSubmitProfile = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtProfileUsername = new System.Windows.Forms.TextBox();
            this.txtProfilePassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtProfileLastname = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtProfileFirstname = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.dgvGrid = new System.Windows.Forms.DataGridView();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            this.pnlReg.SuspendLayout();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(49, 23);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(65, 12);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Username :";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(141, 20);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 21);
            this.txtLogin.TabIndex = 0;
            // 
            // txtLoginPass
            // 
            this.txtLoginPass.Location = new System.Drawing.Point(141, 47);
            this.txtLoginPass.Name = "txtLoginPass";
            this.txtLoginPass.Size = new System.Drawing.Size(100, 21);
            this.txtLoginPass.TabIndex = 1;
            // 
            // lblLoginPass
            // 
            this.lblLoginPass.AutoSize = true;
            this.lblLoginPass.Location = new System.Drawing.Point(49, 50);
            this.lblLoginPass.Name = "lblLoginPass";
            this.lblLoginPass.Size = new System.Drawing.Size(65, 12);
            this.lblLoginPass.TabIndex = 2;
            this.lblLoginPass.Text = "Password :";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(267, 18);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(267, 47);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.pnlReg);
            this.pnlLogin.Controls.Add(this.txtLogin);
            this.pnlLogin.Controls.Add(this.btnRegister);
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.lblLoginPass);
            this.pnlLogin.Controls.Add(this.txtLoginPass);
            this.pnlLogin.Location = new System.Drawing.Point(324, 66);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(350, 254);
            this.pnlLogin.TabIndex = 0;
            // 
            // pnlReg
            // 
            this.pnlReg.Controls.Add(this.btnRegConfirm);
            this.pnlReg.Controls.Add(this.lblRegConfirm);
            this.pnlReg.Controls.Add(this.txtRegFname);
            this.pnlReg.Controls.Add(this.txtRegPassConfirm);
            this.pnlReg.Controls.Add(this.lblRegLname);
            this.pnlReg.Controls.Add(this.lblRegFname);
            this.pnlReg.Controls.Add(this.txtRegLname);
            this.pnlReg.Location = new System.Drawing.Point(3, 76);
            this.pnlReg.Name = "pnlReg";
            this.pnlReg.Size = new System.Drawing.Size(339, 133);
            this.pnlReg.TabIndex = 11;
            // 
            // btnRegConfirm
            // 
            this.btnRegConfirm.Location = new System.Drawing.Point(264, 107);
            this.btnRegConfirm.Name = "btnRegConfirm";
            this.btnRegConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnRegConfirm.TabIndex = 3;
            this.btnRegConfirm.Text = "Register";
            this.btnRegConfirm.UseVisualStyleBackColor = true;
            // 
            // lblRegConfirm
            // 
            this.lblRegConfirm.AutoSize = true;
            this.lblRegConfirm.Location = new System.Drawing.Point(-2, 6);
            this.lblRegConfirm.Name = "lblRegConfirm";
            this.lblRegConfirm.Size = new System.Drawing.Size(113, 12);
            this.lblRegConfirm.TabIndex = 30;
            this.lblRegConfirm.Text = "Confrim Password :";
            // 
            // txtRegFname
            // 
            this.txtRegFname.Location = new System.Drawing.Point(138, 30);
            this.txtRegFname.Name = "txtRegFname";
            this.txtRegFname.Size = new System.Drawing.Size(100, 21);
            this.txtRegFname.TabIndex = 1;
            // 
            // txtRegPassConfirm
            // 
            this.txtRegPassConfirm.Location = new System.Drawing.Point(138, 3);
            this.txtRegPassConfirm.Name = "txtRegPassConfirm";
            this.txtRegPassConfirm.Size = new System.Drawing.Size(100, 21);
            this.txtRegPassConfirm.TabIndex = 0;
            // 
            // lblRegLname
            // 
            this.lblRegLname.AutoSize = true;
            this.lblRegLname.Location = new System.Drawing.Point(40, 60);
            this.lblRegLname.Name = "lblRegLname";
            this.lblRegLname.Size = new System.Drawing.Size(71, 12);
            this.lblRegLname.TabIndex = 21;
            this.lblRegLname.Text = "Last Name :";
            // 
            // lblRegFname
            // 
            this.lblRegFname.AutoSize = true;
            this.lblRegFname.Location = new System.Drawing.Point(34, 33);
            this.lblRegFname.Name = "lblRegFname";
            this.lblRegFname.Size = new System.Drawing.Size(77, 12);
            this.lblRegFname.TabIndex = 20;
            this.lblRegFname.Text = "First Name :";
            // 
            // txtRegLname
            // 
            this.txtRegLname.Location = new System.Drawing.Point(138, 57);
            this.txtRegLname.Name = "txtRegLname";
            this.txtRegLname.Size = new System.Drawing.Size(100, 21);
            this.txtRegLname.TabIndex = 2;
            // 
            // pnlProfile
            // 
            this.pnlProfile.Controls.Add(this.txtProfileConfirmPassword);
            this.pnlProfile.Controls.Add(this.lblProfileConfirmPass);
            this.pnlProfile.Controls.Add(this.txtPcode);
            this.pnlProfile.Controls.Add(this.lblPcode);
            this.pnlProfile.Controls.Add(this.btnSubmitProfile);
            this.pnlProfile.Controls.Add(this.btnEdit);
            this.pnlProfile.Controls.Add(this.txtAddress);
            this.pnlProfile.Controls.Add(this.txtProfileUsername);
            this.pnlProfile.Controls.Add(this.txtProfilePassword);
            this.pnlProfile.Controls.Add(this.lblUsername);
            this.pnlProfile.Controls.Add(this.txtProfileLastname);
            this.pnlProfile.Controls.Add(this.lblFirstName);
            this.pnlProfile.Controls.Add(this.txtProfileFirstname);
            this.pnlProfile.Controls.Add(this.lblLastName);
            this.pnlProfile.Controls.Add(this.lblPass);
            this.pnlProfile.Controls.Add(this.lblAddress);
            this.pnlProfile.Location = new System.Drawing.Point(25, 50);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(280, 261);
            this.pnlProfile.TabIndex = 7;
            // 
            // txtProfileConfirmPassword
            // 
            this.txtProfileConfirmPassword.Location = new System.Drawing.Point(143, 124);
            this.txtProfileConfirmPassword.Name = "txtProfileConfirmPassword";
            this.txtProfileConfirmPassword.Size = new System.Drawing.Size(100, 21);
            this.txtProfileConfirmPassword.TabIndex = 4;
            // 
            // lblProfileConfirmPass
            // 
            this.lblProfileConfirmPass.AutoSize = true;
            this.lblProfileConfirmPass.Location = new System.Drawing.Point(13, 127);
            this.lblProfileConfirmPass.Name = "lblProfileConfirmPass";
            this.lblProfileConfirmPass.Size = new System.Drawing.Size(113, 12);
            this.lblProfileConfirmPass.TabIndex = 20;
            this.lblProfileConfirmPass.Text = "Confirm Password :";
            // 
            // txtPcode
            // 
            this.txtPcode.Location = new System.Drawing.Point(143, 183);
            this.txtPcode.Name = "txtPcode";
            this.txtPcode.Size = new System.Drawing.Size(100, 21);
            this.txtPcode.TabIndex = 6;
            // 
            // lblPcode
            // 
            this.lblPcode.AutoSize = true;
            this.lblPcode.Location = new System.Drawing.Point(43, 186);
            this.lblPcode.Name = "lblPcode";
            this.lblPcode.Size = new System.Drawing.Size(83, 12);
            this.lblPcode.TabIndex = 10;
            this.lblPcode.Text = "Postal Code :";
            // 
            // btnSubmitProfile
            // 
            this.btnSubmitProfile.Location = new System.Drawing.Point(143, 215);
            this.btnSubmitProfile.Name = "btnSubmitProfile";
            this.btnSubmitProfile.Size = new System.Drawing.Size(104, 23);
            this.btnSubmitProfile.TabIndex = 8;
            this.btnSubmitProfile.Text = "Submit Change";
            this.btnSubmitProfile.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(51, 215);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(143, 151);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 21);
            this.txtAddress.TabIndex = 5;
            // 
            // txtProfileUsername
            // 
            this.txtProfileUsername.Location = new System.Drawing.Point(143, 16);
            this.txtProfileUsername.Name = "txtProfileUsername";
            this.txtProfileUsername.Size = new System.Drawing.Size(100, 21);
            this.txtProfileUsername.TabIndex = 0;
            // 
            // txtProfilePassword
            // 
            this.txtProfilePassword.Location = new System.Drawing.Point(143, 97);
            this.txtProfilePassword.Name = "txtProfilePassword";
            this.txtProfilePassword.Size = new System.Drawing.Size(100, 21);
            this.txtProfilePassword.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(61, 19);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(65, 12);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username :";
            // 
            // txtProfileLastname
            // 
            this.txtProfileLastname.Location = new System.Drawing.Point(143, 70);
            this.txtProfileLastname.Name = "txtProfileLastname";
            this.txtProfileLastname.Size = new System.Drawing.Size(100, 21);
            this.txtProfileLastname.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(49, 46);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(77, 12);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "First Name :";
            // 
            // txtProfileFirstname
            // 
            this.txtProfileFirstname.Location = new System.Drawing.Point(143, 43);
            this.txtProfileFirstname.Name = "txtProfileFirstname";
            this.txtProfileFirstname.Size = new System.Drawing.Size(100, 21);
            this.txtProfileFirstname.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(55, 73);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(71, 12);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Last Name :";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(61, 100);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(65, 12);
            this.lblPass.TabIndex = 10;
            this.lblPass.Text = "Password :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(67, 154);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(59, 12);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Address :";
            // 
            // dgvGrid
            // 
            this.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrid.Location = new System.Drawing.Point(25, 338);
            this.dgvGrid.Name = "dgvGrid";
            this.dgvGrid.RowTemplate.Height = 23;
            this.dgvGrid.Size = new System.Drawing.Size(649, 218);
            this.dgvGrid.TabIndex = 8;
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Location = new System.Drawing.Point(531, 50);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(59, 12);
            this.lblLogout.TabIndex = 9;
            this.lblLogout.Text = "Hi James!";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(322, 28);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(47, 12);
            this.lblMessage.TabIndex = 10;
            this.lblMessage.Text = "Error: ";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 629);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.dgvGrid);
            this.Controls.Add(this.pnlProfile);
            this.Controls.Add(this.pnlLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlReg.ResumeLayout(false);
            this.pnlReg.PerformLayout();
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region UI componnts
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtLoginPass;
        private System.Windows.Forms.Label lblLoginPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Button btnSubmitProfile;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtProfileUsername;
        private System.Windows.Forms.TextBox txtProfilePassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtProfileLastname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtProfileFirstname;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.DataGridView dgvGrid;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.TextBox txtPcode;
        private System.Windows.Forms.Label lblPcode;
        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel pnlReg;
        private System.Windows.Forms.Label lblRegConfirm;
        private System.Windows.Forms.TextBox txtRegFname;
        private System.Windows.Forms.TextBox txtRegPassConfirm;
        private System.Windows.Forms.Label lblRegLname;
        private System.Windows.Forms.Label lblRegFname;
        private System.Windows.Forms.TextBox txtRegLname;
        private System.Windows.Forms.Button btnRegConfirm;
        private System.Windows.Forms.TextBox txtProfileConfirmPassword;
        private System.Windows.Forms.Label lblProfileConfirmPass;
    }
}

