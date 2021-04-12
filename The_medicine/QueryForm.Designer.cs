namespace The_medicine
{
    partial class QueryForm
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxQuery = new System.Windows.Forms.ComboBox();
            this.btnExec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSpec = new System.Windows.Forms.ComboBox();
            this.dataGridQuery = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(1526, 213);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker.TabIndex = 48;
            // 
            // comboBoxQuery
            // 
            this.comboBoxQuery.FormattingEnabled = true;
            this.comboBoxQuery.Items.AddRange(new object[] {
            "Список пациентов мужского пола",
            "Данные о специалистах определённого направления",
            "Информация о посещениях на определённую дату"});
            this.comboBoxQuery.Location = new System.Drawing.Point(13, 11);
            this.comboBoxQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxQuery.Name = "comboBoxQuery";
            this.comboBoxQuery.Size = new System.Drawing.Size(1217, 28);
            this.comboBoxQuery.TabIndex = 47;
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(1263, 7);
            this.btnExec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(178, 35);
            this.btnExec.TabIndex = 46;
            this.btnExec.Text = "Выполнить";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1522, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Дата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1522, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Специальность";
            // 
            // comboBoxSpec
            // 
            this.comboBoxSpec.DisplayMember = "Название";
            this.comboBoxSpec.FormattingEnabled = true;
            this.comboBoxSpec.Location = new System.Drawing.Point(1526, 93);
            this.comboBoxSpec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxSpec.Name = "comboBoxSpec";
            this.comboBoxSpec.Size = new System.Drawing.Size(298, 28);
            this.comboBoxSpec.TabIndex = 43;
            this.comboBoxSpec.ValueMember = "Код_специалиста";
            // 
            // dataGridQuery
            // 
            this.dataGridQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQuery.Location = new System.Drawing.Point(13, 53);
            this.dataGridQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridQuery.Name = "dataGridQuery";
            this.dataGridQuery.Size = new System.Drawing.Size(1459, 575);
            this.dataGridQuery.TabIndex = 42;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1852, 767);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBoxQuery);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSpec);
            this.Controls.Add(this.dataGridQuery);
            this.Name = "QueryForm";
            this.Text = "Запросы";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxQuery;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSpec;
        private System.Windows.Forms.DataGridView dataGridQuery;
    }
}