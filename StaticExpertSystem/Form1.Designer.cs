
namespace StaticExpertSystem
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.littleKidsBox = new System.Windows.Forms.CheckBox();
            this.allergyBox = new System.Windows.Forms.CheckBox();
            this.spaceBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.goalBox = new System.Windows.Forms.ComboBox();
            this.lifestyleBox = new System.Windows.Forms.CheckBox();
            this.timeBox = new System.Windows.Forms.CheckBox();
            this.sizeBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bakery", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(412, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pet Advisor";
            // 
            // littleKidsBox
            // 
            this.littleKidsBox.AutoSize = true;
            this.littleKidsBox.Location = new System.Drawing.Point(82, 257);
            this.littleKidsBox.Name = "littleKidsBox";
            this.littleKidsBox.Size = new System.Drawing.Size(200, 24);
            this.littleKidsBox.TabIndex = 1;
            this.littleKidsBox.Text = "5. Do you have little kids?";
            this.littleKidsBox.UseVisualStyleBackColor = true;
            // 
            // allergyBox
            // 
            this.allergyBox.AutoSize = true;
            this.allergyBox.Location = new System.Drawing.Point(82, 197);
            this.allergyBox.Name = "allergyBox";
            this.allergyBox.Size = new System.Drawing.Size(185, 24);
            this.allergyBox.TabIndex = 2;
            this.allergyBox.Text = "3. Do you have allergy?";
            this.allergyBox.UseVisualStyleBackColor = true;
            // 
            // spaceBox
            // 
            this.spaceBox.AutoSize = true;
            this.spaceBox.Location = new System.Drawing.Point(82, 287);
            this.spaceBox.Name = "spaceBox";
            this.spaceBox.Size = new System.Drawing.Size(320, 24);
            this.spaceBox.TabIndex = 3;
            this.spaceBox.Text = "6. Does your house/flat have a lot of space?";
            this.spaceBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "1. What is the purpose of your potential pet?";
            // 
            // goalBox
            // 
            this.goalBox.FormattingEnabled = true;
            this.goalBox.Items.AddRange(new object[] {
            "Guard",
            "Mouse Hunter",
            "For Pleasure"});
            this.goalBox.Location = new System.Drawing.Point(82, 124);
            this.goalBox.Name = "goalBox";
            this.goalBox.Size = new System.Drawing.Size(151, 28);
            this.goalBox.TabIndex = 6;
            this.goalBox.Text = "Guard";
            // 
            // lifestyleBox
            // 
            this.lifestyleBox.AutoSize = true;
            this.lifestyleBox.Location = new System.Drawing.Point(82, 167);
            this.lifestyleBox.Name = "lifestyleBox";
            this.lifestyleBox.Size = new System.Drawing.Size(254, 24);
            this.lifestyleBox.TabIndex = 7;
            this.lifestyleBox.Text = "2. Do you have an active lifestyle?";
            this.lifestyleBox.UseVisualStyleBackColor = true;
            // 
            // timeBox
            // 
            this.timeBox.AutoSize = true;
            this.timeBox.Location = new System.Drawing.Point(82, 227);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(252, 24);
            this.timeBox.TabIndex = 8;
            this.timeBox.Text = "4. Do you have a lot of free time?";
            this.timeBox.UseVisualStyleBackColor = true;
            // 
            // sizeBox
            // 
            this.sizeBox.FormattingEnabled = true;
            this.sizeBox.Items.AddRange(new object[] {
            "Large",
            "Medium",
            "Small"});
            this.sizeBox.Location = new System.Drawing.Point(82, 346);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(151, 28);
            this.sizeBox.TabIndex = 10;
            this.sizeBox.Text = "Large";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "7. What is the desired size of your potentional pet?";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(82, 393);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(94, 29);
            this.submitButton.TabIndex = 11;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(82, 429);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 20);
            this.resultLabel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 872);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.lifestyleBox);
            this.Controls.Add(this.goalBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spaceBox);
            this.Controls.Add(this.allergyBox);
            this.Controls.Add(this.littleKidsBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox littleKidsBox;
        private System.Windows.Forms.CheckBox allergyBox;
        private System.Windows.Forms.CheckBox spaceBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox goalBox;
        private System.Windows.Forms.CheckBox lifestyleBox;
        private System.Windows.Forms.CheckBox timeBox;
        private System.Windows.Forms.ComboBox sizeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label resultLabel;
    }
}

