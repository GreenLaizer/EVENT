namespace Event
{
    partial class Form2
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.edChange = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.edDate = new System.Windows.Forms.DateTimePicker();
            this.edTime = new System.Windows.Forms.MaskedTextBox();
            this.edName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(11, 241);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(720, 292);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edChange
            // 
            this.edChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edChange.Location = new System.Drawing.Point(264, 116);
            this.edChange.Name = "edChange";
            this.edChange.Size = new System.Drawing.Size(200, 60);
            this.edChange.TabIndex = 2;
            this.edChange.Text = "Изменить";
            this.edChange.UseVisualStyleBackColor = true;
            this.edChange.Click += new System.EventHandler(this.edChange_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(531, 116);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 60);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // edDate
            // 
            this.edDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.edDate.Location = new System.Drawing.Point(470, 36);
            this.edDate.Name = "edDate";
            this.edDate.Size = new System.Drawing.Size(212, 27);
            this.edDate.TabIndex = 4;
            this.edDate.Value = new System.DateTime(2020, 12, 2, 0, 0, 0, 0);
            // 
            // edTime
            // 
            this.edTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edTime.Location = new System.Drawing.Point(688, 36);
            this.edTime.Mask = "90:00";
            this.edTime.Name = "edTime";
            this.edTime.Size = new System.Drawing.Size(82, 27);
            this.edTime.TabIndex = 5;
            this.edTime.ValidatingType = typeof(System.DateTime);
            // 
            // edName
            // 
            this.edName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edName.Location = new System.Drawing.Point(12, 36);
            this.edName.Name = "edName";
            this.edName.Size = new System.Drawing.Size(452, 27);
            this.edName.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 653);
            this.Controls.Add(this.edName);
            this.Controls.Add(this.edTime);
            this.Controls.Add(this.edDate);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.edChange);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Расширенная информация";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button edChange;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker edDate;
        private System.Windows.Forms.MaskedTextBox edTime;
        private System.Windows.Forms.TextBox edName;
    }
}