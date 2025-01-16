namespace Booky_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CreateNewProfile = new Button();
            login = new Button();
            SuspendLayout();
            // 
            // CreateNewProfile
            // 
            CreateNewProfile.Anchor = AnchorStyles.None;
            CreateNewProfile.Font = new Font("Source Code Pro", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateNewProfile.ForeColor = Color.Black;
            CreateNewProfile.Location = new Point(247, 205);
            CreateNewProfile.Name = "CreateNewProfile";
            CreateNewProfile.Size = new Size(414, 96);
            CreateNewProfile.TabIndex = 0;
            CreateNewProfile.Text = "Create New Account";
            CreateNewProfile.UseVisualStyleBackColor = true;
            CreateNewProfile.Click += CreateNewProfile_Click;
            // 
            // login
            // 
            login.Anchor = AnchorStyles.None;
            login.Font = new Font("Source Code Pro", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login.ForeColor = Color.Black;
            login.Location = new Point(299, 307);
            login.Name = "login";
            login.Size = new Size(305, 58);
            login.TabIndex = 1;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(891, 502);
            Controls.Add(login);
            Controls.Add(CreateNewProfile);
            Font = new Font("Source Code Pro", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Snow;
            Name = "Form1";
            Text = "Booky";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button CreateNewProfile;
        private Button login;
    }
}
