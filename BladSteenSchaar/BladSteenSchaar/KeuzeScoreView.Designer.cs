namespace BladSteenSchaar
{
    partial class KeuzeScoreView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.keuzeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreWaardeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // keuzeLabel
            // 
            this.keuzeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keuzeLabel.Location = new System.Drawing.Point(30, 61);
            this.keuzeLabel.Name = "keuzeLabel";
            this.keuzeLabel.Size = new System.Drawing.Size(130, 111);
            this.keuzeLabel.TabIndex = 0;
            this.keuzeLabel.Text = "Keuze";
            this.keuzeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.keuzeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            // 
            // scoreWaardeLabel
            // 
            this.scoreWaardeLabel.AutoSize = true;
            this.scoreWaardeLabel.Location = new System.Drawing.Point(114, 193);
            this.scoreWaardeLabel.Name = "scoreWaardeLabel";
            this.scoreWaardeLabel.Size = new System.Drawing.Size(13, 13);
            this.scoreWaardeLabel.TabIndex = 2;
            this.scoreWaardeLabel.Text = "0";
            this.scoreWaardeLabel.Click += new System.EventHandler(this.labelScoreWaarde_Click);
            // 
            // KeuzeScoreView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scoreWaardeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keuzeLabel);
            this.Name = "KeuzeScoreView";
            this.Size = new System.Drawing.Size(310, 230);
            this.Load += new System.EventHandler(this.KeuzeScoreView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label keuzeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreWaardeLabel;
    }
}
