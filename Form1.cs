using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace pr2
{
    public partial class Form1 : Form
    {
        private PacientDatabase _pacient;
        public Form1()
        {
            InitializeComponent();
            _pacient = new PacientDatabase();
            _pacient.Initialize();
            comboBox1.Items.AddRange(new object[13] {"Отсутствует", MonthOfYear.Январь,MonthOfYear.Февраль,
            MonthOfYear.Март, MonthOfYear.Апрель, MonthOfYear.Май, MonthOfYear.Июнь, MonthOfYear.Июль,
            MonthOfYear.Август, MonthOfYear.Сентябрь, MonthOfYear.Октябрь, MonthOfYear.Ноябрь,
                MonthOfYear.Декабрь});
            comboBox1.SelectedIndex = 0;
            PacientDataGrid.DataSource = _pacient.Pacients.ToList();
            
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                PacientDataGrid.DataSource = _pacient.Pacients.ToList();
            }
            else
            {
                var initials = _pacient.Pacients.Where(s => s.FIO.ToLower().Contains(textBox1.Text.ToLower())).ToList();
                PacientDataGrid.DataSource = initials;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                PacientDataGrid.DataSource = _pacient.Pacients.ToList();
                return;
            }

            MonthOfYear months = new MonthOfYear();
            switch (comboBox1.SelectedItem)
            {
                case MonthOfYear.Январь:
                    months = MonthOfYear.Январь;
                    break;
                case MonthOfYear.Февраль:
                    months = MonthOfYear.Февраль;
                    break;
                case MonthOfYear.Март:
                    months = MonthOfYear.Март;
                    break;
                case MonthOfYear.Апрель:
                    months = MonthOfYear.Апрель;
                    break;
                case MonthOfYear.Май:
                    months = MonthOfYear.Май;
                    break;
                case MonthOfYear.Июнь:
                    months = MonthOfYear.Июнь;
                    break;
                case MonthOfYear.Июль:
                    months = MonthOfYear.Июль;
                    break;
                case MonthOfYear.Август:
                    months = MonthOfYear.Август;
                    break;
                case MonthOfYear.Сентябрь:
                    months = MonthOfYear.Сентябрь;
                    break;
                case MonthOfYear.Октябрь:
                    months = MonthOfYear.Октябрь;
                    break;
                case MonthOfYear.Ноябрь:
                    months = MonthOfYear.Ноябрь;
                    break;
                case MonthOfYear.Декабрь:
                    months = MonthOfYear.Декабрь;
                    break;
               
            }
            var monthh = _pacient.Pacients.Where(s => s.MonthsOfYear == months).ToList();
            PacientDataGrid.DataSource = monthh;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PacientDataGrid.DataSource = _pacient.Pacients.ToList();
            comboBox1.SelectedIndex = 0;
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var sortAscending = _pacient.Pacients.OrderByDescending(s => s.Year).ToList();
            PacientDataGrid.DataSource = sortAscending;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sortDescending = _pacient.Pacients.OrderBy(s => s.Year).ToList();
            PacientDataGrid.DataSource = sortDescending;
        }
    }
}
