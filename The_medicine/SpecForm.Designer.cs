namespace The_medicine
{
    partial class SpecForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxFIO = new System.Windows.Forms.TextBox();
            this.txtBoxCabinet = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dataGridSpec = new System.Windows.Forms.DataGridView();
            this.idspecialistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameofspecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofroomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medical_examinationDataSet = new The_medicine.Medical_examinationDataSet();
            this.specialistTableAdapter = new The_medicine.Medical_examinationDataSetTableAdapters.SpecialistTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSpec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_examinationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1447, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1449, 280);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Кабинет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1447, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Название специальности";
            // 
            // txtBoxFIO
            // 
            this.txtBoxFIO.Location = new System.Drawing.Point(1452, 155);
            this.txtBoxFIO.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxFIO.Name = "txtBoxFIO";
            this.txtBoxFIO.Size = new System.Drawing.Size(458, 26);
            this.txtBoxFIO.TabIndex = 38;
            // 
            // txtBoxCabinet
            // 
            this.txtBoxCabinet.Location = new System.Drawing.Point(1453, 304);
            this.txtBoxCabinet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxCabinet.Name = "txtBoxCabinet";
            this.txtBoxCabinet.Size = new System.Drawing.Size(457, 26);
            this.txtBoxCabinet.TabIndex = 37;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(1452, 34);
            this.txtBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(457, 26);
            this.txtBoxName.TabIndex = 36;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1753, 450);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 35);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1597, 450);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(147, 35);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(1451, 450);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(138, 35);
            this.btnInsert.TabIndex = 33;
            this.btnInsert.Text = "Добавить";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dataGridSpec
            // 
            this.dataGridSpec.AutoGenerateColumns = false;
            this.dataGridSpec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSpec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idspecialistDataGridViewTextBoxColumn,
            this.nameofspecDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.numberofroomDataGridViewTextBoxColumn});
            this.dataGridSpec.DataSource = this.specialistBindingSource;
            this.dataGridSpec.Location = new System.Drawing.Point(4, 4);
            this.dataGridSpec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridSpec.Name = "dataGridSpec";
            this.dataGridSpec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSpec.Size = new System.Drawing.Size(1435, 826);
            this.dataGridSpec.TabIndex = 32;
            this.dataGridSpec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSpec_CellClick);
            // 
            // idspecialistDataGridViewTextBoxColumn
            // 
            this.idspecialistDataGridViewTextBoxColumn.DataPropertyName = "Id_specialist";
            this.idspecialistDataGridViewTextBoxColumn.HeaderText = "Id_specialist";
            this.idspecialistDataGridViewTextBoxColumn.Name = "idspecialistDataGridViewTextBoxColumn";
            this.idspecialistDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameofspecDataGridViewTextBoxColumn
            // 
            this.nameofspecDataGridViewTextBoxColumn.DataPropertyName = "Name_of_spec";
            this.nameofspecDataGridViewTextBoxColumn.HeaderText = "Name_of_spec";
            this.nameofspecDataGridViewTextBoxColumn.Name = "nameofspecDataGridViewTextBoxColumn";
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "Fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "Fio";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            // 
            // numberofroomDataGridViewTextBoxColumn
            // 
            this.numberofroomDataGridViewTextBoxColumn.DataPropertyName = "Number_of_room";
            this.numberofroomDataGridViewTextBoxColumn.HeaderText = "Number_of_room";
            this.numberofroomDataGridViewTextBoxColumn.Name = "numberofroomDataGridViewTextBoxColumn";
            // 
            // specialistBindingSource
            // 
            this.specialistBindingSource.DataMember = "Specialist";
            this.specialistBindingSource.DataSource = this.medical_examinationDataSet;
            // 
            // medical_examinationDataSet
            // 
            this.medical_examinationDataSet.DataSetName = "Medical_examinationDataSet";
            this.medical_examinationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialistTableAdapter
            // 
            this.specialistTableAdapter.ClearBeforeFill = true;
            // 
            // SpecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1924, 923);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxFIO);
            this.Controls.Add(this.txtBoxCabinet);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataGridSpec);
            this.Name = "SpecForm";
            this.Text = "Специалисты";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SpecForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSpec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_examinationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxFIO;
        private System.Windows.Forms.TextBox txtBoxCabinet;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView dataGridSpec;
        private Medical_examinationDataSet medical_examinationDataSet;
        private System.Windows.Forms.BindingSource specialistBindingSource;
        private Medical_examinationDataSetTableAdapters.SpecialistTableAdapter specialistTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idspecialistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofspecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofroomDataGridViewTextBoxColumn;
    }
}