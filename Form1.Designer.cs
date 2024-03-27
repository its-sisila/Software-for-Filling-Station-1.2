namespace Software_for_Filling_Station
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(308, 162);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(278, 26);
            this.usernameText.TabIndex = 0;
            this.usernameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(308, 244);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(278, 26);
            this.passwordText.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(170, 162);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(83, 20);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(170, 250);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(78, 20);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(289, 355);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(101, 45);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(464, 353);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(97, 47);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button resetButton;
    }
}

