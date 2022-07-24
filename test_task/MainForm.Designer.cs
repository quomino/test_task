
namespace test_task
{
    partial class MainForm
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
            this.checkMoney = new System.Windows.Forms.Button();
            this.moneyOut = new System.Windows.Forms.Button();
            this.addMoney = new System.Windows.Forms.Button();
            this.historyOperation = new System.Windows.Forms.Button();
            this.changePW = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkMoney
            // 
            this.checkMoney.Location = new System.Drawing.Point(43, 28);
            this.checkMoney.Name = "checkMoney";
            this.checkMoney.Size = new System.Drawing.Size(125, 23);
            this.checkMoney.TabIndex = 0;
            this.checkMoney.Text = "узнать баланс";
            this.checkMoney.UseVisualStyleBackColor = true;
            this.checkMoney.Click += new System.EventHandler(this.checkMoney_Click);
            // 
            // moneyOut
            // 
            this.moneyOut.Location = new System.Drawing.Point(43, 57);
            this.moneyOut.Name = "moneyOut";
            this.moneyOut.Size = new System.Drawing.Size(125, 23);
            this.moneyOut.TabIndex = 1;
            this.moneyOut.Text = "снять наличные";
            this.moneyOut.UseVisualStyleBackColor = true;
            this.moneyOut.Click += new System.EventHandler(this.moneyOut_Click);
            // 
            // addMoney
            // 
            this.addMoney.Location = new System.Drawing.Point(43, 86);
            this.addMoney.Name = "addMoney";
            this.addMoney.Size = new System.Drawing.Size(125, 23);
            this.addMoney.TabIndex = 2;
            this.addMoney.Text = "пополнить счет";
            this.addMoney.UseVisualStyleBackColor = true;
            this.addMoney.Click += new System.EventHandler(this.addMoney_Click);
            // 
            // historyOperation
            // 
            this.historyOperation.Location = new System.Drawing.Point(43, 115);
            this.historyOperation.Name = "historyOperation";
            this.historyOperation.Size = new System.Drawing.Size(125, 50);
            this.historyOperation.TabIndex = 3;
            this.historyOperation.Text = "показать историю операций";
            this.historyOperation.UseVisualStyleBackColor = true;
            // 
            // changePW
            // 
            this.changePW.Location = new System.Drawing.Point(43, 171);
            this.changePW.Name = "changePW";
            this.changePW.Size = new System.Drawing.Size(125, 23);
            this.changePW.TabIndex = 4;
            this.changePW.Text = "сменить пароль";
            this.changePW.UseVisualStyleBackColor = true;
            this.changePW.Click += new System.EventHandler(this.changePW_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changePW);
            this.Controls.Add(this.historyOperation);
            this.Controls.Add(this.addMoney);
            this.Controls.Add(this.moneyOut);
            this.Controls.Add(this.checkMoney);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkMoney;
        private System.Windows.Forms.Button moneyOut;
        private System.Windows.Forms.Button addMoney;
        private System.Windows.Forms.Button historyOperation;
        private System.Windows.Forms.Button changePW;
    }
}