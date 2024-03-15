namespace TaxiBibki
{
    partial class Order
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
            this.clientError = new System.Windows.Forms.Label();
            this.clientBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusError = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firstPoint = new System.Windows.Forms.TextBox();
            this.finishPoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.firstError = new System.Windows.Forms.Label();
            this.finishError = new System.Windows.Forms.Label();
            this.sumError = new System.Windows.Forms.Label();
            this.sumBox = new System.Windows.Forms.NumericUpDown();
            this.driverBox = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.backForm = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sumBox)).BeginInit();
            this.SuspendLayout();
            // 
            // clientError
            // 
            this.clientError.AutoSize = true;
            this.clientError.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientError.ForeColor = System.Drawing.Color.Red;
            this.clientError.Location = new System.Drawing.Point(21, 53);
            this.clientError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientError.Name = "clientError";
            this.clientError.Size = new System.Drawing.Size(184, 17);
            this.clientError.TabIndex = 146;
            this.clientError.Text = "Заполните обязательное поле";
            this.clientError.Visible = false;
            // 
            // clientBox
            // 
            this.clientBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientBox.FormattingEnabled = true;
            this.clientBox.Location = new System.Drawing.Point(12, 30);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(225, 21);
            this.clientBox.TabIndex = 145;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 144;
            this.label6.Text = "Клиент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 147;
            this.label2.Text = "Водитель";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // statusError
            // 
            this.statusError.AutoSize = true;
            this.statusError.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusError.ForeColor = System.Drawing.Color.Red;
            this.statusError.Location = new System.Drawing.Point(21, 180);
            this.statusError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusError.Name = "statusError";
            this.statusError.Size = new System.Drawing.Size(184, 17);
            this.statusError.TabIndex = 152;
            this.statusError.Text = "Заполните обязательное поле";
            this.statusError.Visible = false;
            this.statusError.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // statusBox
            // 
            this.statusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "заявка",
            "оформлено",
            "в работе",
            "отказ",
            "готово"});
            this.statusBox.Location = new System.Drawing.Point(12, 157);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(225, 21);
            this.statusBox.TabIndex = 151;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 150;
            this.label3.Text = "Статус";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 153;
            this.label5.Text = "Сумма";
            // 
            // firstPoint
            // 
            this.firstPoint.Location = new System.Drawing.Point(12, 281);
            this.firstPoint.Name = "firstPoint";
            this.firstPoint.Size = new System.Drawing.Size(225, 20);
            this.firstPoint.TabIndex = 157;
            // 
            // finishPoint
            // 
            this.finishPoint.Location = new System.Drawing.Point(12, 337);
            this.finishPoint.Name = "finishPoint";
            this.finishPoint.Size = new System.Drawing.Size(225, 20);
            this.finishPoint.TabIndex = 158;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 159;
            this.label1.Text = "Начальная точка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 160;
            this.label7.Text = "Конечная точка";
            // 
            // firstError
            // 
            this.firstError.AutoSize = true;
            this.firstError.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstError.ForeColor = System.Drawing.Color.Red;
            this.firstError.Location = new System.Drawing.Point(21, 304);
            this.firstError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstError.Name = "firstError";
            this.firstError.Size = new System.Drawing.Size(184, 17);
            this.firstError.TabIndex = 161;
            this.firstError.Text = "Заполните обязательное поле";
            this.firstError.Visible = false;
            // 
            // finishError
            // 
            this.finishError.AutoSize = true;
            this.finishError.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finishError.ForeColor = System.Drawing.Color.Red;
            this.finishError.Location = new System.Drawing.Point(21, 360);
            this.finishError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.finishError.Name = "finishError";
            this.finishError.Size = new System.Drawing.Size(184, 17);
            this.finishError.TabIndex = 162;
            this.finishError.Text = "Заполните обязательное поле";
            this.finishError.Visible = false;
            // 
            // sumError
            // 
            this.sumError.AutoSize = true;
            this.sumError.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumError.ForeColor = System.Drawing.Color.Red;
            this.sumError.Location = new System.Drawing.Point(21, 243);
            this.sumError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sumError.Name = "sumError";
            this.sumError.Size = new System.Drawing.Size(184, 17);
            this.sumError.TabIndex = 155;
            this.sumError.Text = "Заполните обязательное поле";
            this.sumError.Visible = false;
            // 
            // sumBox
            // 
            this.sumBox.DecimalPlaces = 2;
            this.sumBox.Location = new System.Drawing.Point(12, 220);
            this.sumBox.Maximum = new decimal(new int[] {
            -469762048,
            -590869294,
            5421010,
            0});
            this.sumBox.Name = "sumBox";
            this.sumBox.Size = new System.Drawing.Size(225, 20);
            this.sumBox.TabIndex = 163;
            // 
            // driverBox
            // 
            this.driverBox.Enabled = false;
            this.driverBox.Location = new System.Drawing.Point(12, 92);
            this.driverBox.Name = "driverBox";
            this.driverBox.Size = new System.Drawing.Size(225, 20);
            this.driverBox.TabIndex = 164;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(254, 243);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(225, 23);
            this.submit.TabIndex = 165;
            this.submit.Text = "Сохранить";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // backForm
            // 
            this.backForm.Location = new System.Drawing.Point(254, 360);
            this.backForm.Name = "backForm";
            this.backForm.Size = new System.Drawing.Size(225, 23);
            this.backForm.TabIndex = 166;
            this.backForm.Text = "Назад";
            this.backForm.UseVisualStyleBackColor = true;
            this.backForm.Click += new System.EventHandler(this.backForm_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Red;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.ForeColor = System.Drawing.Color.Transparent;
            this.delete.Location = new System.Drawing.Point(254, 281);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(225, 23);
            this.delete.TabIndex = 167;
            this.delete.Text = "Отменить заказ";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(254, 30);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(225, 197);
            this.descriptionBox.TabIndex = 169;
            this.descriptionBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 170;
            this.label4.Text = "Комментарий";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 23);
            this.button1.TabIndex = 171;
            this.button1.Text = "Взять в работу ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 23);
            this.button2.TabIndex = 172;
            this.button2.Text = "Завершить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(203)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(491, 394);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.backForm);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.driverBox);
            this.Controls.Add(this.sumBox);
            this.Controls.Add(this.finishError);
            this.Controls.Add(this.firstError);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finishPoint);
            this.Controls.Add(this.firstPoint);
            this.Controls.Add(this.sumError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusError);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientError);
            this.Controls.Add(this.clientBox);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(507, 433);
            this.MinimumSize = new System.Drawing.Size(507, 433);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sumBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientError;
        private System.Windows.Forms.ComboBox clientBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusError;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstPoint;
        private System.Windows.Forms.TextBox finishPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label firstError;
        private System.Windows.Forms.Label finishError;
        private System.Windows.Forms.Label sumError;
        private System.Windows.Forms.NumericUpDown sumBox;
        private System.Windows.Forms.TextBox driverBox;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button backForm;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}