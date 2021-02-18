using DBLibrary;
using DBLibrary.DAOImpl;
using DBLibrary.Utilities;
using System;
using System.Windows.Forms;

namespace AcmeDrone
{
    public partial class Form1 : Form
    {
        private UserActionsImpl _userAction = new UserActionsImpl();
        private static readonly log4net.ILog log =
log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private User _u = null;

        public Form1()
        {
            InitializeComponent();
            initSettings();
            
        }

        private void initSettings()
        {
            loginState();
            lblMessage.ForeColor = System.Drawing.Color.Red;
            
            btnLogin.Click += loginFunc;
            btnRegister.Click += registerFunc;
            btnRegConfirm.Click += registerFunc;

            //Clean the error message in login state
            txtLogin.MouseHover += (Sender, Eargs) => { lblMessage.Text = GlobalResrouces.msgEmpty; };
            txtLoginPass.MouseHover += (Sender, Eargs) => { lblMessage.Text = GlobalResrouces.msgEmpty; };

            //logout click
            lblLogout.Click += (Sender, Eargs) => { logout(); };

            //Get password hiden
            txtLoginPass.GotFocus += onPassField;
            txtRegPassConfirm.GotFocus += onPassField;
            txtProfilePassword.GotFocus += onPassField;
            txtProfileConfirmPassword.GotFocus += onPassField;

            //Modification state
            btnEdit.Click += (Sender, Eargs) => { editableTxtFields(pnlProfile, !txtProfileFirstname.Enabled); };
            btnSubmitProfile.Click += submitProfile;

            //clean msgs
            txtProfileUsername.GotFocus += (S, E) =>{ msgState(false); };
            lblMessage.Click += (S, E) => { msgState(false); };

            }

        private void onPassField(object sender, EventArgs e) {
            ((TextBox)sender).UseSystemPasswordChar = true;
        }

        private void msgState(bool check = true)
        {
            lblMessage.Text = GlobalResrouces.msgEmpty;
            lblMessage.Visible = check;
        }

        private void logout() {
            lblLogout.Text = GlobalResrouces.msgEmpty; 
            lblLogout.Visible = false;
            _u = null;
            loginState();
        }

        private void loginState() {
            lblLogout.Visible = false; //Hide login label first
            pnlProfile.Visible = false;
            pnlLogin.Visible = true;
            pnlReg.Visible = false;
            lblMessage.Visible = false;
            cleanTxtControls(pnlLogin);
        }

        private void profileState()
        {
            lblLogout.Visible = true; //Hide login label first
            pnlProfile.Visible = true;
            pnlLogin.Visible = false;
            pnlReg.Visible = false;
            msgState(false);
            lblLogout.Text = String.Format(GlobalResrouces.helloSir,_u.FirstName);
            pnlProfile.Left = (this.ClientSize.Width - pnlProfile.Width) / 2;
            loadProfile();
        }

        private void RegisteringState() {
            lblLogout.Visible = false;
            pnlProfile.Visible = false;
            pnlLogin.Visible = true;
            pnlReg.Visible = true;
            lblMessage.Text = GlobalResrouces.doUserRegistration;
        }

        private void loginFunc(object sender, EventArgs e) {
            if (pnlReg.Visible) { loginState(); return; }

            if (!_userAction.isUserExist(txtLogin.Text))
            {
                msgState();
                lblMessage.Text = GlobalResrouces.msgErrorType + GlobalResrouces.userNotExists;
                log.Info(GlobalResrouces.userNotExists);
                log.Info(GlobalResrouces.doUserRegistration);
                RegisteringState();
                return; //Skip next ones
            }

            if (!_userAction.isUserValidate(txtLogin.Text, txtLoginPass.Text))
            {
                msgState();
                lblMessage.Text = GlobalResrouces.msgErrorType + GlobalResrouces.userNotValid;
                log.Info(GlobalResrouces.userNotValid);
                return;
            }
            //if both condition passed
            _u = _userAction.getUserByEmail(txtLogin.Text);
            profileState();
            editableTxtFields(pnlProfile,false);
        }

        private void registerFunc(object sender, EventArgs e)
        {
            if (!pnlReg.Visible) { pnlReg.Visible = true; }
            try
            {
                if (!_userAction.createUser(txtRegFname.Text, txtRegLname.Text, txtLogin.Text, txtLoginPass.Text))
                {
                    msgState();
                    lblMessage.Text = GlobalResrouces.msgErrorType + GlobalResrouces.userNameInvalid;
                }
                else {
                    lblMessage.Text = GlobalResrouces.userCreated;
                    loginState();
                }
            }
            catch (Exception ex) {
                log.Error(ex.Message);
                log.Error(GlobalResrouces.userCreateFail);
            }
        }

        private void submitProfile(object sender, EventArgs e) {
            if (!txtProfilePassword.Text.Equals(txtProfileConfirmPassword.Text)) {
                msgState();
                log.Error(GlobalResrouces.msgErrorPasswordNotMatching);
                return; 
            }

            if (txtProfilePassword.TextLength == 0)
            {
                _u.Password = "";
            }
            else {
                _u.Password = txtProfilePassword.Text;
            }

            _u.Address = txtAddress.Text;
            _u.PostalCode = txtPcode.Text;
            

            if (!_userAction.updateUserProfile(_u))
            {
                msgState();
                log.Error(GlobalResrouces.msgErrorFailToUpdateUserInfo);
                lblMessage.Text = GlobalResrouces.msgErrorFailToUpdateUserInfo;
            }
            else {
                msgState();
                log.Info(GlobalResrouces.msgUpdateUserInfo);
                lblMessage.Text = GlobalResrouces.msgUpdateUserInfo;
            }
        }

        private void loadProfile() {

            foreach (Control o in pnlProfile.Controls)
            {
                if (!o.GetType().Name.Contains(GlobalResrouces.txtBoxName)) continue;

                if (o.Name.Contains(GlobalResrouces.txtProfileUser)) { txtProfileUsername.Text = _u.Email; }

                if (o.Name.Contains(GlobalResrouces.txtProfileFname)) { txtProfileFirstname.Text = _u.FirstName; }

                if (o.Name.Contains(GlobalResrouces.txtProfileLname)) { txtProfileLastname.Text = _u.LastName; }

                if (o.Name.Contains(GlobalResrouces.txtProfileAddr)) { txtAddress.Text = _u.Address; }

                if (o.Name.Contains(GlobalResrouces.txtProfilePcode)) { txtPcode.Text = _u.PostalCode; }

                if (o.Name.Contains(GlobalResrouces.txtProfilePass)) { txtProfilePassword.Text = GlobalResrouces.msgEmpty; }

                if (o.Name.Contains(GlobalResrouces.txtProfileConfirmPass)) { txtProfileConfirmPassword.Text = GlobalResrouces.msgEmpty; }

                o.Enabled = false;
            }
        }

        private void editableTxtFields(Panel p,bool check) {
            foreach (Control o in p.Controls)
            {
                if (!o.GetType().Name.Contains(GlobalResrouces.txtBoxName)) continue;
                if (o.Name.Contains(GlobalResrouces.txtProfileUser)) continue;//No edits on email/username
                o.Enabled = check;
            }
        }

        private void cleanTxtControls(Panel p) {
            foreach (Control o in p.Controls)
            {
                if (o.GetType().Name.Contains(GlobalResrouces.txtBoxName)) {
                    o.Text = GlobalResrouces.msgEmpty;
                }
            }
        }
    }
}
