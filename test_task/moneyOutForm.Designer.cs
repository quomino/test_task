
namespace test_task
{
    partial class moneyOutForm
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
            this.back = new System.Windows.Forms.Button();
            this.moneyOutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.moneyOutBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(435, 257);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 7;
            this.back.Text = "назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // moneyOutButton
            // 
            this.moneyOutButton.Location = new System.Drawing.Point(290, 257);
            this.moneyOutButton.Name = "moneyOutButton";
            this.moneyOutButton.Size = new System.Drawing.Size(75, 23);
            this.moneyOutButton.TabIndex = 6;
            this.moneyOutButton.Text = "снять";
            this.moneyOutButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "сколько нужно снять?";
            // 
            // moneyOutBox
            // 
            this.moneyOutBox.Location = new System.Drawing.Point(341, 188);
            this.moneyOutBox.Name = "moneyOutBox";
            this.moneyOutBox.Size = new System.Drawing.Size(100, 23);
            this.moneyOutBox.TabIndex = 4;
            this.moneyOutBox.TextChanged += new System.EventHandler(this.moneyOutBox_TextChanged);
            // 
            // moneyOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.moneyOutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moneyOutBox);
            this.Name = "moneyOutForm";
            this.Text = "moneyOutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button moneyOutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox moneyOutBox;
    }
}