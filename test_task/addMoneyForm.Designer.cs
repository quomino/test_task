
namespace test_task
{
    partial class addMoneyForm
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
            this.addMoneyBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addMoneyButton = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addMoneyBox
            // 
            this.addMoneyBox.Location = new System.Drawing.Point(319, 138);
            this.addMoneyBox.Name = "addMoneyBox";
            this.addMoneyBox.Size = new System.Drawing.Size(100, 23);
            this.addMoneyBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "сколько нужно добавить?";
            // 
            // addMoneyButton
            // 
            this.addMoneyButton.Location = new System.Drawing.Point(268, 207);
            this.addMoneyButton.Name = "addMoneyButton";
            this.addMoneyButton.Size = new System.Drawing.Size(75, 23);
            this.addMoneyButton.TabIndex = 2;
            this.addMoneyButton.Text = "добавить";
            this.addMoneyButton.UseVisualStyleBackColor = true;
            this.addMoneyButton.Click += new System.EventHandler(this.addMoneyButton_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(413, 207);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 3;
            this.back.Text = "назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // addMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.addMoneyButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addMoneyBox);
            this.Name = "addMoneyForm";
            this.Text = "addMoneyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addMoneyBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addMoneyButton;
        private System.Windows.Forms.Button back;
    }
}