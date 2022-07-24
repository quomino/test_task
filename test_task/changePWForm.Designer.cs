
namespace test_task
{
    partial class changePWForm
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
            this.changePWButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.oldPWBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newPWBox = new System.Windows.Forms.TextBox();
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
            // changePWButton
            // 
            this.changePWButton.Location = new System.Drawing.Point(290, 257);
            this.changePWButton.Name = "changePWButton";
            this.changePWButton.Size = new System.Drawing.Size(75, 23);
            this.changePWButton.TabIndex = 6;
            this.changePWButton.Text = "сменить";
            this.changePWButton.UseVisualStyleBackColor = true;
            this.changePWButton.Click += new System.EventHandler(this.changePWButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "введите старый пароль";
            // 
            // oldPWBox
            // 
            this.oldPWBox.Location = new System.Drawing.Point(277, 185);
            this.oldPWBox.Name = "oldPWBox";
            this.oldPWBox.Size = new System.Drawing.Size(100, 23);
            this.oldPWBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "введите новый пароль";
            // 
            // newPWBox
            // 
            this.newPWBox.Location = new System.Drawing.Point(423, 185);
            this.newPWBox.Name = "newPWBox";
            this.newPWBox.Size = new System.Drawing.Size(100, 23);
            this.newPWBox.TabIndex = 8;
            // 
            // changePWForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newPWBox);
            this.Controls.Add(this.back);
            this.Controls.Add(this.changePWButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oldPWBox);
            this.Name = "changePWForm";
            this.Text = "changePWForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button changePWButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oldPWBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newPWBox;
    }
}