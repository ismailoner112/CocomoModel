namespace Cocomoform
{
    partial class AnaSayfa
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
            this.Ayrık = new System.Windows.Forms.Button();
            this.YarıGömülü = new System.Windows.Forms.Button();
            this.Gömülü = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ayrık
            // 
            this.Ayrık.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ayrık.Location = new System.Drawing.Point(327, 108);
            this.Ayrık.Name = "Ayrık";
            this.Ayrık.Size = new System.Drawing.Size(144, 29);
            this.Ayrık.TabIndex = 0;
            this.Ayrık.Text = "Ayrık";
            this.Ayrık.UseVisualStyleBackColor = true;
            this.Ayrık.Click += new System.EventHandler(this.button1_Click);
            // 
            // YarıGömülü
            // 
            this.YarıGömülü.Location = new System.Drawing.Point(327, 203);
            this.YarıGömülü.Name = "YarıGömülü";
            this.YarıGömülü.Size = new System.Drawing.Size(144, 29);
            this.YarıGömülü.TabIndex = 1;
            this.YarıGömülü.Text = "Yarı Gömülü";
            this.YarıGömülü.UseVisualStyleBackColor = true;
            this.YarıGömülü.Click += new System.EventHandler(this.button2_Click);
            // 
            // Gömülü
            // 
            this.Gömülü.Location = new System.Drawing.Point(327, 321);
            this.Gömülü.Name = "Gömülü";
            this.Gömülü.Size = new System.Drawing.Size(144, 29);
            this.Gömülü.TabIndex = 2;
            this.Gömülü.Text = "Gömülü";
            this.Gömülü.UseVisualStyleBackColor = true;
            this.Gömülü.Click += new System.EventHandler(this.button3_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Gömülü);
            this.Controls.Add(this.YarıGömülü);
            this.Controls.Add(this.Ayrık);
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Ayrık;
        private Button YarıGömülü;
        private Button Gömülü;
    }
}