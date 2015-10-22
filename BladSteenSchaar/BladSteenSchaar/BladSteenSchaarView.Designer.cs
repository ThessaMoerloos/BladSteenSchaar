namespace BladSteenSchaar
{
    partial class BladSteenSchaarView
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
            this.titelSpelerLabel = new System.Windows.Forms.Label();
            this.titelComputerLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.dropdown = new System.Windows.Forms.ComboBox();
            this.goButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titelSpelerLabel
            // 
            this.titelSpelerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titelSpelerLabel.Location = new System.Drawing.Point(38, 17);
            this.titelSpelerLabel.Name = "titelSpelerLabel";
            this.titelSpelerLabel.Size = new System.Drawing.Size(100, 23);
            this.titelSpelerLabel.TabIndex = 0;
            this.titelSpelerLabel.Text = "Speler";
            this.titelSpelerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titelSpelerLabel.Click += new System.EventHandler(this.titelSpelerLabel_Click);
            // 
            // titelComputerLabel
            // 
            this.titelComputerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titelComputerLabel.Location = new System.Drawing.Point(354, 17);
            this.titelComputerLabel.Name = "titelComputerLabel";
            this.titelComputerLabel.Size = new System.Drawing.Size(100, 23);
            this.titelComputerLabel.TabIndex = 1;
            this.titelComputerLabel.Text = "Computer";
            this.titelComputerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titelComputerLabel.Click += new System.EventHandler(this.titelComputerLabel_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(27, 242);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(49, 13);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "message";
            this.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.messageLabel.Click += new System.EventHandler(this.messageLabel_Click);
            // 
            // dropdown
            // 
            this.dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown.FormattingEnabled = true;
            this.dropdown.Items.AddRange(new object[] {
            "Blad",
            "Steen",
            "Schaar"});
            this.dropdown.Location = new System.Drawing.Point(30, 274);
            this.dropdown.Name = "dropdown";
            this.dropdown.Size = new System.Drawing.Size(121, 21);
            this.dropdown.TabIndex = 3;
            this.dropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(157, 271);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(38, 26);
            this.goButton.TabIndex = 4;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // BladSteenSchaarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.dropdown);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.titelComputerLabel);
            this.Controls.Add(this.titelSpelerLabel);
            this.Name = "BladSteenSchaarView";
            this.Size = new System.Drawing.Size(551, 336);
            this.Load += new System.EventHandler(this.BladSteenSchaarView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titelSpelerLabel;
        private System.Windows.Forms.Label titelComputerLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.ComboBox dropdown;
        private System.Windows.Forms.Button goButton;
    }
}
