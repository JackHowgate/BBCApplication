namespace BBCGameOfLife
{
    partial class StartupForm
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
            this.seedBox = new System.Windows.Forms.TextBox();
            this.generateSeedButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // seedBox
            // 
            this.seedBox.Location = new System.Drawing.Point(12, 102);
            this.seedBox.Name = "seedBox";
            this.seedBox.Size = new System.Drawing.Size(428, 20);
            this.seedBox.TabIndex = 0;
            // 
            // generateSeedButton
            // 
            this.generateSeedButton.Location = new System.Drawing.Point(153, 136);
            this.generateSeedButton.Name = "generateSeedButton";
            this.generateSeedButton.Size = new System.Drawing.Size(146, 54);
            this.generateSeedButton.TabIndex = 1;
            this.generateSeedButton.Text = "Generate Seed";
            this.generateSeedButton.UseVisualStyleBackColor = true;
            this.generateSeedButton.Click += new System.EventHandler(this.generateSeedButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(153, 199);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(146, 54);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(77, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(298, 55);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Game of Life";
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(63, 68);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(326, 25);
            this.instructionLabel.TabIndex = 4;
            this.instructionLabel.Text = "Please enter or generate a seed:";
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 262);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.generateSeedButton);
            this.Controls.Add(this.seedBox);
            this.Name = "StartupForm";
            this.Text = "StartupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox seedBox;
        private System.Windows.Forms.Button generateSeedButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label instructionLabel;
    }
}