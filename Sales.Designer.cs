namespace Software_for_Filling_Station
{
    partial class Sales
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
            this.pumpLP92_1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pumpLP92_1
            // 
            this.pumpLP92_1.Location = new System.Drawing.Point(118, 102);
            this.pumpLP92_1.Name = "pumpLP92_1";
            this.pumpLP92_1.Size = new System.Drawing.Size(183, 134);
            this.pumpLP92_1.TabIndex = 0;
            this.pumpLP92_1.Paint += new System.Windows.Forms.PaintEventHandler(this.pumpLP92_1_Paint);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 985);
            this.Controls.Add(this.pumpLP92_1);
            this.Name = "Sales";
            this.Text = "Sales";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pumpLP92_1;
    }
}