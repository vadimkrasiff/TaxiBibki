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
            this.driverError = new System.Windows.Forms.Label();
            this.driverBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusError = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // driverError
            // 
            this.driverError.AutoSize = true;
            this.driverError.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.driverError.ForeColor = System.Drawing.Color.Red;
            this.driverError.Location = new System.Drawing.Point(21, 115);
            this.driverError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.driverError.Name = "driverError";
            this.driverError.Size = new System.Drawing.Size(184, 17);
            this.driverError.TabIndex = 149;
            this.driverError.Text = "Заполните обязательное поле";
            this.driverError.Visible = false;
            this.driverError.Click += new System.EventHandler(this.label1_Click);
            // 
            // driverBox
            // 
            this.driverBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driverBox.FormattingEnabled = true;
            this.driverBox.Location = new System.Drawing.Point(12, 92);
            this.driverBox.Name = "driverBox";
            this.driverBox.Size = new System.Drawing.Size(225, 21);
            this.driverBox.TabIndex = 148;
            this.driverBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(21, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 17);
            this.label4.TabIndex = 155;
            this.label4.Text = "Заполните обязательное поле";
            this.label4.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 220);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(225, 21);
            this.comboBox2.TabIndex = 154;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 153;
            this.label5.Text = "Водитель";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(272, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 408);
            this.pictureBox1.TabIndex = 156;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 281);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 157;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 337);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 20);
            this.textBox2.TabIndex = 158;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(21, 304);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 17);
            this.label8.TabIndex = 161;
            this.label8.Text = "Заполните обязательное поле";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(21, 360);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 17);
            this.label9.TabIndex = 162;
            this.label9.Text = "Заполните обязательное поле";
            this.label9.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 23);
            this.button1.TabIndex = 163;
            this.button1.Text = "Построить маршрут";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(203)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusError);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.driverError);
            this.Controls.Add(this.driverBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientError);
            this.Controls.Add(this.clientBox);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientError;
        private System.Windows.Forms.ComboBox clientBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label driverError;
        private System.Windows.Forms.ComboBox driverBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusError;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}