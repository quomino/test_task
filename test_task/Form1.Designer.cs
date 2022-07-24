
namespace test_task
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
            this.buttonAutorization = new System.Windows.Forms.Button();
            this.buttonReg = new System.Windows.Forms.Button();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAutorization
            // 
            this.buttonAutorization.Location = new System.Drawing.Point(358, 239);
            this.buttonAutorization.Name = "buttonAutorization";
            this.buttonAutorization.Size = new System.Drawing.Size(65, 28);
            this.buttonAutorization.TabIndex = 0;
            this.buttonAutorization.Text = "войти";
            this.buttonAutorization.UseVisualStyleBackColor = true;
            this.buttonAutorization.Click += new System.EventHandler(this.buttonAutorization_Click);
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(341, 273);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(98, 28);
            this.buttonReg.TabIndex = 1;
            this.buttonReg.Text = "регистрация";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(307, 138);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(183, 23);
            this.loginField.TabIndex = 2;
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // passField
            // 
            this.passField.Location = new System.Drawing.Point(307, 187);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(183, 23);
            this.passField.TabIndex = 3;
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.Leave += new System.EventHandler(this.passField_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.buttonAutorization);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAutorization;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passField;
    }
}

