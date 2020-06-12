namespace HichamBaydoun_Assignment2
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.boxSearchResult = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.boxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.boxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabOwnership = new System.Windows.Forms.TabPage();
            this.boxDetails = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.numericID = new System.Windows.Forms.NumericUpDown();
            this.comboCustomer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabs.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabOwnership.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericID)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabCustomer);
            this.tabs.Controls.Add(this.tabOwnership);
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(513, 384);
            this.tabs.TabIndex = 0;
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.groupBox1);
            this.tabCustomer.Controls.Add(this.btnAdd);
            this.tabCustomer.Controls.Add(this.boxName);
            this.tabCustomer.Controls.Add(this.label1);
            this.tabCustomer.Location = new System.Drawing.Point(4, 22);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomer.Size = new System.Drawing.Size(505, 358);
            this.tabCustomer.TabIndex = 0;
            this.tabCustomer.Text = "Add/Delete Customer";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.boxSearchResult);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.boxSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(30, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 194);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search For Customer";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(55, 160);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Customer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // boxSearchResult
            // 
            this.boxSearchResult.Location = new System.Drawing.Point(9, 82);
            this.boxSearchResult.Multiline = true;
            this.boxSearchResult.Name = "boxSearchResult";
            this.boxSearchResult.ReadOnly = true;
            this.boxSearchResult.Size = new System.Drawing.Size(215, 72);
            this.boxSearchResult.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(157, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // boxSearch
            // 
            this.boxSearch.Location = new System.Drawing.Point(9, 42);
            this.boxSearch.Name = "boxSearch";
            this.boxSearch.Size = new System.Drawing.Size(135, 20);
            this.boxSearch.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter name of customer to search for:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(240, 36);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Customer";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(85, 36);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(135, 20);
            this.boxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tabOwnership
            // 
            this.tabOwnership.Controls.Add(this.boxDetails);
            this.tabOwnership.Controls.Add(this.label4);
            this.tabOwnership.Controls.Add(this.btnAssign);
            this.tabOwnership.Controls.Add(this.numericID);
            this.tabOwnership.Controls.Add(this.comboCustomer);
            this.tabOwnership.Controls.Add(this.label3);
            this.tabOwnership.Location = new System.Drawing.Point(4, 22);
            this.tabOwnership.Name = "tabOwnership";
            this.tabOwnership.Padding = new System.Windows.Forms.Padding(3);
            this.tabOwnership.Size = new System.Drawing.Size(505, 358);
            this.tabOwnership.TabIndex = 1;
            this.tabOwnership.Text = "Ownership";
            this.tabOwnership.UseVisualStyleBackColor = true;
            // 
            // boxDetails
            // 
            this.boxDetails.Location = new System.Drawing.Point(24, 102);
            this.boxDetails.Multiline = true;
            this.boxDetails.Name = "boxDetails";
            this.boxDetails.ReadOnly = true;
            this.boxDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxDetails.Size = new System.Drawing.Size(227, 229);
            this.boxDetails.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Choose a Customer";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(308, 135);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(166, 23);
            this.btnAssign.TabIndex = 4;
            this.btnAssign.Text = "Assign Account to Customer";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // numericID
            // 
            this.numericID.Location = new System.Drawing.Point(24, 67);
            this.numericID.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericID.Name = "numericID";
            this.numericID.Size = new System.Drawing.Size(120, 20);
            this.numericID.TabIndex = 2;
            this.numericID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboCustomer
            // 
            this.comboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCustomer.FormattingEnabled = true;
            this.comboCustomer.Location = new System.Drawing.Point(308, 66);
            this.comboCustomer.Name = "comboCustomer";
            this.comboCustomer.Size = new System.Drawing.Size(158, 21);
            this.comboCustomer.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Choose an Account by entering the account ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 408);
            this.Controls.Add(this.tabs);
            this.Name = "Form1";
            this.Text = "Bank Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabs.ResumeLayout(false);
            this.tabCustomer.ResumeLayout(false);
            this.tabCustomer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabOwnership.ResumeLayout(false);
            this.tabOwnership.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox boxSearchResult;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox boxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabOwnership;
        private System.Windows.Forms.TextBox boxDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.NumericUpDown numericID;
        private System.Windows.Forms.ComboBox comboCustomer;
        private System.Windows.Forms.Label label3;
    }
}

