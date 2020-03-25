namespace Twilio_Client___OffScreen
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
            this.lvLog = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.bDial = new System.Windows.Forms.Button();
            this.bDisconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConnectionAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvLog
            // 
            this.lvLog.HideSelection = false;
            this.lvLog.Location = new System.Drawing.Point(184, 80);
            this.lvLog.Name = "lvLog";
            this.lvLog.Size = new System.Drawing.Size(374, 182);
            this.lvLog.TabIndex = 0;
            this.lvLog.UseCompatibleStateImageBehavior = false;
            this.lvLog.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logs";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(184, 346);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.tbPhoneNumber.TabIndex = 2;
            // 
            // bDial
            // 
            this.bDial.Location = new System.Drawing.Point(320, 346);
            this.bDial.Name = "bDial";
            this.bDial.Size = new System.Drawing.Size(75, 23);
            this.bDial.TabIndex = 3;
            this.bDial.Text = "Dial";
            this.bDial.UseVisualStyleBackColor = true;
            this.bDial.Click += new System.EventHandler(this.button1_Click);
            // 
            // bDisconnect
            // 
            this.bDisconnect.Enabled = false;
            this.bDisconnect.Location = new System.Drawing.Point(426, 346);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(75, 23);
            this.bDisconnect.TabIndex = 4;
            this.bDisconnect.Text = "Disconnect";
            this.bDisconnect.UseVisualStyleBackColor = true;
            this.bDisconnect.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number";
            // 
            // lblConnectionAddress
            // 
            this.lblConnectionAddress.AutoSize = true;
            this.lblConnectionAddress.Location = new System.Drawing.Point(122, 26);
            this.lblConnectionAddress.Name = "lblConnectionAddress";
            this.lblConnectionAddress.Size = new System.Drawing.Size(105, 13);
            this.lblConnectionAddress.TabIndex = 6;
            this.lblConnectionAddress.Text = "Connection Address:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblConnectionAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bDisconnect);
            this.Controls.Add(this.bDial);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvLog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Button bDial;
        private System.Windows.Forms.Button bDisconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConnectionAddress;
    }
}

