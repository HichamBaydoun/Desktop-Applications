namespace HichamBaydoun_Project
{
    partial class Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
            this.listApp = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboPatient = new System.Windows.Forms.ComboBox();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDB_HichamDataSet = new HichamBaydoun_Project.HospitalDB_HichamDataSet();
            this.comboDoctor = new System.Windows.Forms.ComboBox();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.patientTableAdapter = new HichamBaydoun_Project.HospitalDB_HichamDataSetTableAdapters.PatientTableAdapter();
            this.doctorTableAdapter = new HichamBaydoun_Project.HospitalDB_HichamDataSetTableAdapters.DoctorTableAdapter();
            this.txtInfo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDB_HichamDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listApp
            // 
            this.listApp.HideSelection = false;
            this.listApp.Location = new System.Drawing.Point(29, 44);
            this.listApp.Margin = new System.Windows.Forms.Padding(2);
            this.listApp.Name = "listApp";
            this.listApp.Size = new System.Drawing.Size(228, 139);
            this.listApp.TabIndex = 14;
            this.listApp.UseCompatibleStateImageBehavior = false;
            this.listApp.SelectedIndexChanged += new System.EventHandler(this.listApp_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Choose Patient:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Choose Doctor:";
            // 
            // comboPatient
            // 
            this.comboPatient.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.patientBindingSource, "pid", true));
            this.comboPatient.DataSource = this.patientBindingSource;
            this.comboPatient.DisplayMember = "p_name";
            this.comboPatient.FormattingEnabled = true;
            this.comboPatient.Location = new System.Drawing.Point(367, 56);
            this.comboPatient.Name = "comboPatient";
            this.comboPatient.Size = new System.Drawing.Size(121, 21);
            this.comboPatient.TabIndex = 20;
            this.comboPatient.ValueMember = "pid";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.hospitalDB_HichamDataSet;
            // 
            // hospitalDB_HichamDataSet
            // 
            this.hospitalDB_HichamDataSet.DataSetName = "HospitalDB_HichamDataSet";
            this.hospitalDB_HichamDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboDoctor
            // 
            this.comboDoctor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.doctorBindingSource, "did", true));
            this.comboDoctor.DataSource = this.doctorBindingSource;
            this.comboDoctor.DisplayMember = "d_name";
            this.comboDoctor.FormattingEnabled = true;
            this.comboDoctor.Location = new System.Drawing.Point(606, 56);
            this.comboDoctor.Name = "comboDoctor";
            this.comboDoctor.Size = new System.Drawing.Size(121, 21);
            this.comboDoctor.TabIndex = 21;
            this.comboDoctor.ValueMember = "did";
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.hospitalDB_HichamDataSet;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Tomato;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(533, 133);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 34);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.SpringGreen;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(423, 133);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 34);
            this.btnInsert.TabIndex = 22;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.LightCyan;
            this.txtInfo.Location = new System.Drawing.Point(29, 232);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(469, 98);
            this.txtInfo.TabIndex = 24;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 397);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.comboDoctor);
            this.Controls.Add(this.comboPatient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listApp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Appointment";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDB_HichamDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listApp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPatient;
        private System.Windows.Forms.ComboBox comboDoctor;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private HospitalDB_HichamDataSet hospitalDB_HichamDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private HospitalDB_HichamDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private HospitalDB_HichamDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private System.Windows.Forms.TextBox txtInfo;
    }
}