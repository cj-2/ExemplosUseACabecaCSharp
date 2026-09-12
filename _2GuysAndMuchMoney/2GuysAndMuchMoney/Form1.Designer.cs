namespace _2GuysAndMuchMoney
{
    partial class Form1
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
            this.joesCashLabel = new System.Windows.Forms.Label();
            this.bobsCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.GiveToJoeButton = new System.Windows.Forms.Button();
            this.ReciveFromBobButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joesCashLabel
            // 
            this.joesCashLabel.AutoSize = true;
            this.joesCashLabel.Location = new System.Drawing.Point(12, 9);
            this.joesCashLabel.Name = "joesCashLabel";
            this.joesCashLabel.Size = new System.Drawing.Size(35, 13);
            this.joesCashLabel.TabIndex = 0;
            this.joesCashLabel.Text = "label1";
            // 
            // bobsCashLabel
            // 
            this.bobsCashLabel.AutoSize = true;
            this.bobsCashLabel.Location = new System.Drawing.Point(12, 31);
            this.bobsCashLabel.Name = "bobsCashLabel";
            this.bobsCashLabel.Size = new System.Drawing.Size(35, 13);
            this.bobsCashLabel.TabIndex = 1;
            this.bobsCashLabel.Text = "label2";
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Location = new System.Drawing.Point(12, 53);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(35, 13);
            this.bankCashLabel.TabIndex = 2;
            this.bankCashLabel.Text = "label3";
            // 
            // GiveToJoeButton
            // 
            this.GiveToJoeButton.Location = new System.Drawing.Point(12, 78);
            this.GiveToJoeButton.Name = "GiveToJoeButton";
            this.GiveToJoeButton.Size = new System.Drawing.Size(100, 40);
            this.GiveToJoeButton.TabIndex = 3;
            this.GiveToJoeButton.Text = "Give R$ 10 to Joe";
            this.GiveToJoeButton.UseVisualStyleBackColor = true;
            this.GiveToJoeButton.Click += new System.EventHandler(this.GiveToJoeButton_Click);
            // 
            // ReciveFromBobButton
            // 
            this.ReciveFromBobButton.Location = new System.Drawing.Point(118, 78);
            this.ReciveFromBobButton.Name = "ReciveFromBobButton";
            this.ReciveFromBobButton.Size = new System.Drawing.Size(100, 40);
            this.ReciveFromBobButton.TabIndex = 4;
            this.ReciveFromBobButton.Text = "Receive R$ 5 from Bob";
            this.ReciveFromBobButton.UseVisualStyleBackColor = true;
            this.ReciveFromBobButton.Click += new System.EventHandler(this.ReciveFromBobButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 130);
            this.Controls.Add(this.ReciveFromBobButton);
            this.Controls.Add(this.GiveToJoeButton);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.bobsCashLabel);
            this.Controls.Add(this.joesCashLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joesCashLabel;
        private System.Windows.Forms.Label bobsCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
        private System.Windows.Forms.Button GiveToJoeButton;
        private System.Windows.Forms.Button ReciveFromBobButton;
    }
}

