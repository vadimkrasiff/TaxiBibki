namespace TaxiBibki
{
    partial class OperatorCard
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
            this.phoneError = new System.Windows.Forms.Label();
            this.NameError = new System.Windows.Forms.Label();
            this.surnameError = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.usernameError = new System.Windows.Forms.Label();
            this.passwordError = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.updatePassword = new System.Windows.Forms.Button();
            this.photoError = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneError
            // 
            this.phoneError.AutoSize = true;
            this.phoneError.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneError.ForeColor = System.Drawing.Color.Red;
            this.phoneError.Location = new System.Drawing.Point(286, 223);
            this.phoneError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneError.Name = "phoneError";
            this.phoneError.Size = new System.Drawing.Size(184, 17);
            this.phoneError.TabIndex = 108;
            this.phoneError.Text = "Заполните обязательное поле";
            this.phoneError.Visible = false;
            // 
            // NameError
            // 
            this.NameError.AutoSize = true;
            this.NameError.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameError.ForeColor = System.Drawing.Color.Red;
            this.NameError.Location = new System.Drawing.Point(286, 51);
            this.NameError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameError.Name = "NameError";
            this.NameError.Size = new System.Drawing.Size(184, 17);
            this.NameError.TabIndex = 107;
            this.NameError.Text = "Заполните обязательное поле";
            this.NameError.Visible = false;
            // 
            // surnameError
            // 
            this.surnameError.AutoSize = true;
            this.surnameError.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameError.ForeColor = System.Drawing.Color.Red;
            this.surnameError.Location = new System.Drawing.Point(286, 106);
            this.surnameError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surnameError.Name = "surnameError";
            this.surnameError.Size = new System.Drawing.Size(184, 17);
            this.surnameError.TabIndex = 106;
            this.surnameError.Text = "Заполните обязательное поле";
            this.surnameError.Visible = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(280, 197);
            this.maskedTextBox1.Mask = "89000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(196, 20);
            this.maskedTextBox1.TabIndex = 105;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(280, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 23);
            this.button4.TabIndex = 104;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(280, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 23);
            this.button3.TabIndex = 103;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 23);
            this.button2.TabIndex = 102;
            this.button2.Text = "Загрузить фото";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 23);
            this.button1.TabIndex = 101;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 99;
            this.label4.Text = "телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 98;
            this.label3.Text = "username";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(280, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(196, 20);
            this.textBox3.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 96;
            this.label2.Text = "Фамилия";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(280, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 20);
            this.textBox2.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Имя";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 93;
            // 
            // usernameError
            // 
            this.usernameError.AutoSize = true;
            this.usernameError.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameError.ForeColor = System.Drawing.Color.Red;
            this.usernameError.Location = new System.Drawing.Point(286, 162);
            this.usernameError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameError.Name = "usernameError";
            this.usernameError.Size = new System.Drawing.Size(184, 17);
            this.usernameError.TabIndex = 112;
            this.usernameError.Text = "Заполните обязательное поле";
            this.usernameError.Visible = false;
            // 
            // passwordError
            // 
            this.passwordError.AutoSize = true;
            this.passwordError.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordError.ForeColor = System.Drawing.Color.Red;
            this.passwordError.Location = new System.Drawing.Point(286, 279);
            this.passwordError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(184, 17);
            this.passwordError.TabIndex = 118;
            this.passwordError.Text = "Заполните обязательное поле";
            this.passwordError.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 117;
            this.label5.Text = "пароль";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(280, 256);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(196, 20);
            this.password.TabIndex = 116;
            // 
            // updatePassword
            // 
            this.updatePassword.Location = new System.Drawing.Point(280, 307);
            this.updatePassword.Name = "updatePassword";
            this.updatePassword.Size = new System.Drawing.Size(196, 23);
            this.updatePassword.TabIndex = 119;
            this.updatePassword.Text = "Изменить пароль";
            this.updatePassword.UseVisualStyleBackColor = true;
            this.updatePassword.Click += new System.EventHandler(this.updatePassword_Click);
            // 
            // photoError
            // 
            this.photoError.AutoSize = true;
            this.photoError.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoError.ForeColor = System.Drawing.Color.Red;
            this.photoError.Location = new System.Drawing.Point(60, 333);
            this.photoError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.photoError.Name = "photoError";
            this.photoError.Size = new System.Drawing.Size(145, 17);
            this.photoError.TabIndex = 145;
            this.photoError.Text = "Загрузите фотографию";
            this.photoError.Visible = false;
            this.photoError.Click += new System.EventHandler(this.photoError_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(24, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 146;
            this.pictureBox1.TabStop = false;
            // 
            // OperatorCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(203)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.photoError);
            this.Controls.Add(this.updatePassword);
            this.Controls.Add(this.passwordError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usernameError);
            this.Controls.Add(this.phoneError);
            this.Controls.Add(this.NameError);
            this.Controls.Add(this.surnameError);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(516, 489);
            this.MinimumSize = new System.Drawing.Size(516, 489);
            this.Name = "OperatorCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OperatorCard";
            this.Load += new System.EventHandler(this.OperatorCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label phoneError;
        private System.Windows.Forms.Label NameError;
        private System.Windows.Forms.Label surnameError;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label usernameError;
        private System.Windows.Forms.Label passwordError;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button updatePassword;
        private System.Windows.Forms.Label photoError;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}