
namespace LibraryManagement
{
    partial class Exit
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.noButton = new MaterialSkin.Controls.MaterialButton();
            this.yesButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.noButton);
            this.materialCard1.Controls.Add(this.yesButton);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(278, 100);
            this.materialCard1.TabIndex = 0;
            // 
            // noButton
            // 
            this.noButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.noButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.noButton.Depth = 0;
            this.noButton.HighEmphasis = true;
            this.noButton.Icon = null;
            this.noButton.Location = new System.Drawing.Point(188, 44);
            this.noButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.noButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(72, 36);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "KHÔNG";
            this.noButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.noButton.UseAccentColor = false;
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // yesButton
            // 
            this.yesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.yesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.yesButton.Depth = 0;
            this.yesButton.HighEmphasis = true;
            this.yesButton.Icon = null;
            this.yesButton.Location = new System.Drawing.Point(18, 44);
            this.yesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.yesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(64, 36);
            this.yesButton.TabIndex = 1;
            this.yesButton.Text = "CÓ";
            this.yesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.yesButton.UseAccentColor = false;
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(248, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Bạn chắc chắn muốn thoát không?";
            // 
            // Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 195);
            this.Controls.Add(this.materialCard1);
            this.Name = "Exit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exit";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton noButton;
        private MaterialSkin.Controls.MaterialButton yesButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}