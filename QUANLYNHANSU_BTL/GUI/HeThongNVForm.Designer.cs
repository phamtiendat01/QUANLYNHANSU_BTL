using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using FontAwesome.Sharp;

namespace QUANLYNHANSU_BTL.GUI
{
    public partial class HeThongNVForm : Form
    {
        private Guna2Panel panelEditInfo;
        private Label lblTitle;
        private Label lblUsername;
        private Label lblOldPass;
        private Label lblNewPass;
        private Guna2TextBox txtUsername;
        private Guna2TextBox txtOldPass;
        private Guna2TextBox txtNewPass;
        private IconButton btnUpdate;



        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelEditInfo = new Guna2Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblTitle = new Label();
            lblUsername = new Label();
            lblOldPass = new Label();
            lblNewPass = new Label();
            txtUsername = new Guna2TextBox();
            txtOldPass = new Guna2TextBox();
            txtNewPass = new Guna2TextBox();
            btnUpdate = new IconButton();
            panelEditInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelEditInfo
            // 
            panelEditInfo.BackColor = Color.Transparent;
            panelEditInfo.BorderRadius = 10;
            panelEditInfo.Controls.Add(flowLayoutPanel1);
            panelEditInfo.Controls.Add(lblTitle);
            panelEditInfo.Controls.Add(lblUsername);
            panelEditInfo.Controls.Add(lblOldPass);
            panelEditInfo.Controls.Add(lblNewPass);
            panelEditInfo.Controls.Add(txtUsername);
            panelEditInfo.Controls.Add(txtOldPass);
            panelEditInfo.Controls.Add(txtNewPass);
            panelEditInfo.Controls.Add(btnUpdate);
            panelEditInfo.CustomizableEdges = customizableEdges7;
            panelEditInfo.FillColor = Color.White;
            panelEditInfo.Location = new Point(237, 86);
            panelEditInfo.Name = "panelEditInfo";
            panelEditInfo.ShadowDecoration.CustomizableEdges = customizableEdges8;
            panelEditInfo.ShadowDecoration.Enabled = true;
            panelEditInfo.Size = new Size(718, 405);
            panelEditInfo.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImage = Properties.Resources.mk;
            flowLayoutPanel1.Location = new Point(493, 105);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(181, 182);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.Location = new Point(222, 43);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(239, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Chỉnh sửa thông tin";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F);
            lblUsername.Location = new Point(30, 105);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(175, 23);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Nhập Tên đăng nhập:";
            // 
            // lblOldPass
            // 
            lblOldPass.AutoSize = true;
            lblOldPass.Font = new Font("Segoe UI", 10F);
            lblOldPass.Location = new Point(30, 165);
            lblOldPass.Name = "lblOldPass";
            lblOldPass.Size = new Size(156, 23);
            lblOldPass.TabIndex = 2;
            lblOldPass.Text = "Nhập mật khẩu cũ:";
            // 
            // lblNewPass
            // 
            lblNewPass.AutoSize = true;
            lblNewPass.Font = new Font("Segoe UI", 10F);
            lblNewPass.Location = new Point(30, 225);
            lblNewPass.Name = "lblNewPass";
            lblNewPass.Size = new Size(167, 23);
            lblNewPass.TabIndex = 3;
            lblNewPass.Text = "Nhập mật khẩu mới:";
            // 
            // txtUsername
            // 
            txtUsername.CustomizableEdges = customizableEdges1;
            txtUsername.DefaultText = "";
            txtUsername.Font = new Font("Segoe UI", 9F);
            txtUsername.Location = new Point(222, 105);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Tên đăng nhập";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtUsername.Size = new Size(249, 30);
            txtUsername.TabIndex = 4;
            // 
            // txtOldPass
            // 
            txtOldPass.CustomizableEdges = customizableEdges3;
            txtOldPass.DefaultText = "";
            txtOldPass.Font = new Font("Segoe UI", 9F);
            txtOldPass.Location = new Point(222, 158);
            txtOldPass.Margin = new Padding(3, 4, 3, 4);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.PasswordChar = '●';
            txtOldPass.PlaceholderText = "Mật khẩu cũ";
            txtOldPass.SelectedText = "";
            txtOldPass.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtOldPass.Size = new Size(249, 30);
            txtOldPass.TabIndex = 5;
            // 
            // txtNewPass
            // 
            txtNewPass.CustomizableEdges = customizableEdges5;
            txtNewPass.DefaultText = "";
            txtNewPass.Font = new Font("Segoe UI", 9F);
            txtNewPass.Location = new Point(222, 218);
            txtNewPass.Margin = new Padding(3, 4, 3, 4);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PasswordChar = '●';
            txtNewPass.PlaceholderText = "Mật khẩu mới";
            txtNewPass.SelectedText = "";
            txtNewPass.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtNewPass.Size = new Size(249, 30);
            txtNewPass.TabIndex = 6;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MediumSlateBlue;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.IconChar = IconChar.Save;
            btnUpdate.IconColor = Color.White;
            btnUpdate.IconFont = IconFont.Auto;
            btnUpdate.IconSize = 30;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(222, 282);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(117, 40);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.TextAlign = ContentAlignment.MiddleRight;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // HeThongNVForm
            // 
            ClientSize = new Size(1187, 652);
            Controls.Add(panelEditInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "HeThongNVForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chỉnh sửa thông tin nhân viên";
            panelEditInfo.ResumeLayout(false);
            panelEditInfo.PerformLayout();
            ResumeLayout(false);
        }

        private FlowLayoutPanel flowLayoutPanel1;
    }
}
