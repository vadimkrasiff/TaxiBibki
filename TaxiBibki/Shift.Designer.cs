namespace TaxiBibki
{
    partial class Shift
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
            this.userError = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.startShiftError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.finishShiftError = new System.Windows.Forms.Label();
            this.finishDate = new System.Windows.Forms.DateTimePicker();
            this.delete = new System.Windows.Forms.Button();
            this.backForm = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userError
            // 
            this.userError.AutoSize = true;
            this.userError.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userError.ForeColor = System.Drawing.Color.Red;
            this.userError.Location = new System.Drawing.Point(21, 48);
            this.userError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userError.Name = "userError";
            this.userError.Size = new System.Drawing.Size(184, 17);
            this.userError.TabIndex = 149;
            this.userError.Text = "Заполните обязательное поле";
            this.userError.Visible = false;
            // 
            // userBox
            // 
            this.userBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userBox.FormattingEnabled = true;
            this.userBox.Location = new System.Drawing.Point(12, 25);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(225, 21);
            this.userBox.TabIndex = 148;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 147;
            this.label6.Text = "Сотрудник";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(12, 94);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(225, 20);
            this.startDate.TabIndex = 150;
            // 
            // startShiftError
            // 
            this.startShiftError.AutoSize = true;
            this.startShiftError.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startShiftError.ForeColor = System.Drawing.Color.Red;
            this.startShiftError.Location = new System.Drawing.Point(21, 117);
            this.startShiftError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startShiftError.Name = "startShiftError";
            this.startShiftError.Size = new System.Drawing.Size(184, 17);
            this.startShiftError.TabIndex = 151;
            this.startShiftError.Text = "Заполните обязательное поле";
            this.startShiftError.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 152;
            this.label2.Text = "Начало смены";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 155;
            this.label1.Text = "Конец смены";
            // 
            // finishShiftError
            // 
            this.finishShiftError.AutoSize = true;
            this.finishShiftError.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finishShiftError.ForeColor = System.Drawing.Color.Red;
            this.finishShiftError.Location = new System.Drawing.Point(21, 190);
            this.finishShiftError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.finishShiftError.Name = "finishShiftError";
            this.finishShiftError.Size = new System.Drawing.Size(184, 17);
            this.finishShiftError.TabIndex = 154;
            this.finishShiftError.Text = "Заполните обязательное поле";
            this.finishShiftError.Visible = false;
            // 
            // finishDate
            // 
            this.finishDate.Location = new System.Drawing.Point(12, 167);
            this.finishDate.Name = "finishDate";
            this.finishDate.Size = new System.Drawing.Size(225, 20);
            this.finishDate.TabIndex = 153;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.ForeColor = System.Drawing.Color.Transparent;
            this.delete.Location = new System.Drawing.Point(257, 64);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(225, 23);
            this.delete.TabIndex = 170;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // backForm
            // 
            this.backForm.Location = new System.Drawing.Point(257, 164);
            this.backForm.Name = "backForm";
            this.backForm.Size = new System.Drawing.Size(225, 23);
            this.backForm.TabIndex = 169;
            this.backForm.Text = "Назад";
            this.backForm.UseVisualStyleBackColor = true;
            this.backForm.Click += new System.EventHandler(this.backForm_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(257, 25);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(225, 23);
            this.submit.TabIndex = 168;
            this.submit.Text = "Сохранить";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Shift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(203)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(500, 219);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.backForm);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finishShiftError);
            this.Controls.Add(this.finishDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startShiftError);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.userError);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(516, 258);
            this.MinimumSize = new System.Drawing.Size(516, 258);
            this.Name = "Shift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shift";
            this.Load += new System.EventHandler(this.Shift_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userError;
        private System.Windows.Forms.ComboBox userBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label startShiftError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label finishShiftError;
        private System.Windows.Forms.DateTimePicker finishDate;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button backForm;
        private System.Windows.Forms.Button submit;
    }
}