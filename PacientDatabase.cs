using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    public class PacientDatabase
        
    {
        
        public List<Pacient> Pacients { get; private set; }
        
        public void Initialize()
        {
            Pacients = new List<Pacient>
            {
                new Pacient(18,11,2004, MonthOfYear.Ноябрь,"Пик Джеймс"),
                new Pacient(5,4,2000,MonthOfYear.Апрель,"Рик Деймс"),
                new Pacient(1,12,1998,MonthOfYear.Декабрь,"Кикик Реймс"),
                new Pacient(8,1,1990,MonthOfYear.Январь, "Рири Веймс"),
                new Pacient(22,7,2005,MonthOfYear.Июль, "Ри Ееймс")
             

            };
            
        }
    }
}

