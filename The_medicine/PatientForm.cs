using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_medicine
{
    public partial class PatientForm : Form
    {
        Regex regexFIO = new Regex(@"^[А-Я][а-я]{0,15}\s[А-Я][а-я]{0,15}\s[А-Я][а-я]{0,15}$");
        Regex regexSerial = new Regex(@"^\d{4}");
        Regex regexNumber = new Regex(@"^\d{6}");
        public PatientForm()
        {
            InitializeComponent();
            using (Context db = new Context())
            {
                dataGridPatient.DataSource = db.Patients.ToList();
            }
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "medical_examinationDataSet.Patient". При необходимости она может быть перемещена или удалена.
            this.patientTableAdapter.Fill(this.medical_examinationDataSet.Patient);             
            dataGridPatient.ClearSelection();
        }
        
        private bool Correct()
        {
            string fio = txtBoxFIO.Text;
            string serial = txtBoxSerial.Text;
            string number = txtBoxNumber.Text;
            if (!regexFIO.IsMatch(fio) || !regexNumber.IsMatch(number) || !regexSerial.IsMatch(serial))
            {
                MessageBox.Show("Некорректные ФИО или паспортные данные!");
                return false;
            }
            else return true;
        }

        private void reload(Context db)
        {
            try
            {
                db.SaveChanges();
                dataGridPatient.DataSource = db.Patients.ToList();
                dataGridPatient.ClearSelection();
                Clear();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Пациент с такими паспортными данными уже есть!");
            }
        }

        void Clear()
        {
            txtBoxFIO.Clear();
            txtBoxSerial.Clear();
            txtBoxNumber.Clear();
        }

        private void dataGridPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridPatient.SelectedRows[0].Index;

            txtBoxFIO.Text = dataGridPatient[1, row].Value.ToString();
            comboBoxGender.Text = dataGridPatient[2, row].Value.ToString();
            txtBoxSerial.Text = dataGridPatient[3, row].Value.ToString();
            txtBoxNumber.Text = dataGridPatient[4, row].Value.ToString();
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            if (Correct())
            {
                using (Context db = new Context())
                {
                    db.Patients.Add(new Patient
                    {
                        Fio = txtBoxFIO.Text,
                        Gender = comboBoxGender.Text,
                        Serias_of_pasport = txtBoxSerial.Text,
                        Number_of_pasport = txtBoxNumber.Text
                    });
                    reload(db);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Correct())
            {
                int id = (int)dataGridPatient[0, dataGridPatient.SelectedRows[0].Index].Value;

                using (Context db = new Context())
                {
                    Patient update_pat = db.Patients.Where(p => p.Id_patient == id).FirstOrDefault();
                    update_pat.Fio = txtBoxFIO.Text;
                    update_pat.Gender = comboBoxGender.Text;
                    update_pat.Serias_of_pasport = txtBoxSerial.Text;
                    update_pat.Number_of_pasport = txtBoxNumber.Text;
                    reload(db);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Correct())
            {
                using (Context db = new Context())
                {
                    foreach (DataGridViewRow row in dataGridPatient.SelectedRows)
                    {
                        DialogResult answer;
                        int id = (int)dataGridPatient[0, row.Index].Value;

                        Patient delete_pat = db.Patients.Where(p => p.Id_patient == id).FirstOrDefault();
                        answer = MessageBox.Show($"Вы действительно хотите удалить пациента {delete_pat.Fio}?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (answer == (DialogResult)6)
                        {
                            db.Patients.Remove(delete_pat);
                        }
                    }
                    reload(db);
                }
            }
        }
    }
}
