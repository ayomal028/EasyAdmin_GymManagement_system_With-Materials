namespace EasyAdmin.gym_management_system
{
    partial class registration_and_login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registration_and_login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_exit = new System.Windows.Forms.Button();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_Login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_showPword = new Bunifu.Framework.UI.BunifuImageButton();
            this.dropdown_usertype_login = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_showPword)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btn_exit
            // 
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.Location = new System.Drawing.Point(581, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(44, 34);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(78, 175);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(445, 28);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 3;
            this.bunifuSeparator2.Location = new System.Drawing.Point(78, 283);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(445, 14);
            this.bunifuSeparator2.TabIndex = 4;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(108, 219);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txt_userName
            // 
            this.txt_userName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txt_userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_userName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_userName.Location = new System.Drawing.Point(196, 158);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(327, 25);
            this.txt_userName.TabIndex = 8;
            this.txt_userName.Text = "Username";
            this.txt_userName.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.txt_userName.Enter += new System.EventHandler(this.Txt_userName_Enter);
            this.txt_userName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_userName_KeyDown);
            this.txt_userName.Leave += new System.EventHandler(this.Txt_userName_Leave);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_password.Location = new System.Drawing.Point(196, 255);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(327, 25);
            this.txt_password.TabIndex = 9;
            this.txt_password.Text = "Password";
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.Enter += new System.EventHandler(this.Txt_password_Enter);
            this.txt_password.Leave += new System.EventHandler(this.Txt_password_Leave);
            // 
            // btn_Login
            // 
            this.btn_Login.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Login.BorderRadius = 0;
            this.btn_Login.ButtonText = "LOGIN";
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Login.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Login.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Login.Iconimage")));
            this.btn_Login.Iconimage_right = null;
            this.btn_Login.Iconimage_right_Selected = null;
            this.btn_Login.Iconimage_Selected = null;
            this.btn_Login.IconMarginLeft = 0;
            this.btn_Login.IconMarginRight = 0;
            this.btn_Login.IconRightVisible = true;
            this.btn_Login.IconRightZoom = 0D;
            this.btn_Login.IconVisible = true;
            this.btn_Login.IconZoom = 60D;
            this.btn_Login.IsTab = false;
            this.btn_Login.Location = new System.Drawing.Point(144, 486);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Login.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.btn_Login.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Login.selected = false;
            this.btn_Login.Size = new System.Drawing.Size(281, 59);
            this.btn_Login.TabIndex = 10;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Login.Textcolor = System.Drawing.Color.White;
            this.btn_Login.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // btn_showPword
            // 
            this.btn_showPword.BackColor = System.Drawing.Color.Transparent;
            this.btn_showPword.Image = ((System.Drawing.Image)(resources.GetObject("btn_showPword.Image")));
            this.btn_showPword.ImageActive = null;
            this.btn_showPword.Location = new System.Drawing.Point(540, 255);
            this.btn_showPword.Name = "btn_showPword";
            this.btn_showPword.Size = new System.Drawing.Size(32, 25);
            this.btn_showPword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_showPword.TabIndex = 14;
            this.btn_showPword.TabStop = false;
            this.btn_showPword.Zoom = 10;
            this.btn_showPword.Click += new System.EventHandler(this.btn_showPword_Click);
            // 
            // dropdown_usertype_login
            // 
            this.dropdown_usertype_login.BackColor = System.Drawing.Color.Transparent;
            this.dropdown_usertype_login.BorderRadius = 3;
            this.dropdown_usertype_login.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dropdown_usertype_login.DisabledColor = System.Drawing.Color.Gray;
            this.dropdown_usertype_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown_usertype_login.ForeColor = System.Drawing.Color.White;
            this.dropdown_usertype_login.Items = new string[] {
        "select",
        "owner",
        "trainer"};
            this.dropdown_usertype_login.Location = new System.Drawing.Point(183, 375);
            this.dropdown_usertype_login.Margin = new System.Windows.Forms.Padding(4);
            this.dropdown_usertype_login.Name = "dropdown_usertype_login";
            this.dropdown_usertype_login.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dropdown_usertype_login.onHoverColor = System.Drawing.Color.Coral;
            this.dropdown_usertype_login.selectedIndex = 0;
            this.dropdown_usertype_login.Size = new System.Drawing.Size(215, 37);
            this.dropdown_usertype_login.TabIndex = 15;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.AliceBlue;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(245, 338);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(103, 23);
            this.bunifuCustomLabel2.TabIndex = 16;
            this.bunifuCustomLabel2.Text = "User Type";
            // 
            // registration_and_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(630, 615);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.dropdown_usertype_login);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_showPword);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.bunifuSeparator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registration_and_login";
            this.Opacity = 0.94D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registration_and_login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registration_and_login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Registration_and_login_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_showPword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Login;
        private System.Windows.Forms.Button btn_exit;
        private Bunifu.Framework.UI.BunifuImageButton btn_showPword;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDropdown dropdown_usertype_login;
    }
}