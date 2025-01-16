namespace Booky_App
{
    partial class username
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
            usernameBox.PlaceholderText = "Enter Username";
            passwordBox.PlaceholderText = "Enter Password";
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
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // usernameBox
            // 
            usernameBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usernameBox.BackColor = SystemColors.Window;
            usernameBox.Location = new Point(12, 61);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(235, 27);
            usernameBox.TabIndex = 0;
            usernameBox.TextChanged += textBox1_TextChanged;
            // 
            // passwordBox
            // 
            passwordBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordBox.Location = new Point(12, 94);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(235, 27);
            passwordBox.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(12, 127);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 2;
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += button1_Click;
            // 
            // username
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(724, 450);
            Controls.Add(btnSubmit);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            Name = "username";
            Text = "Create Account";
            Load += CreateAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameBox;
        private TextBox passwordBox;
        private Button btnSubmit;

    }
}