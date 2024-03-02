namespace TaxiBibki
{
    partial class NewPassword
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
            this.oldPasswordError = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OldPassword = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.newPasswordError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newPasword = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldPasswordError
            // 
            this.oldPasswordError.AutoSize = true;
            this.oldPasswordError.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPasswordError.ForeColor = System.Drawing.Color.Red;
            this.oldPasswordError.Location = new System.Drawing.Point(49, 59);
            this.oldPasswordError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.oldPasswordError.Name = "oldPasswordError";
            this.oldPasswordError.Size = new System.Drawing.Size(184, 17);
            this.oldPasswordError.TabIndex = 115;
            this.oldPasswordError.Text = "Заполните обязательное поле";
            this.oldPasswordError.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 114;
            this.label5.Text = "Старый пароль";
            // 
            // OldPassword
            // 
            this.OldPassword.Location = new System.Drawing.Point(43, 36);
            this.OldPassword.Name = "OldPassword";
            this.OldPassword.Size = new System.Drawing.Size(196, 20);
            this.OldPassword.TabIndex = 113;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(43, 200);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(196, 23);
            this.save.TabIndex = 112;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // newPasswordError
            // 
            this.newPasswordError.AutoSize = true;
            this.newPasswordError.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPasswordError.ForeColor = System.Drawing.Color.Red;
            this.newPasswordError.Location = new System.Drawing.Point(49, 134);
            this.newPasswordError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newPasswordError.Name = "newPasswordError";
            this.newPasswordError.Size = new System.Drawing.Size(184, 17);
            this.newPasswordError.TabIndex = 118;
            this.newPasswordError.Text = "Заполните обязательное поле";
            this.newPasswordError.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 117;
            this.label2.Text = "Новый пароль";
            // 
            // newPasword
            // 
            this.newPasword.Location = new System.Drawing.Point(43, 111);
            this.newPasword.Name = "newPasword";
            this.newPasword.Size = new System.Drawing.Size(196, 20);
            this.newPasword.TabIndex = 116;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(43, 241);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 23);
            this.button4.TabIndex = 119;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // NewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(203)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(293, 288);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.newPasswordError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newPasword);
            this.Controls.Add(this.oldPasswordError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OldPassword);
            this.Controls.Add(this.save);
            this.Name = "NewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPassword";
            this.Load += new System.EventHandler(this.NewPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oldPasswordError;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OldPassword;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label newPasswordError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newPasword;
        private System.Windows.Forms.Button button4;
    }
}