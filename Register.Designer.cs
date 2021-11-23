
namespace LibraryManagement
{
    partial class Register
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
            this.returnButton = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.passShow = new MaterialSkin.Controls.MaterialSwitch();
            this.exitButton = new MaterialSkin.Controls.MaterialButton();
            this.userBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.registerButton = new MaterialSkin.Controls.MaterialButton();
            this.passBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.confirmBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.returnButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.returnButton.Depth = 0;
            this.returnButton.HighEmphasis = true;
            this.returnButton.Icon = null;
            this.returnButton.Location = new System.Drawing.Point(7, 94);
            this.returnButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.returnButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(85, 36);
            this.returnButton.TabIndex = 0;
            this.returnButton.Text = "QUAY LẠI";
            this.returnButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.returnButton.UseAccentColor = false;
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.confirmBox);
            this.materialCard1.Controls.Add(this.passShow);
            this.materialCard1.Controls.Add(this.exitButton);
            this.materialCard1.Controls.Add(this.userBox);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.registerButton);
            this.materialCard1.Controls.Add(this.passBox);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(201, 107);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(419, 308);
            this.materialCard1.TabIndex = 10;
            // 
            // passShow
            // 
            this.passShow.AutoSize = true;
            this.passShow.Depth = 0;
            this.passShow.Location = new System.Drawing.Point(117, 197);
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
            // exitButton
            // 
            this.exitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.exitButton.Depth = 0;
            this.exitButton.HighEmphasis = true;
            this.exitButton.Icon = null;
            this.exitButton.Location = new System.Drawing.Point(117, 240);
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
            // userBox
            // 
            this.userBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userBox.Depth = 0;
            this.userBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userBox.LeadingIcon = null;
            this.userBox.Location = new System.Drawing.Point(117, 32);
            this.userBox.MaxLength = 50;
            this.userBox.MouseState = MaterialSkin.MouseState.OUT;
            this.userBox.Multiline = false;
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(272, 50);
            this.userBox.TabIndex = 1;
            this.userBox.Text = "";
            this.userBox.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(23, 63);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(74, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Tài Khoản";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(23, 119);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(70, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Mật Khẩu";
            // 
            // registerButton
            // 
            this.registerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.registerButton.Depth = 0;
            this.registerButton.HighEmphasis = true;
            this.registerButton.Icon = null;
            this.registerButton.Location = new System.Drawing.Point(310, 240);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(79, 36);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "ĐĂNG KÍ";
            this.registerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.registerButton.UseAccentColor = false;
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // passBox
            // 
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passBox.Depth = 0;
            this.passBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passBox.LeadingIcon = null;
            this.passBox.Location = new System.Drawing.Point(117, 88);
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
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(23, 175);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(70, 19);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Xác Nhận";
            // 
            // confirmBox
            // 
            this.confirmBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.confirmBox.Depth = 0;
            this.confirmBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.confirmBox.LeadingIcon = null;
            this.confirmBox.Location = new System.Drawing.Point(117, 144);
            this.confirmBox.MaxLength = 50;
            this.confirmBox.MouseState = MaterialSkin.MouseState.OUT;
            this.confirmBox.Multiline = false;
            this.confirmBox.Name = "confirmBox";
            this.confirmBox.Password = true;
            this.confirmBox.Size = new System.Drawing.Size(272, 50);
            this.confirmBox.TabIndex = 10;
            this.confirmBox.Text = "";
            this.confirmBox.TrailingIcon = null;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.returnButton);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_64;
            this.Name = "Register";
            this.Padding = new System.Windows.Forms.Padding(3, 88, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
           
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton returnButton;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialSwitch passShow;
        private MaterialSkin.Controls.MaterialButton exitButton;
        private MaterialSkin.Controls.MaterialTextBox userBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton registerButton;
        private MaterialSkin.Controls.MaterialTextBox passBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox confirmBox;
    }
}