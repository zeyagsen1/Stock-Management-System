namespace InventoryManagementSystem
{
    partial class forgot_password
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
            this.components = new System.ComponentModel.Container();
            this.update_password = new System.Windows.Forms.Button();
            this.code = new System.Windows.Forms.TextBox();
            this.mailText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.confirm = new System.Windows.Forms.Button();
            this.username_text = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.new_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // update_password
            // 
            this.update_password.Location = new System.Drawing.Point(217, 255);
            this.update_password.Name = "update_password";
            this.update_password.Size = new System.Drawing.Size(158, 23);
            this.update_password.TabIndex = 9;
            this.update_password.Text = "Send Verification Code";
            this.update_password.UseVisualStyleBackColor = true;
            this.update_password.Click += new System.EventHandler(this.button1_Click);
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(275, 144);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(100, 22);
            this.code.TabIndex = 7;
            // 
            // mailText
            // 
            this.mailText.Location = new System.Drawing.Point(275, 102);
            this.mailText.Name = "mailText";
            this.mailText.Size = new System.Drawing.Size(100, 22);
            this.mailText.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Verification Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mail Adress";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(416, 255);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(133, 23);
            this.confirm.TabIndex = 10;
            this.confirm.Text = "Confirm Code";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(275, 61);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(100, 22);
            this.username_text.TabIndex = 11;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(138, 67);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(70, 16);
            this.username.TabIndex = 12;
            this.username.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "New Password";
            // 
            // new_password
            // 
            this.new_password.Location = new System.Drawing.Point(275, 185);
            this.new_password.Name = "new_password";
            this.new_password.Size = new System.Drawing.Size(100, 22);
            this.new_password.TabIndex = 7;
            // 
            // forgot_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.username);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.update_password);
            this.Controls.Add(this.new_password);
            this.Controls.Add(this.code);
            this.Controls.Add(this.mailText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "forgot_password";
            this.Text = "forgot_password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update_password;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.TextBox mailText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox new_password;
    }
}