
namespace LibraryManagement
{
    partial class Login
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.userBox = new MaterialSkin.Controls.MaterialTextBox();
            this.passBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.loginButton = new MaterialSkin.Controls.MaterialButton();
            this.registerButton = new MaterialSkin.Controls.MaterialButton();
            this.exitButton = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.sourceBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.passShow = new MaterialSkin.Controls.MaterialSwitch();
            this.radioDG = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioNV = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioAD = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(24, 160);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(74, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Tài Khoản";
            // 
            // userBox
            // 
            this.userBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userBox.Depth = 0;
            this.userBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userBox.LeadingIcon = null;
            this.userBox.Location = new System.Drawing.Point(118, 129);
            this.userBox.MaxLength = 50;
            this.userBox.MouseState = MaterialSkin.MouseState.OUT;
            this.userBox.Multiline = false;
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(272, 50);
            this.userBox.TabIndex = 1;
            this.userBox.Text = "";
            this.userBox.TrailingIcon = null;
            // 
            // passBox
            // 
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passBox.Depth = 0;
            this.passBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passBox.LeadingIcon = null;
            this.passBox.Location = new System.Drawing.Point(118, 185);
            this.passBox.MaxLength = 50;
            this.passBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passBox.Multiline = false;
            this.passBox.Name = "passBox";
            this.passBox.Password = true;
            this.passBox.Size = new System.Drawing.Size(272, 50);
            this.passBox.TabIndex = 3;
            this.passBox.Text = "";
            this.passBox.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(24, 216);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(70, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Mật Khẩu";
            // 
            // loginButton
            // 
            this.loginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.loginButton.Depth = 0;
            this.loginButton.HighEmphasis = true;
            this.loginButton.Icon = null;
            this.loginButton.Location = new System.Drawing.Point(284, 286);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.loginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(105, 36);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "ĐĂNG NHẬP";
            this.loginButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loginButton.UseAccentColor = false;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.registerButton.Depth = 0;
            this.registerButton.HighEmphasis = true;
            this.registerButton.Icon = null;
            this.registerButton.Location = new System.Drawing.Point(714, 94);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(79, 36);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "ĐĂNG KÍ";
            this.registerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.registerButton.UseAccentColor = false;
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.exitButton.Depth = 0;
            this.exitButton.HighEmphasis = true;
            this.exitButton.Icon = null;
            this.exitButton.Location = new System.Drawing.Point(118, 286);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.exitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(69, 36);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "THOÁT";
            this.exitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.exitButton.UseAccentColor = false;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.radioAD);
            this.materialCard1.Controls.Add(this.radioNV);
            this.materialCard1.Controls.Add(this.radioDG);
            this.materialCard1.Controls.Add(this.sourceBox);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.passShow);
            this.materialCard1.Controls.Add(this.exitButton);
            this.materialCard1.Controls.Add(this.userBox);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.loginButton);
            this.materialCard1.Controls.Add(this.passBox);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(202, 102);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(419, 331);
            this.materialCard1.TabIndex = 9;
            // 
            // sourceBox
            // 
            this.sourceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sourceBox.Depth = 0;
            this.sourceBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.sourceBox.LeadingIcon = null;
            this.sourceBox.Location = new System.Drawing.Point(118, 73);
            this.sourceBox.MaxLength = 50;
            this.sourceBox.MouseState = MaterialSkin.MouseState.OUT;
            this.sourceBox.Multiline = false;
            this.sourceBox.Name = "sourceBox";
            this.sourceBox.Size = new System.Drawing.Size(272, 50);
            this.sourceBox.TabIndex = 10;
            this.sourceBox.Text = "";
            this.sourceBox.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(24, 104);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(88, 19);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Data Source";
            // 
            // passShow
            // 
            this.passShow.AutoSize = true;
            this.passShow.Depth = 0;
            this.passShow.Location = new System.Drawing.Point(118, 238);
            this.passShow.Margin = new System.Windows.Forms.Padding(0);
            this.passShow.MouseLocation = new System.Drawing.Point(-1, -1);
            this.passShow.MouseState = MaterialSkin.MouseState.HOVER;
            this.passShow.Name = "passShow";
            this.passShow.Ripple = true;
            this.passShow.Size = new System.Drawing.Size(183, 37);
            this.passShow.TabIndex = 8;
            this.passShow.Text = "Hiển thị mật khẩu";
            this.passShow.UseVisualStyleBackColor = true;
            this.passShow.CheckedChanged += new System.EventHandler(this.passShow_CheckedChanged);
            // 
            // radioDG
            // 
            this.radioDG.AutoSize = true;
            this.radioDG.Checked = true;
            this.radioDG.Depth = 0;
            this.radioDG.Location = new System.Drawing.Point(14, 14);
            this.radioDG.Margin = new System.Windows.Forms.Padding(0);
            this.radioDG.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioDG.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioDG.Name = "radioDG";
            this.radioDG.Ripple = true;
            this.radioDG.Size = new System.Drawing.Size(91, 37);
            this.radioDG.TabIndex = 10;
            this.radioDG.TabStop = true;
            this.radioDG.Text = "Độc Giả";
            this.radioDG.UseVisualStyleBackColor = true;
            // 
            // radioNV
            // 
            this.radioNV.AutoSize = true;
            this.radioNV.Depth = 0;
            this.radioNV.Location = new System.Drawing.Point(140, 14);
            this.radioNV.Margin = new System.Windows.Forms.Padding(0);
            this.radioNV.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioNV.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioNV.Name = "radioNV";
            this.radioNV.Ripple = true;
            this.radioNV.Size = new System.Drawing.Size(108, 37);
            this.radioNV.TabIndex = 11;
            this.radioNV.TabStop = true;
            this.radioNV.Text = "Nhân Viên";
            this.radioNV.UseVisualStyleBackColor = true;
            // 
            // radioAD
            // 
            this.radioAD.AutoSize = true;
            this.radioAD.Depth = 0;
            this.radioAD.Location = new System.Drawing.Point(283, 14);
            this.radioAD.Margin = new System.Windows.Forms.Padding(0);
            this.radioAD.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioAD.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioAD.Name = "radioAD";
            this.radioAD.Ripple = true;
            this.radioAD.Size = new System.Drawing.Size(81, 37);
            this.radioAD.TabIndex = 12;
            this.radioAD.TabStop = true;
            this.radioAD.Text = "Admin";
            this.radioAD.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.materialCard1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox userBox;
        private MaterialSkin.Controls.MaterialTextBox passBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton loginButton;
        private MaterialSkin.Controls.MaterialButton registerButton;
        private MaterialSkin.Controls.MaterialButton exitButton;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialSwitch passShow;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        public MaterialSkin.Controls.MaterialTextBox sourceBox;
        private MaterialSkin.Controls.MaterialRadioButton radioAD;
        private MaterialSkin.Controls.MaterialRadioButton radioNV;
        private MaterialSkin.Controls.MaterialRadioButton radioDG;
    }
}