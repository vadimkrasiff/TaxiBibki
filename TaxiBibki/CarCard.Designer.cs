namespace TaxiBibki
{
    partial class CarCard
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.photoError = new System.Windows.Forms.Label();
            this.uploadPhoto = new System.Windows.Forms.Button();
            this.colorError = new System.Windows.Forms.Label();
            this.numberError = new System.Windows.Forms.Label();
            this.markError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.markBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberBox = new System.Windows.Forms.TextBox();
            this.backForm = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 149;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // photoError
            // 
            this.photoError.AutoSize = true;
            this.photoError.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoError.ForeColor = System.Drawing.Color.Red;
            this.photoError.Location = new System.Drawing.Point(48, 331);
            this.photoError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.photoError.Name = "photoError";
            this.photoError.Size = new System.Drawing.Size(145, 17);
            this.photoError.TabIndex = 148;
            this.photoError.Text = "Загрузите фотографию";
            this.photoError.Visible = false;
            // 
            // uploadPhoto
            // 
            this.uploadPhoto.Location = new System.Drawing.Point(12, 305);
            this.uploadPhoto.Name = "uploadPhoto";
            this.uploadPhoto.Size = new System.Drawing.Size(225, 23);
            this.uploadPhoto.TabIndex = 147;
            this.uploadPhoto.Text = "Загрузить фото";
            this.uploadPhoto.UseVisualStyleBackColor = true;
            this.uploadPhoto.Click += new System.EventHandler(this.uploadPhoto_Click);
            // 
            // colorError
            // 
            this.colorError.AutoSize = true;
            this.colorError.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorError.ForeColor = System.Drawing.Color.Red;
            this.colorError.Location = new System.Drawing.Point(276, 160);
            this.colorError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colorError.Name = "colorError";
            this.colorError.Size = new System.Drawing.Size(184, 17);
            this.colorError.TabIndex = 158;
            this.colorError.Text = "Заполните обязательное поле";
            this.colorError.Visible = false;
            // 
            // numberError
            // 
            this.numberError.AutoSize = true;
            this.numberError.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberError.ForeColor = System.Drawing.Color.Red;
            this.numberError.Location = new System.Drawing.Point(276, 49);
            this.numberError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberError.Name = "numberError";
            this.numberError.Size = new System.Drawing.Size(184, 17);
            this.numberError.TabIndex = 157;
            this.numberError.Text = "Заполните обязательное поле";
            this.numberError.Visible = false;
            // 
            // markError
            // 
            this.markError.AutoSize = true;
            this.markError.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markError.ForeColor = System.Drawing.Color.Red;
            this.markError.Location = new System.Drawing.Point(276, 104);
            this.markError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.markError.Name = "markError";
            this.markError.Size = new System.Drawing.Size(184, 17);
            this.markError.TabIndex = 156;
            this.markError.Text = "Заполните обязательное поле";
            this.markError.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 155;
            this.label3.Text = "Цвет";
            // 
            // colorBox
            // 
            this.colorBox.Location = new System.Drawing.Point(270, 137);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(196, 20);
            this.colorBox.TabIndex = 154;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 153;
            this.label2.Text = "Марка";
            // 
            // markBox
            // 
            this.markBox.Location = new System.Drawing.Point(270, 81);
            this.markBox.Name = "markBox";
            this.markBox.Size = new System.Drawing.Size(196, 20);
            this.markBox.TabIndex = 152;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 151;
            this.label1.Text = "Гос. номер";
            // 
            // numberBox
            // 
            this.numberBox.Location = new System.Drawing.Point(270, 26);
            this.numberBox.Name = "numberBox";
            this.numberBox.Size = new System.Drawing.Size(196, 20);
            this.numberBox.TabIndex = 150;
            // 
            // backForm
            // 
            this.backForm.Location = new System.Drawing.Point(270, 304);
            this.backForm.Name = "backForm";
            this.backForm.Size = new System.Drawing.Size(196, 23);
            this.backForm.TabIndex = 161;
            this.backForm.Text = "Назад";
            this.backForm.UseVisualStyleBackColor = true;
            this.backForm.Click += new System.EventHandler(this.backForm_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.ForeColor = System.Drawing.Color.Transparent;
            this.delete.Location = new System.Drawing.Point(270, 263);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(196, 23);
            this.delete.TabIndex = 160;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(270, 234);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(196, 23);
            this.submit.TabIndex = 159;
            this.submit.Text = "Сохранить";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // CarCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(203)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(491, 371);
            this.Controls.Add(this.backForm);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.colorError);
            this.Controls.Add(this.numberError);
            this.Controls.Add(this.markError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.markBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.photoError);
            this.Controls.Add(this.uploadPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(507, 410);
            this.MinimumSize = new System.Drawing.Size(507, 410);
            this.Name = "CarCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarCard";
            this.Load += new System.EventHandler(this.CarCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label photoError;
        private System.Windows.Forms.Button uploadPhoto;
        private System.Windows.Forms.Label colorError;
        private System.Windows.Forms.Label numberError;
        private System.Windows.Forms.Label markError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox colorBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox markBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Button backForm;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button submit;
    }
}