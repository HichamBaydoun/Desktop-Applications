namespace HichamBaydoun_Test1
{
    partial class Form1
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
            this.comboType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericCost = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericYears = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpBoxSearch = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioType = new System.Windows.Forms.RadioButton();
            this.radioCustomer = new System.Windows.Forms.RadioButton();
            this.boxFilter = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.listBoxSearch = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYears)).BeginInit();
            this.grpBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.numericYears);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericCost);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.boxPhone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.boxName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Insurance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insurance Policy Type";
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(134, 24);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(121, 21);
            this.comboType.TabIndex = 1;
            this.comboType.SelectedIndexChanged += new System.EventHandler(this.comboType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(134, 65);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(121, 20);
            this.boxName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Phone Number";
            // 
            // boxPhone
            // 
            this.boxPhone.Location = new System.Drawing.Point(134, 107);
            this.boxPhone.Name = "boxPhone";
            this.boxPhone.Size = new System.Drawing.Size(121, 20);
            this.boxPhone.TabIndex = 4;
            this.boxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxPhone_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Policy cost per year";
            // 
            // numericCost
            // 
            this.numericCost.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericCost.Location = new System.Drawing.Point(134, 151);
            this.numericCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericCost.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericCost.Name = "numericCost";
            this.numericCost.Size = new System.Drawing.Size(121, 20);
            this.numericCost.TabIndex = 1;
            this.numericCost.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Number of years";
            // 
            // numericYears
            // 
            this.numericYears.Location = new System.Drawing.Point(134, 177);
            this.numericYears.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericYears.Name = "numericYears";
            this.numericYears.Size = new System.Drawing.Size(121, 20);
            this.numericYears.TabIndex = 7;
            this.numericYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(30, 216);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Policy";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(122, 216);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpBoxSearch
            // 
            this.grpBoxSearch.Controls.Add(this.listBoxSearch);
            this.grpBoxSearch.Controls.Add(this.btnSearch2);
            this.grpBoxSearch.Controls.Add(this.btnSearch1);
            this.grpBoxSearch.Controls.Add(this.btnGo);
            this.grpBoxSearch.Controls.Add(this.boxFilter);
            this.grpBoxSearch.Controls.Add(this.radioCustomer);
            this.grpBoxSearch.Controls.Add(this.radioType);
            this.grpBoxSearch.Controls.Add(this.label6);
            this.grpBoxSearch.Location = new System.Drawing.Point(289, 12);
            this.grpBoxSearch.Name = "grpBoxSearch";
            this.grpBoxSearch.Size = new System.Drawing.Size(445, 398);
            this.grpBoxSearch.TabIndex = 1;
            this.grpBoxSearch.TabStop = false;
            this.grpBoxSearch.Text = "Search Area";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "SearchBy?";
            // 
            // radioType
            // 
            this.radioType.AutoSize = true;
            this.radioType.Location = new System.Drawing.Point(84, 45);
            this.radioType.Name = "radioType";
            this.radioType.Size = new System.Drawing.Size(49, 17);
            this.radioType.TabIndex = 1;
            this.radioType.TabStop = true;
            this.radioType.Text = "Type";
            this.radioType.UseVisualStyleBackColor = true;
            // 
            // radioCustomer
            // 
            this.radioCustomer.AutoSize = true;
            this.radioCustomer.Location = new System.Drawing.Point(139, 45);
            this.radioCustomer.Name = "radioCustomer";
            this.radioCustomer.Size = new System.Drawing.Size(69, 17);
            this.radioCustomer.TabIndex = 2;
            this.radioCustomer.TabStop = true;
            this.radioCustomer.Text = "Customer";
            this.radioCustomer.UseVisualStyleBackColor = true;
            // 
            // boxFilter
            // 
            this.boxFilter.Location = new System.Drawing.Point(214, 47);
            this.boxFilter.Name = "boxFilter";
            this.boxFilter.Size = new System.Drawing.Size(123, 20);
            this.boxFilter.TabIndex = 3;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(343, 45);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(42, 23);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnSearch1
            // 
            this.btnSearch1.Location = new System.Drawing.Point(22, 84);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(368, 23);
            this.btnSearch1.TabIndex = 5;
            this.btnSearch1.Text = "Customers who bought a policy for more than 2 years";
            this.btnSearch1.UseVisualStyleBackColor = true;
            this.btnSearch1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch2
            // 
            this.btnSearch2.Location = new System.Drawing.Point(22, 113);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(368, 23);
            this.btnSearch2.TabIndex = 6;
            this.btnSearch2.Text = "Find the most expensive policy (as a total cost)";
            this.btnSearch2.UseVisualStyleBackColor = true;
            this.btnSearch2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBoxSearch
            // 
            this.listBoxSearch.FormattingEnabled = true;
            this.listBoxSearch.Location = new System.Drawing.Point(22, 151);
            this.listBoxSearch.Name = "listBoxSearch";
            this.listBoxSearch.Size = new System.Drawing.Size(368, 238);
            this.listBoxSearch.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 422);
            this.Controls.Add(this.grpBoxSearch);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "New Insurance";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYears)).EndInit();
            this.grpBoxSearch.ResumeLayout(false);
            this.grpBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numericYears;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBoxSearch;
        private System.Windows.Forms.ListBox listBoxSearch;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox boxFilter;
        private System.Windows.Forms.RadioButton radioCustomer;
        private System.Windows.Forms.RadioButton radioType;
        private System.Windows.Forms.Label label6;
    }
}

