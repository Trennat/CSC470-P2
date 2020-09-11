namespace P2_Code
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
            this.radioCrappie = new System.Windows.Forms.RadioButton();
            this.radioPerch = new System.Windows.Forms.RadioButton();
            this.radioWalleye = new System.Windows.Forms.RadioButton();
            this.ChooseText = new System.Windows.Forms.Label();
            this.SeeFish = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioCrappie
            // 
            this.radioCrappie.AutoSize = true;
            this.radioCrappie.Location = new System.Drawing.Point(80, 82);
            this.radioCrappie.Name = "radioCrappie";
            this.radioCrappie.Size = new System.Drawing.Size(61, 17);
            this.radioCrappie.TabIndex = 0;
            this.radioCrappie.TabStop = true;
            this.radioCrappie.Text = "Crappie";
            this.radioCrappie.UseVisualStyleBackColor = true;
            this.radioCrappie.CheckedChanged += new System.EventHandler(this.RadioCrappie_CheckedChanged);
            // 
            // radioPerch
            // 
            this.radioPerch.AutoSize = true;
            this.radioPerch.Location = new System.Drawing.Point(80, 112);
            this.radioPerch.Name = "radioPerch";
            this.radioPerch.Size = new System.Drawing.Size(53, 17);
            this.radioPerch.TabIndex = 1;
            this.radioPerch.TabStop = true;
            this.radioPerch.Text = "Perch";
            this.radioPerch.UseVisualStyleBackColor = true;
            // 
            // radioWalleye
            // 
            this.radioWalleye.AutoSize = true;
            this.radioWalleye.Location = new System.Drawing.Point(80, 145);
            this.radioWalleye.Name = "radioWalleye";
            this.radioWalleye.Size = new System.Drawing.Size(63, 17);
            this.radioWalleye.TabIndex = 2;
            this.radioWalleye.TabStop = true;
            this.radioWalleye.Text = "Walleye";
            this.radioWalleye.UseVisualStyleBackColor = true;
            // 
            // ChooseText
            // 
            this.ChooseText.AutoSize = true;
            this.ChooseText.Location = new System.Drawing.Point(60, 44);
            this.ChooseText.Name = "ChooseText";
            this.ChooseText.Size = new System.Drawing.Size(103, 13);
            this.ChooseText.TabIndex = 3;
            this.ChooseText.Text = "Choose a fish to see";
            // 
            // SeeFish
            // 
            this.SeeFish.Location = new System.Drawing.Point(171, 176);
            this.SeeFish.Name = "SeeFish";
            this.SeeFish.Size = new System.Drawing.Size(75, 23);
            this.SeeFish.TabIndex = 4;
            this.SeeFish.Text = "See Fish";
            this.SeeFish.UseVisualStyleBackColor = true;
            this.SeeFish.Click += new System.EventHandler(this.SeeFish_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "yeet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(272, 218);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SeeFish);
            this.Controls.Add(this.ChooseText);
            this.Controls.Add(this.radioWalleye);
            this.Controls.Add(this.radioPerch);
            this.Controls.Add(this.radioCrappie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioCrappie;
        private System.Windows.Forms.RadioButton radioPerch;
        private System.Windows.Forms.RadioButton radioWalleye;
        private System.Windows.Forms.Label ChooseText;
        private System.Windows.Forms.Button SeeFish;
        private System.Windows.Forms.TextBox textBox1;
    }
}

