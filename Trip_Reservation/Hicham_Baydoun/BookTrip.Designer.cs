namespace Hicham_Baydoun
{
    partial class BookTrip
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxReservation = new System.Windows.Forms.TextBox();
            this.comboPlan = new System.Windows.Forms.ComboBox();
            this.dateTimeWhen = new System.Windows.Forms.DateTimePicker();
            this.numericPersons = new System.Windows.Forms.NumericUpDown();
            this.listFrom = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listTo = new System.Windows.Forms.ListBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBook);
            this.groupBox1.Controls.Add(this.listTo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listFrom);
            this.groupBox1.Controls.Add(this.numericPersons);
            this.groupBox1.Controls.Add(this.dateTimeWhen);
            this.groupBox1.Controls.Add(this.comboPlan);
            this.groupBox1.Controls.Add(this.boxReservation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 363);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trip Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation for:";
            // 
            // boxReservation
            // 
            this.boxReservation.Location = new System.Drawing.Point(29, 72);
            this.boxReservation.Name = "boxReservation";
            this.boxReservation.Size = new System.Drawing.Size(153, 20);
            this.boxReservation.TabIndex = 1;
            // 
            // comboPlan
            // 
            this.comboPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPlan.FormattingEnabled = true;
            this.comboPlan.Location = new System.Drawing.Point(29, 146);
            this.comboPlan.Name = "comboPlan";
            this.comboPlan.Size = new System.Drawing.Size(153, 21);
            this.comboPlan.TabIndex = 2;
            // 
            // dateTimeWhen
            // 
            this.dateTimeWhen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeWhen.Location = new System.Drawing.Point(29, 229);
            this.dateTimeWhen.Name = "dateTimeWhen";
            this.dateTimeWhen.Size = new System.Drawing.Size(153, 20);
            this.dateTimeWhen.TabIndex = 3;
            // 
            // numericPersons
            // 
            this.numericPersons.Location = new System.Drawing.Point(29, 306);
            this.numericPersons.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericPersons.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericPersons.Name = "numericPersons";
            this.numericPersons.Size = new System.Drawing.Size(153, 20);
            this.numericPersons.TabIndex = 4;
            this.numericPersons.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listFrom
            // 
            this.listFrom.FormattingEnabled = true;
            this.listFrom.Location = new System.Drawing.Point(264, 72);
            this.listFrom.Name = "listFrom";
            this.listFrom.Size = new System.Drawing.Size(183, 212);
            this.listFrom.TabIndex = 5;
            this.listFrom.SelectedIndexChanged += new System.EventHandler(this.listFrom_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select a plan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "When would you like to go?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "How many Persons?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Depart from";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(484, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Trip to";
            // 
            // listTo
            // 
            this.listTo.FormattingEnabled = true;
            this.listTo.Location = new System.Drawing.Point(453, 72);
            this.listTo.Name = "listTo";
            this.listTo.Size = new System.Drawing.Size(183, 212);
            this.listTo.TabIndex = 11;
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(414, 303);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 23);
            this.btnBook.TabIndex = 12;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // BookTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 399);
            this.Controls.Add(this.groupBox1);
            this.Name = "BookTrip";
            this.Text = "BookTrip";
            this.Load += new System.EventHandler(this.BookTrip_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPersons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listFrom;
        private System.Windows.Forms.NumericUpDown numericPersons;
        private System.Windows.Forms.DateTimePicker dateTimeWhen;
        private System.Windows.Forms.ComboBox comboPlan;
        private System.Windows.Forms.TextBox boxReservation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listTo;
        private System.Windows.Forms.Button btnBook;
    }
}