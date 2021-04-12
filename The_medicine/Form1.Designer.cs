namespace The_medicine
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnSpec = new System.Windows.Forms.Button();
            this.btnPos = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQuery.ForeColor = System.Drawing.Color.Teal;
            this.btnQuery.Location = new System.Drawing.Point(148, 315);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(242, 46);
            this.btnQuery.TabIndex = 11;
            this.btnQuery.Text = "Запросы";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnSpec
            // 
            this.btnSpec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSpec.ForeColor = System.Drawing.Color.Teal;
            this.btnSpec.Location = new System.Drawing.Point(148, 151);
            this.btnSpec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSpec.Name = "btnSpec";
            this.btnSpec.Size = new System.Drawing.Size(242, 46);
            this.btnSpec.TabIndex = 10;
            this.btnSpec.Text = "Специалисты";
            this.btnSpec.UseVisualStyleBackColor = true;
            this.btnSpec.Click += new System.EventHandler(this.btnSpec_Click);
            // 
            // btnPos
            // 
            this.btnPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPos.ForeColor = System.Drawing.Color.Teal;
            this.btnPos.Location = new System.Drawing.Point(148, 235);
            this.btnPos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(242, 46);
            this.btnPos.TabIndex = 9;
            this.btnPos.Text = "Посещения";
            this.btnPos.UseVisualStyleBackColor = true;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPatient.ForeColor = System.Drawing.Color.Teal;
            this.btnPatient.Location = new System.Drawing.Point(148, 72);
            this.btnPatient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(242, 46);
            this.btnPatient.TabIndex = 8;
            this.btnPatient.Text = "Пациенты";
            this.btnPatient.UseVisualStyleBackColor = true;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.Teal;
            this.btnClose.Location = new System.Drawing.Point(478, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(74, 59);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnSpec);
            this.Controls.Add(this.btnPos);
            this.Controls.Add(this.btnPatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnSpec;
        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Button btnClose;
    }
}

