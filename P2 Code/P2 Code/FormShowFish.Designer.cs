namespace P2_Code
{
    partial class FormShowFish
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
            this.fishName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fishName
            // 
            this.fishName.Location = new System.Drawing.Point(0, 0);
            this.fishName.Name = "fishName";
            this.fishName.Size = new System.Drawing.Size(100, 20);
            this.fishName.TabIndex = 0;
            this.fishName.Text = "Yeet";
            this.fishName.TextChanged += new System.EventHandler(this.FishName_TextChanged);
            // 
            // FormShowFish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fishName);
            this.Name = "FormShowFish";
            this.Text = "FormShowFish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fishName;
    }
}