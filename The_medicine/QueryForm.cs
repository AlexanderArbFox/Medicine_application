using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_medicine
{
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
            using (Context db = new Context())
            {
                comboBoxSpec.DataSource = db.Specialists.Select(s => s.Name_of_spec).Distinct().ToList();
            }
        }
        dynamic ExecQuery1(Context db)
        {
            //Вывести список пациентов мужского пола с указанием паспортных данных;
            return db.Patients.Where(p => p.Gender == "М").Select(p =>
            new
            {
                fio = p.Fio,
                p.Serias_of_pasport,
                p.Number_of_pasport
            }).ToList();
        }


        dynamic ExecQuery2(Context db)
        {
            //Отобразить данные (ФИО, номер кабинета) о специалистах 
            //определенного направления (например, окулистах);
            string spec = comboBoxSpec.Text;
            return db.Specialists.Where(s => s.Name_of_spec == spec).Select
                (s =>
                new
                {
                    fio_spec = s.Fio,
                    s.Number_of_room
                }).ToList();
        }

        dynamic ExecQuery3(Context db)
        {
            //Вывести следующую информацию о посещениях на определенную дату: 
            //ФИО пациента, ФИО специалиста, название специалиста, заключение.
            return db.Visits.Where(p => p.Data_of_visit == dateTimePicker.Value.Date)
                .Select(p =>
                new
                {
                    fio_patient = p.Patient.Fio,
                    fio_spec = p.Specialist.Fio,
                    spec = p.Specialist.Name_of_spec,
                    p.Conclusion
                }).ToList();
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            using (Context db = new Context())
            {
                switch (comboBoxQuery.SelectedIndex)
                {
                    case 0: dataGridQuery.DataSource = ExecQuery1(db); break;
                    case 1: dataGridQuery.DataSource = ExecQuery2(db); break;
                    case 2: dataGridQuery.DataSource = ExecQuery3(db); break;
                }
            }
        }
    }
}
