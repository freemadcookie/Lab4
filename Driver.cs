using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_1
{
    class Driver
    {
        // Имя водителя 
        private String name;
       

        // Конструктор класса Driver
        public Driver()
        {
            this.name = ""
           
        }

        public  Driver(string name)
        {
            this.name = name;
        }

        public Driver Add(Firm f, Transport t, Driver d)
        {
            return Add(f, t, d);
        }
        

        // Свойство для доступа к приватной переменной имени водителя
        public string FIO
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }


    }
}
