using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Guna.UI2.WinForms;

namespace QUANLYNHANSU_BTL.GUI
{
    partial class LoginForm
    {
        private Guna2TextBox txtUsername;
        private Guna2TextBox txtPassword;
        private Guna2Button btnLogin;
        private Guna2CheckBox chkShowPassword;
        private Label lblTitle;
        private IconPictureBox iconUser;
        private IconPictureBox iconLock;
        private PictureBox iconTop;

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtUsername = new Guna2TextBox();
            txtPassword = new Guna2TextBox();
            btnLogin = new Guna2Button();
            chkShowPassword = new Guna2CheckBox();
            lblTitle = new Label();
            iconUser = new IconPictureBox();
            iconLock = new IconPictureBox();
            iconTop = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)iconUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconLock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconTop).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BorderRadius = 8;
            txtUsername.CustomizableEdges = customizableEdges1;
            txtUsername.DefaultText = "";
            txtUsername.Font = new Font("Segoe UI", 9F);
            txtUsername.Location = new Point(59, 190);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Tên đăng nhập";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtUsername.Size = new Size(300, 45);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.BorderRadius = 8;
            txtPassword.CustomizableEdges = customizableEdges3;
            txtPassword.DefaultText = "";
            txtPassword.Font = new Font("Segoe UI", 9F);
            txtPassword.Location = new Point(59, 250);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Mật khẩu";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtPassword.Size = new Size(300, 45);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 8;
            btnLogin.CustomizableEdges = customizableEdges5;
            btnLogin.FillColor = Color.DeepSkyBlue;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(59, 376);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnLogin.Size = new Size(300, 45);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.Click += btnLogin_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.CheckedState.BorderRadius = 0;
            chkShowPassword.CheckedState.BorderThickness = 0;
            chkShowPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkShowPassword.Location = new Point(59, 318);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(190, 24);
            chkShowPassword.TabIndex = 6;
            chkShowPassword.Text = "Hiển thị mật khẩu";
            chkShowPassword.UncheckedState.BorderRadius = 0;
            chkShowPassword.UncheckedState.BorderThickness = 0;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 60);
            lblTitle.Location = new Point(59, 125);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(297, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "QUẢN LÝ NHÂN SỰ";
            // 
            // iconUser
            // 
            iconUser.BackColor = Color.WhiteSmoke;
            iconUser.ForeColor = Color.DeepSkyBlue;
            iconUser.IconChar = IconChar.User;
            iconUser.IconColor = Color.DeepSkyBlue;
            iconUser.IconFont = IconFont.Auto;
            iconUser.Location = new Point(21, 190);
            iconUser.Name = "iconUser";
            iconUser.Size = new Size(32, 32);
            iconUser.TabIndex = 2;
            iconUser.TabStop = false;
            // 
            // iconLock
            // 
            iconLock.BackColor = Color.WhiteSmoke;
            iconLock.ForeColor = Color.DeepSkyBlue;
            iconLock.IconChar = IconChar.Lock;
            iconLock.IconColor = Color.DeepSkyBlue;
            iconLock.IconFont = IconFont.Auto;
            iconLock.Location = new Point(21, 250);
            iconLock.Name = "iconLock";
            iconLock.Size = new Size(32, 32);
            iconLock.TabIndex = 4;
            iconLock.TabStop = false;
            // 
            // iconTop
            // 
            iconTop.Image = (Image)resources.GetObject("iconTop.Image");
            iconTop.Location = new Point(149, 22);
            iconTop.Name = "iconTop";
            iconTop.Size = new Size(100, 100);
            iconTop.SizeMode = PictureBoxSizeMode.StretchImage;
            iconTop.TabIndex = 0;
            iconTop.TabStop = false;
            // 
            // LoginForm
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(396, 498);
            Controls.Add(iconTop);
            Controls.Add(lblTitle);
            Controls.Add(iconUser);
            Controls.Add(txtUsername);
            Controls.Add(iconLock);
            Controls.Add(txtPassword);
            Controls.Add(chkShowPassword);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ĐĂNG NHẬP";
            ((System.ComponentModel.ISupportInitialize)iconUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconLock).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconTop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
