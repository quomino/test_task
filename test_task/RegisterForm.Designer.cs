
namespace test_task
{
    partial class RegisterForm
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
            this.reg = new System.Windows.Forms.Button();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reg
            // 
            this.reg.Location = new System.Drawing.Point(330, 261);
            this.reg.Name = "reg";
            this.reg.Size = new System.Drawing.Size(127, 23);
            this.reg.TabIndex = 0;
            this.reg.Text = "зарегистртровать";
            this.reg.UseVisualStyleBackColor = true;
            this.reg.Click += new System.EventHandler(this.reg_Click);
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(330, 114);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(127, 23);
            this.loginField.TabIndex = 1;
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // passField
            // 
            this.passField.Location = new System.Drawing.Point(330, 143);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(127, 23);
            this.passField.TabIndex = 2;
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.Leave += new System.EventHandler(this.passField_Leave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(365, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.reg);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reg;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Button button2;
    }
}