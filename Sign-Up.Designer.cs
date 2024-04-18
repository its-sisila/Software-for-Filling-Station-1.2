namespace Software_for_Filling_Station
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
            this.fNameLebel = new System.Windows.Forms.Label();
            this.lNameLebel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLebel = new System.Windows.Forms.Label();
            this.fNameText = new System.Windows.Forms.TextBox();
            this.lNameText = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.confirmPassText = new System.Windows.Forms.TextBox();
            this.confirmPassLebel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.positionText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fNameLebel
            // 
            this.fNameLebel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fNameLebel.AutoSize = true;
            this.fNameLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLebel.Location = new System.Drawing.Point(104, 66);
            this.fNameLebel.Name = "fNameLebel";
            this.fNameLebel.Size = new System.Drawing.Size(107, 22);
            this.fNameLebel.TabIndex = 0;
            this.fNameLebel.Text = "First Name";
            this.fNameLebel.Click += new System.EventHandler(this.fNameLebel_Click);
            // 
            // lNameLebel
            // 
            this.lNameLebel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lNameLebel.AutoSize = true;
            this.lNameLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameLebel.Location = new System.Drawing.Point(104, 119);
            this.lNameLebel.Name = "lNameLebel";
            this.lNameLebel.Size = new System.Drawing.Size(105, 22);
            this.lNameLebel.TabIndex = 1;
            this.lNameLebel.Text = "Last Name";
            this.lNameLebel.Click += new System.EventHandler(this.lNameLebel_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(104, 275);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(100, 22);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // passwordLebel
            // 
            this.passwordLebel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLebel.AutoSize = true;
            this.passwordLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLebel.Location = new System.Drawing.Point(104, 330);
            this.passwordLebel.Name = "passwordLebel";
            this.passwordLebel.Size = new System.Drawing.Size(97, 22);
            this.passwordLebel.TabIndex = 3;
            this.passwordLebel.Text = "Password";
            this.passwordLebel.Click += new System.EventHandler(this.label3_Click);
            // 
            // fNameText
            // 
            this.fNameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameText.Location = new System.Drawing.Point(356, 66);
            this.fNameText.Name = "fNameText";
            this.fNameText.Size = new System.Drawing.Size(341, 30);
            this.fNameText.TabIndex = 4;
            this.fNameText.TextChanged += new System.EventHandler(this.fNameText_TextChanged);
            // 
            // lNameText
            // 
            this.lNameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameText.Location = new System.Drawing.Point(356, 119);
            this.lNameText.Name = "lNameText";
            this.lNameText.Size = new System.Drawing.Size(341, 30);
            this.lNameText.TabIndex = 5;
            // 
            // usernameText
            // 
            this.usernameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.Location = new System.Drawing.Point(356, 275);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(341, 30);
            this.usernameText.TabIndex = 6;
            this.usernameText.TextChanged += new System.EventHandler(this.usernameText_TextChanged);
            // 
            // passwordText
            // 
            this.passwordText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.Location = new System.Drawing.Point(356, 325);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(341, 30);
            this.passwordText.TabIndex = 7;
            this.passwordText.TextChanged += new System.EventHandler(this.passwordText_TextChanged);
            // 
            // confirmPassText
            // 
            this.confirmPassText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmPassText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassText.Location = new System.Drawing.Point(356, 371);
            this.confirmPassText.Name = "confirmPassText";
            this.confirmPassText.Size = new System.Drawing.Size(341, 30);
            this.confirmPassText.TabIndex = 8;
            // 
            // confirmPassLebel
            // 
            this.confirmPassLebel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmPassLebel.AutoSize = true;
            this.confirmPassLebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassLebel.Location = new System.Drawing.Point(104, 379);
            this.confirmPassLebel.Name = "confirmPassLebel";
            this.confirmPassLebel.Size = new System.Drawing.Size(172, 22);
            this.confirmPassLebel.TabIndex = 9;
            this.confirmPassLebel.Text = "Confirm Password";
            this.confirmPassLebel.Click += new System.EventHandler(this.confirmPassLebel_Click);
            // 
            // submitButton
            // 
            this.submitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(257, 433);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(102, 38);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(498, 433);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(102, 38);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(104, 171);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(217, 22);
            this.idLabel.TabIndex = 12;
            this.idLabel.Text = "Employee/ Employer ID";
            // 
            // idText
            // 
            this.idText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idText.Location = new System.Drawing.Point(356, 170);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(341, 30);
            this.idText.TabIndex = 13;
            // 
            // positionLabel
            // 
            this.positionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLabel.Location = new System.Drawing.Point(104, 222);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(82, 22);
            this.positionLabel.TabIndex = 14;
            this.positionLabel.Text = "Position";
            // 
            // positionText
            // 
            this.positionText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.positionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionText.Location = new System.Drawing.Point(356, 222);
            this.positionText.Name = "positionText";
            this.positionText.Size = new System.Drawing.Size(341, 30);
            this.positionText.TabIndex = 8;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(818, 527);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.confirmPassLebel);
            this.Controls.Add(this.positionText);
            this.Controls.Add(this.confirmPassText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.lNameText);
            this.Controls.Add(this.fNameText);
            this.Controls.Add(this.passwordLebel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.lNameLebel);
            this.Controls.Add(this.fNameLebel);
            this.Name = "Register";
            this.ShowIcon = false;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fNameLebel;
        private System.Windows.Forms.Label lNameLebel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLebel;
        private System.Windows.Forms.TextBox fNameText;
        private System.Windows.Forms.TextBox lNameText;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox confirmPassText;
        private System.Windows.Forms.Label confirmPassLebel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.TextBox positionText;
    }
}