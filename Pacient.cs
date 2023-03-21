using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    public enum MonthOfYear
    {
        Январь,
        Февраль,
        Март,
        Апрель,
        Май,
        Июнь,
        Июль,
        Август,
        Сентябрь,
        Октябрь,
        Ноябрь,
        Декабрь
    }
    public class Pacient
    {
        private int _day;
        private int _month;
        private MonthOfYear _monthOfYear = MonthOfYear.Январь;
        private int _year;
        private string _fio;

        public string FIO
        {
            get { return _fio; }
            set
            {
                if (value.IndexOf(' ') > -1)
                {

                    _fio = value;

                }
                else
                {
                    throw new ArgumentException("Введенные инициалы неккоректны");

                }

            }
            
        }
        public int Day
        {
            get { return _day; }
            set
            {
                if (value <= 31)
                {

                    _day = value;
                }
                else
                {
                    throw new ArgumentException("День неккоректен");
                }
            }
        }
        public int Month
        {
            get { return _month; }
            set
            {
                if (value <= 12)
                {

                    _month = value;
                }
                else
                {
                    throw new ArgumentException("Месяц неккоректен");
                }
            }
        }
        public int Year
        {
            get { return _year; }
            set
            {
                if (value >= 1980)
                {
                    _year = value;
                }
                else
                {

                    throw new ArgumentException("Год неккоректен");
                }
            }
        }
        public MonthOfYear MonthsOfYear
        {
            get => _monthOfYear;
        }

        public override string ToString()
        {
            var tmp = new DateTime(1, Month, 1);
            return tmp.ToString("MMMM");
        }
        public int AgeResult(Pacient pacient)
        {
            int age = DateTime.Now.Year - pacient._year;
            if (DateTime.Now.DayOfYear < new DateTime(pacient.Year, pacient.Month, pacient.Day).DayOfYear)
                age--;
            return age;
        }
        public string DateOfBirth(Pacient pacient)
        {
            string dateofbirth = pacient.Day.ToString() + "." + pacient.Month.ToString() + "." + pacient.Year.ToString();
            return dateofbirth;
        }
       
        public Pacient(int Day, int Month, int Year, MonthOfYear monthofyear, string FIO) 
        {
            _day = Day;
            _month = Month;
            _year = Year;
            _monthOfYear = monthofyear;
            _fio = FIO;
            
        }
    }
}
