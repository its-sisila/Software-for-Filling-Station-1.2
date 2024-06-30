namespace Software_for_Filling_Station
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
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.registerLink = new System.Windows.Forms.LinkLabel();
            this.forPassLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameText
            // 
            this.usernameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usernameText.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.Location = new System.Drawing.Point(277, 129);
            this.usernameText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(314, 32);
            this.usernameText.TabIndex = 0;
            this.usernameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordText
            // 
            this.passwordText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passwordText.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.Location = new System.Drawing.Point(277, 196);
            this.passwordText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(314, 32);
            this.passwordText.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usernameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(94, 135);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(114, 26);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passwordLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(94, 202);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(105, 26);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // submitButton
            // 
            this.submitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(277, 289);
            this.submitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(138, 39);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Login";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(473, 289);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(128, 39);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // registerLink
            // 
            this.registerLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerLink.AutoSize = true;
            this.registerLink.BackColor = System.Drawing.Color.WhiteSmoke;
            this.registerLink.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLink.LinkColor = System.Drawing.Color.Brown;
            this.registerLink.Location = new System.Drawing.Point(168, 387);
            this.registerLink.Name = "registerLink";
            this.registerLink.Size = new System.Drawing.Size(185, 23);
            this.registerLink.TabIndex = 7;
            this.registerLink.TabStop = true;
            this.registerLink.Text = "Create an Account?";
            this.registerLink.VisitedLinkColor = System.Drawing.Color.Red;
            this.registerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLink_LinkClicked);
            // 
            // forPassLinkLabel
            // 
            this.forPassLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forPassLinkLabel.AutoSize = true;
            this.forPassLinkLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.forPassLinkLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forPassLinkLabel.LinkColor = System.Drawing.Color.Navy;
            this.forPassLinkLabel.Location = new System.Drawing.Point(469, 387);
            this.forPassLinkLabel.Name = "forPassLinkLabel";
            this.forPassLinkLabel.Size = new System.Drawing.Size(179, 23);
            this.forPassLinkLabel.TabIndex = 8;
            this.forPassLinkLabel.TabStop = true;
            this.forPassLinkLabel.Text = "Change Password?";
            this.forPassLinkLabel.VisitedLinkColor = System.Drawing.Color.Red;
            this.forPassLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forPassLinkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Management System Software For Filling Station";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.usernameText);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.passwordText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.resetButton);
            this.panel1.Controls.Add(this.forPassLinkLabel);
            this.panel1.Controls.Add(this.submitButton);
            this.panel1.Controls.Add(this.registerLink);
            this.panel1.Location = new System.Drawing.Point(440, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 464);
            this.panel1.TabIndex = 11;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1924, 977);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.LinkLabel registerLink;
        private System.Windows.Forms.LinkLabel forPassLinkLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

