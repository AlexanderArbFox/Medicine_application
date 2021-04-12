using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_medicine
{
    public partial class PosForm : Form
    {
        int id;
        public PosForm()
        {
            InitializeComponent();
            using (Context db = new Context())
            {
                ExecQuery(db);
                comboBoxPac.DataSource = db.Patients.ToList();
                comboBoxSpec.DataSource = db.Specialists.ToList();
                dateTimePicker.Value = DateTime.Today;
            }
        }
        void ExecQuery(Context db)
        {
            dataGridPos.DataSource = db.Visits.Join(db.Patients, po => po.Id_patient, p => p.Id_patient,
                (po, p) =>
                new
                {
                    po.Id_visited,
                    patient = p.Fio,
                    po.Id_specialist,
                    po.Data_of_visit,
                    po.Conclusion
                }
                ).Join(db.Specialists, pa => pa.Id_specialist, s => s.Id_specialist,
                (pa, s) =>
                new
                {
                    pa.Id_visited,
                    pa.patient,
                    spec = s.Fio,
                    pa.Data_of_visit,
                    pa.Conclusion
                }).ToList();
        }
        private void reload(Context db)
        {
            try
            {
                db.SaveChanges();
                ExecQuery(db);
                dataGridPos.ClearSelection();
                Clear();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Запись данного пациента к специалисту на эту дату уже есть!");
            }
        }

        void Clear()
        {
            dateTimePicker.Value = DateTime.Today;
            txtBoxZakl.Clear();
        }

        private void PosForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medical_examinationDataSet.Specialist". При необходимости она может быть перемещена или удалена.
            this.specialistTableAdapter.Fill(this.medical_examinationDataSet.Specialist);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medical_examinationDataSet.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.medical_examinationDataSet.Patient);

        }

        private void dataGridPos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridPos.SelectedRows[0].Index;
            id = (int)dataGridPos[0, row].Value;

            comboBoxPac.Text = dataGridPos[1, row].Value.ToString();
            comboBoxSpec.Text = dataGridPos[2, row].Value.ToString();
            dateTimePicker.Value = (DateTime)dataGridPos[3, row].Value;
            txtBoxZakl.Text = dataGridPos[4, row].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

            
            using (Context db = new Context())
            {
                db.Visits.Add(new Visit
                {
                    Id_patient = (int)comboBoxPac.SelectedValue,
                    Id_specialist = (int)comboBoxSpec.SelectedValue,
                    Data_of_visit = dateTimePicker.Value,
                    Conclusion = txtBoxZakl.Text
                });
                reload(db);
            }
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                foreach (DataGridViewRow row in dataGridPos.SelectedRows)
                {
                    int id = (int)dataGridPos[0, row.Index].Value;
                    DialogResult answer;
                    Visit delete_pos = db.Visits.Where(po => po.Id_visited == id).FirstOrDefault();
                    Specialist delete_s = db.Specialists.Where(s => s.Id_specialist == delete_pos.Id_specialist).FirstOrDefault();
                    Patient delete_p = db.Patients.Where(p => p.Id_patient == delete_pos.Id_patient).FirstOrDefault();
                    answer = MessageBox.Show($"Удалить запись на {delete_pos.Data_of_visit.ToShortDateString()} " +
                        $"к {delete_s.Fio} пациента {delete_p.Fio}?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (answer == (DialogResult)6)
                    {
                        db.Visits.Remove(delete_pos);
                    }
                }
                reload(db);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                Visit update_pos = db.Visits.Where(po => po.Id_visited == id).FirstOrDefault();
                update_pos.Id_patient = (int)comboBoxPac.SelectedValue;
                update_pos.Id_specialist = (int)comboBoxSpec.SelectedValue;
                update_pos.Data_of_visit = dateTimePicker.Value;
                update_pos.Conclusion = txtBoxZakl.Text;
                reload(db);
            }
        }
    }
}
