namespace HichamBaydoun_Project
{
    partial class Doctor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label didLabel;
            System.Windows.Forms.Label d_nameLabel;
            System.Windows.Forms.Label specialityLabel;
            System.Windows.Forms.Label d_genderLabel;
            System.Windows.Forms.Label d_birthDateLabel;
            System.Windows.Forms.Label clinic_locationLabel;
            System.Windows.Forms.Label d_emailLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            this.hospitalDB_HichamDataSet = new HichamBaydoun_Project.HospitalDB_HichamDataSet();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter = new HichamBaydoun_Project.HospitalDB_HichamDataSetTableAdapters.DoctorTableAdapter();
            this.tableAdapterManager = new HichamBaydoun_Project.HospitalDB_HichamDataSetTableAdapters.TableAdapterManager();
            this.appointmentTableAdapter = new HichamBaydoun_Project.HospitalDB_HichamDataSetTableAdapters.AppointmentTableAdapter();
            this.clinic_LocationTableAdapter = new HichamBaydoun_Project.HospitalDB_HichamDataSetTableAdapters.Clinic_LocationTableAdapter();
            this.specialityTableAdapter = new HichamBaydoun_Project.HospitalDB_HichamDataSetTableAdapters.SpecialityTableAdapter();
            this.doctorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.doctorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.didTextBox = new System.Windows.Forms.TextBox();
            this.d_nameTextBox = new System.Windows.Forms.TextBox();
            this.d_genderTextBox = new System.Windows.Forms.TextBox();
            this.d_birthDateTextBox = new System.Windows.Forms.TextBox();
            this.d_emailTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.specialityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.specialityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.clinicLocationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtInfo = new System.Windows.Forms.TextBox();
            didLabel = new System.Windows.Forms.Label();
            d_nameLabel = new System.Windows.Forms.Label();
            specialityLabel = new System.Windows.Forms.Label();
            d_genderLabel = new System.Windows.Forms.Label();
            d_birthDateLabel = new System.Windows.Forms.Label();
            clinic_locationLabel = new System.Windows.Forms.Label();
            d_emailLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDB_HichamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingNavigator)).BeginInit();
            this.doctorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialityBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicLocationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // didLabel
            // 
            didLabel.AutoSize = true;
            didLabel.Location = new System.Drawing.Point(75, 93);
            didLabel.Name = "didLabel";
            didLabel.Size = new System.Drawing.Size(61, 15);
            didLabel.TabIndex = 1;
            didLabel.Text = "Doctor ID:";
            // 
            // d_nameLabel
            // 
            d_nameLabel.AutoSize = true;
            d_nameLabel.Location = new System.Drawing.Point(75, 123);
            d_nameLabel.Name = "d_nameLabel";
            d_nameLabel.Size = new System.Drawing.Size(44, 15);
            d_nameLabel.TabIndex = 3;
            d_nameLabel.Text = "Name:";
            // 
            // specialityLabel
            // 
            specialityLabel.AutoSize = true;
            specialityLabel.Location = new System.Drawing.Point(75, 153);
            specialityLabel.Name = "specialityLabel";
            specialityLabel.Size = new System.Drawing.Size(62, 15);
            specialityLabel.TabIndex = 5;
            specialityLabel.Text = "Speciality:";
            // 
            // d_genderLabel
            // 
            d_genderLabel.AutoSize = true;
            d_genderLabel.Location = new System.Drawing.Point(75, 183);
            d_genderLabel.Name = "d_genderLabel";
            d_genderLabel.Size = new System.Drawing.Size(51, 15);
            d_genderLabel.TabIndex = 7;
            d_genderLabel.Text = "Gender:";
            // 
            // d_birthDateLabel
            // 
            d_birthDateLabel.AutoSize = true;
            d_birthDateLabel.Location = new System.Drawing.Point(75, 213);
            d_birthDateLabel.Name = "d_birthDateLabel";
            d_birthDateLabel.Size = new System.Drawing.Size(64, 15);
            d_birthDateLabel.TabIndex = 9;
            d_birthDateLabel.Text = "Birth Date:";
            // 
            // clinic_locationLabel
            // 
            clinic_locationLabel.AutoSize = true;
            clinic_locationLabel.Location = new System.Drawing.Point(75, 243);
            clinic_locationLabel.Name = "clinic_locationLabel";
            clinic_locationLabel.Size = new System.Drawing.Size(90, 15);
            clinic_locationLabel.TabIndex = 11;
            clinic_locationLabel.Text = "Clinic Location:";
            // 
            // d_emailLabel
            // 
            d_emailLabel.AutoSize = true;
            d_emailLabel.Location = new System.Drawing.Point(75, 273);
            d_emailLabel.Name = "d_emailLabel";
            d_emailLabel.Size = new System.Drawing.Size(42, 15);
            d_emailLabel.TabIndex = 13;
            d_emailLabel.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(314, 213);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(91, 15);
            label1.TabIndex = 18;
            label1.Text = "(YYYY-MM-DD)";
            // 
            // hospitalDB_HichamDataSet
            // 
            this.hospitalDB_HichamDataSet.DataSetName = "HospitalDB_HichamDataSet";
            this.hospitalDB_HichamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.hospitalDB_HichamDataSet;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentTableAdapter = this.appointmentTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Clinic_LocationTableAdapter = this.clinic_LocationTableAdapter;
            this.tableAdapterManager.DoctorTableAdapter = this.doctorTableAdapter;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.SpecialityTableAdapter = this.specialityTableAdapter;
            this.tableAdapterManager.UpdateOrder = HichamBaydoun_Project.HospitalDB_HichamDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // clinic_LocationTableAdapter
            // 
            this.clinic_LocationTableAdapter.ClearBeforeFill = true;
            // 
            // specialityTableAdapter
            // 
            this.specialityTableAdapter.ClearBeforeFill = true;
            // 
            // doctorBindingNavigator
            // 
            this.doctorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.doctorBindingNavigator.BindingSource = this.doctorBindingSource;
            this.doctorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.doctorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.doctorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.doctorBindingNavigatorSaveItem});
            this.doctorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.doctorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.doctorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.doctorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.doctorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.doctorBindingNavigator.Name = "doctorBindingNavigator";
            this.doctorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.doctorBindingNavigator.Size = new System.Drawing.Size(835, 25);
            this.doctorBindingNavigator.TabIndex = 0;
            this.doctorBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // doctorBindingNavigatorSaveItem
            // 
            this.doctorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.doctorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("doctorBindingNavigatorSaveItem.Image")));
            this.doctorBindingNavigatorSaveItem.Name = "doctorBindingNavigatorSaveItem";
            this.doctorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.doctorBindingNavigatorSaveItem.Text = "Save Data";
            this.doctorBindingNavigatorSaveItem.Click += new System.EventHandler(this.doctorBindingNavigatorSaveItem_Click);
            // 
            // didTextBox
            // 
            this.didTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "did", true));
            this.didTextBox.Location = new System.Drawing.Point(168, 90);
            this.didTextBox.Name = "didTextBox";
            this.didTextBox.Size = new System.Drawing.Size(140, 21);
            this.didTextBox.TabIndex = 2;
            // 
            // d_nameTextBox
            // 
            this.d_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "d_name", true));
            this.d_nameTextBox.Location = new System.Drawing.Point(168, 120);
            this.d_nameTextBox.Name = "d_nameTextBox";
            this.d_nameTextBox.Size = new System.Drawing.Size(140, 21);
            this.d_nameTextBox.TabIndex = 4;
            // 
            // d_genderTextBox
            // 
            this.d_genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "d_gender", true));
            this.d_genderTextBox.Location = new System.Drawing.Point(168, 180);
            this.d_genderTextBox.Name = "d_genderTextBox";
            this.d_genderTextBox.Size = new System.Drawing.Size(140, 21);
            this.d_genderTextBox.TabIndex = 8;
            // 
            // d_birthDateTextBox
            // 
            this.d_birthDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "d_birthDate", true));
            this.d_birthDateTextBox.Location = new System.Drawing.Point(168, 210);
            this.d_birthDateTextBox.Name = "d_birthDateTextBox";
            this.d_birthDateTextBox.Size = new System.Drawing.Size(140, 21);
            this.d_birthDateTextBox.TabIndex = 10;
            // 
            // d_emailTextBox
            // 
            this.d_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "d_email", true));
            this.d_emailTextBox.Location = new System.Drawing.Point(168, 270);
            this.d_emailTextBox.Name = "d_emailTextBox";
            this.d_emailTextBox.Size = new System.Drawing.Size(140, 21);
            this.d_emailTextBox.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.doctorBindingSource, "speciality", true));
            this.comboBox1.DataSource = this.specialityBindingSource1;
            this.comboBox1.DisplayMember = "speciality";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 23);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "sid";
            // 
            // specialityBindingSource1
            // 
            this.specialityBindingSource1.DataMember = "Speciality";
            this.specialityBindingSource1.DataSource = this.hospitalDB_HichamDataSet;
            // 
            // specialityBindingSource
            // 
            this.specialityBindingSource.DataMember = "Speciality";
            this.specialityBindingSource.DataSource = this.hospitalDB_HichamDataSet;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "Appointment";
            this.appointmentBindingSource.DataSource = this.hospitalDB_HichamDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.doctorBindingSource, "clinic_location", true));
            this.comboBox2.DataSource = this.clinicLocationBindingSource;
            this.comboBox2.DisplayMember = "location";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(168, 239);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 23);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.ValueMember = "lid";
            // 
            // clinicLocationBindingSource
            // 
            this.clinicLocationBindingSource.DataMember = "Clinic_Location";
            this.clinicLocationBindingSource.DataSource = this.hospitalDB_HichamDataSet;
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.LightCyan;
            this.txtInfo.Location = new System.Drawing.Point(354, 28);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(469, 146);
            this.txtInfo.TabIndex = 17;
            this.txtInfo.TextChanged += new System.EventHandler(this.txtInfo_TextChanged);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 334);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(didLabel);
            this.Controls.Add(this.didTextBox);
            this.Controls.Add(d_nameLabel);
            this.Controls.Add(this.d_nameTextBox);
            this.Controls.Add(specialityLabel);
            this.Controls.Add(d_genderLabel);
            this.Controls.Add(this.d_genderTextBox);
            this.Controls.Add(d_birthDateLabel);
            this.Controls.Add(this.d_birthDateTextBox);
            this.Controls.Add(clinic_locationLabel);
            this.Controls.Add(d_emailLabel);
            this.Controls.Add(this.d_emailTextBox);
            this.Controls.Add(this.doctorBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDB_HichamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingNavigator)).EndInit();
            this.doctorBindingNavigator.ResumeLayout(false);
            this.doctorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specialityBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicLocationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HospitalDB_HichamDataSet hospitalDB_HichamDataSet;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private HospitalDB_HichamDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private HospitalDB_HichamDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator doctorBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton doctorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox didTextBox;
        private System.Windows.Forms.TextBox d_nameTextBox;
        private System.Windows.Forms.TextBox d_genderTextBox;
        private System.Windows.Forms.TextBox d_birthDateTextBox;
        private System.Windows.Forms.TextBox d_emailTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private HospitalDB_HichamDataSetTableAdapters.AppointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private HospitalDB_HichamDataSetTableAdapters.SpecialityTableAdapter specialityTableAdapter;
        private System.Windows.Forms.BindingSource specialityBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private HospitalDB_HichamDataSetTableAdapters.Clinic_LocationTableAdapter clinic_LocationTableAdapter;
        private System.Windows.Forms.BindingSource clinicLocationBindingSource;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.BindingSource specialityBindingSource1;
    }
}