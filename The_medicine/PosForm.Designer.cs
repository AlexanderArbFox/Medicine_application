namespace The_medicine
{
    partial class PosForm
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSpec = new System.Windows.Forms.ComboBox();
            this.comboBoxPac = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxZakl = new System.Windows.Forms.TextBox();
            this.dataGridPos = new System.Windows.Forms.DataGridView();
            this.Код_посещения = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Пациент = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Специалист = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Заключение = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medical_examinationDataSet = new The_medicine.Medical_examinationDataSet();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new The_medicine.Medical_examinationDataSetTableAdapters.PatientTableAdapter();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialistTableAdapter = new The_medicine.Medical_examinationDataSetTableAdapters.SpecialistTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_examinationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(650, 793);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker.TabIndex = 55;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(982, 910);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(297, 35);
            this.btnUpdate.TabIndex = 54;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(982, 849);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(297, 35);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(982, 793);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(297, 35);
            this.btnInsert.TabIndex = 52;
            this.btnInsert.Text = "Добавить";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 767);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Специалист";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 767);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Пациент";
            // 
            // comboBoxSpec
            // 
            this.comboBoxSpec.DataSource = this.specialistBindingSource;
            this.comboBoxSpec.DisplayMember = "Fio";
            this.comboBoxSpec.FormattingEnabled = true;
            this.comboBoxSpec.Location = new System.Drawing.Point(334, 791);
            this.comboBoxSpec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSpec.Name = "comboBoxSpec";
            this.comboBoxSpec.Size = new System.Drawing.Size(295, 28);
            this.comboBoxSpec.TabIndex = 49;
            this.comboBoxSpec.ValueMember = "Код_специалиста";
            // 
            // comboBoxPac
            // 
            this.comboBoxPac.DataSource = this.patientBindingSource;
            this.comboBoxPac.DisplayMember = "Fio";
            this.comboBoxPac.FormattingEnabled = true;
            this.comboBoxPac.Location = new System.Drawing.Point(13, 791);
            this.comboBoxPac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxPac.Name = "comboBoxPac";
            this.comboBoxPac.Size = new System.Drawing.Size(295, 28);
            this.comboBoxPac.TabIndex = 48;
            this.comboBoxPac.ValueMember = "Код_пациента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(645, 770);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 875);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Заключение";
            // 
            // txtBoxZakl
            // 
            this.txtBoxZakl.Location = new System.Drawing.Point(132, 849);
            this.txtBoxZakl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxZakl.Multiline = true;
            this.txtBoxZakl.Name = "txtBoxZakl";
            this.txtBoxZakl.Size = new System.Drawing.Size(816, 96);
            this.txtBoxZakl.TabIndex = 45;
            // 
            // dataGridPos
            // 
            this.dataGridPos.AutoGenerateColumns = false;
            this.dataGridPos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Код_посещения,
            this.Пациент,
            this.Специалист,
            this.Дата,
            this.Заключение,
            this.fioDataGridViewTextBoxColumn});
            this.dataGridPos.DataSource = this.specialistBindingSource;
            this.dataGridPos.Location = new System.Drawing.Point(3, 1);
            this.dataGridPos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridPos.Name = "dataGridPos";
            this.dataGridPos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPos.Size = new System.Drawing.Size(1918, 683);
            this.dataGridPos.TabIndex = 44;
            this.dataGridPos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPos_CellClick);
            // 
            // Код_посещения
            // 
            this.Код_посещения.DataPropertyName = "Код_посещения";
            this.Код_посещения.Frozen = true;
            this.Код_посещения.HeaderText = "Код_посещения";
            this.Код_посещения.Name = "Код_посещения";
            this.Код_посещения.ReadOnly = true;
            this.Код_посещения.Visible = false;
            // 
            // Пациент
            // 
            this.Пациент.DataPropertyName = "Пациент";
            this.Пациент.Frozen = true;
            this.Пациент.HeaderText = "Пациент";
            this.Пациент.Name = "Пациент";
            this.Пациент.ReadOnly = true;
            this.Пациент.Width = 225;
            // 
            // Специалист
            // 
            this.Специалист.DataPropertyName = "Специалист";
            this.Специалист.HeaderText = "Специалист";
            this.Специалист.Name = "Специалист";
            this.Специалист.ReadOnly = true;
            this.Специалист.Width = 225;
            // 
            // Дата
            // 
            this.Дата.DataPropertyName = "Дата";
            this.Дата.HeaderText = "Дата";
            this.Дата.Name = "Дата";
            this.Дата.ReadOnly = true;
            this.Дата.Width = 80;
            // 
            // Заключение
            // 
            this.Заключение.DataPropertyName = "Заключение";
            this.Заключение.HeaderText = "Заключение";
            this.Заключение.Name = "Заключение";
            this.Заключение.ReadOnly = true;
            this.Заключение.Width = 200;
            // 
            // medical_examinationDataSet
            // 
            this.medical_examinationDataSet.DataSetName = "Medical_examinationDataSet";
            this.medical_examinationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.medical_examinationDataSet;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "Fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "Fio";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            // 
            // specialistBindingSource
            // 
            this.specialistBindingSource.DataMember = "Specialist";
            this.specialistBindingSource.DataSource = this.medical_examinationDataSet;
            // 
            // specialistTableAdapter
            // 
            this.specialistTableAdapter.ClearBeforeFill = true;
            // 
            // PosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1924, 952);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSpec);
            this.Controls.Add(this.comboBoxPac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxZakl);
            this.Controls.Add(this.dataGridPos);
            this.Name = "PosForm";
            this.Text = "Посещения";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_examinationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialistBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSpec;
        private System.Windows.Forms.ComboBox comboBoxPac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxZakl;
        private System.Windows.Forms.DataGridView dataGridPos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Код_посещения;
        private System.Windows.Forms.DataGridViewTextBoxColumn Пациент;
        private System.Windows.Forms.DataGridViewTextBoxColumn Специалист;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата;
        private System.Windows.Forms.DataGridViewTextBoxColumn Заключение;
        private Medical_examinationDataSet medical_examinationDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private Medical_examinationDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource specialistBindingSource;
        private Medical_examinationDataSetTableAdapters.SpecialistTableAdapter specialistTableAdapter;
    }
}