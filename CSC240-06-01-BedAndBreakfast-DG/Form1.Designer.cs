namespace CSC240_06_01_BedAndBreakfast_DG
{
    partial class UxBaileysForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UxWelcomeLabel = new Label();
            UxRateLabel = new Label();
            SuspendLayout();
            // 
            // UxWelcomeLabel
            // 
            UxWelcomeLabel.AutoSize = true;
            UxWelcomeLabel.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UxWelcomeLabel.Location = new Point(98, 57);
            UxWelcomeLabel.Name = "UxWelcomeLabel";
            UxWelcomeLabel.Size = new Size(248, 29);
            UxWelcomeLabel.TabIndex = 0;
            UxWelcomeLabel.Text = "Welcome to Bailey's";
            // 
            // UxRateLabel
            // 
            UxRateLabel.AutoSize = true;
            UxRateLabel.Location = new Point(177, 134);
            UxRateLabel.Name = "UxRateLabel";
            UxRateLabel.Size = new Size(89, 15);
            UxRateLabel.TabIndex = 1;
            UxRateLabel.Text = "Check our rates";
            // 
            // UxBaileysForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(449, 450);
            Controls.Add(UxRateLabel);
            Controls.Add(UxWelcomeLabel);
            Name = "UxBaileysForm";
            Text = "Bailey's Bed and Breakfast";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UxWelcomeLabel;
        private Label UxRateLabel;
    }
}
