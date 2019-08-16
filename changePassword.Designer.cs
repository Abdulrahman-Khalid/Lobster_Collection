namespace WindowsFormsApp6
{
    partial class changePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changePassword));
            this.adminPass = new System.Windows.Forms.TextBox();
            this.currUserPass = new System.Windows.Forms.TextBox();
            this.newUserPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmNewUserPass = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminPass
            // 
            this.adminPass.Location = new System.Drawing.Point(328, 69);
            this.adminPass.Name = "adminPass";
            this.adminPass.Size = new System.Drawing.Size(253, 24);
            this.adminPass.TabIndex = 0;
            // 
            // currUserPass
            // 
            this.currUserPass.Location = new System.Drawing.Point(328, 136);
            this.currUserPass.Name = "currUserPass";
            this.currUserPass.Size = new System.Drawing.Size(253, 24);
            this.currUserPass.TabIndex = 1;
            // 
            // newUserPass
            // 
            this.newUserPass.Location = new System.Drawing.Point(328, 204);
            this.newUserPass.Name = "newUserPass";
            this.newUserPass.Size = new System.Drawing.Size(253, 24);
            this.newUserPass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(119, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "كلمة مرور الادمن";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChangePassword.Location = new System.Drawing.Point(341, 321);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(223, 53);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "تغير كلمة المرور";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(101, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "كلمة المرور الحالية";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(42, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "تأكيد كلمة المرور الحديثة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(97, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 35);
            this.label4.TabIndex = 8;
            this.label4.Text = "كلمة المرور الحديثة";
            // 
            // confirmNewUserPass
            // 
            this.confirmNewUserPass.Location = new System.Drawing.Point(328, 271);
            this.confirmNewUserPass.Name = "confirmNewUserPass";
            this.confirmNewUserPass.Size = new System.Drawing.Size(253, 24);
            this.confirmNewUserPass.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Location = new System.Drawing.Point(88, 321);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(223, 53);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "الرجوع";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // changePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 442);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.confirmNewUserPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newUserPass);
            this.Controls.Add(this.currUserPass);
            this.Controls.Add(this.adminPass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "changePassword";
            this.Text = "حصر الاستاكوزا";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adminPass;
        private System.Windows.Forms.TextBox currUserPass;
        private System.Windows.Forms.TextBox newUserPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirmNewUserPass;
        private System.Windows.Forms.Button btnBack;
    }
}