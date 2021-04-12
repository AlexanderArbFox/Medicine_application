namespace The_medicine
{
    partial class PatientForm
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
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxSerial = new System.Windows.Forms.TextBox();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxFIO = new System.Windows.Forms.TextBox();
            this.dataGridPatient = new System.Windows.Forms.DataGridView();
            this.idpatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriasofpasportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofpasportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medical_examinationDataSet = new The_medicine.Medical_examinationDataSet();
            this.patientTableAdapter = new The_medicine.Medical_examinationDataSetTableAdapters.PatientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_examinationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "М",
            "Ж"});
            this.comboBoxGender.Location = new System.Drawing.Point(1477, 143);
            this.comboBoxGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(434, 28);
            this.comboBoxGender.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1470, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Номер паспорта";
            // 
            // txtBoxSerial
            // 
            this.txtBoxSerial.Location = new System.Drawing.Point(1477, 252);
            this.txtBoxSerial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxSerial.MaxLength = 4;
            this.txtBoxSerial.Name = "txtBoxSerial";
            this.txtBoxSerial.Size = new System.Drawing.Size(434, 26);
            this.txtBoxSerial.TabIndex = 56;
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.Location = new System.Drawing.Point(1477, 358);
            this.txtBoxNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxNumber.MaxLength = 6;
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(434, 26);
            this.txtBoxNumber.TabIndex = 55;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1790, 489);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 35);
            this.btnUpdate.TabIndex = 54;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1634, 489);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 35);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(1474, 489);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(132, 35);
            this.btnInsert.TabIndex = 52;
            this.btnInsert.Text = "Добавить";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1472, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Серия паспорта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1472, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1472, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "ФИО";
            // 
            // txtBoxFIO
            // 
            this.txtBoxFIO.Location = new System.Drawing.Point(1477, 34);
            this.txtBoxFIO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxFIO.Name = "txtBoxFIO";
            this.txtBoxFIO.Size = new System.Drawing.Size(434, 26);
            this.txtBoxFIO.TabIndex = 48;
            // 
            // dataGridPatient
            // 
            this.dataGridPatient.AutoGenerateColumns = false;
            this.dataGridPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpatientDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.seriasofpasportDataGridViewTextBoxColumn,
            this.numberofpasportDataGridViewTextBoxColumn});
            this.dataGridPatient.DataSource = this.patientBindingSource;
            this.dataGridPatient.Location = new System.Drawing.Point(4, 2);
            this.dataGridPatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridPatient.Name = "dataGridPatient";
            this.dataGridPatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPatient.Size = new System.Drawing.Size(1443, 1046);
            this.dataGridPatient.TabIndex = 47;
            // 
            // idpatientDataGridViewTextBoxColumn
            // 
            this.idpatientDataGridViewTextBoxColumn.DataPropertyName = "Id_patient";
            this.idpatientDataGridViewTextBoxColumn.HeaderText = "Id_patient";
            this.idpatientDataGridViewTextBoxColumn.Name = "idpatientDataGridViewTextBoxColumn";
            this.idpatientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "Fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "Fio";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // seriasofpasportDataGridViewTextBoxColumn
            // 
            this.seriasofpasportDataGridViewTextBoxColumn.DataPropertyName = "Serias_of_pasport";
            this.seriasofpasportDataGridViewTextBoxColumn.HeaderText = "Serias_of_pasport";
            this.seriasofpasportDataGridViewTextBoxColumn.Name = "seriasofpasportDataGridViewTextBoxColumn";
            // 
            // numberofpasportDataGridViewTextBoxColumn
            // 
            this.numberofpasportDataGridViewTextBoxColumn.DataPropertyName = "Number_of_pasport";
            this.numberofpasportDataGridViewTextBoxColumn.HeaderText = "Number_of_pasport";
            this.numberofpasportDataGridViewTextBoxColumn.Name = "numberofpasportDataGridViewTextBoxColumn";
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.medical_examinationDataSet;
            // 
            // medical_examinationDataSet
            // 
            this.medical_examinationDataSet.DataSetName = "Medical_examinationDataSet";
            this.medical_examinationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxSerial);
            this.Controls.Add(this.txtBoxNumber);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxFIO);
            this.Controls.Add(this.dataGridPatient);
            this.Name = "PatientForm";
            this.Text = "Пациенты";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PatientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_examinationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxSerial;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxFIO;
        private System.Windows.Forms.DataGridView dataGridPatient;
        private Medical_examinationDataSet medical_examinationDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private Medical_examinationDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriasofpasportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofpasportDataGridViewTextBoxColumn;
    }
}