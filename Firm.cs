using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_1
{
    class Firm
    {
       
        // Приватная переменная с названием фирмы
        private string name;
        // Список для хранения транспорта
        private List<Transport> transports = new List<Transport>();

        // Конструктор класса Firm
        public Firm()
        {
            this.name = "";
        }

        public Firm(string name)
        {
            this.name = name;
        }



        private List<Firm> firms = new List<Firm>();

        public Firm Add(Firm f)
        {

            MessageBox.Show("Создана фирма " + f.CompanyName);
            firms.Add(f);
            return firms[firms.Count - 1];
        }

       

        // Свойство для доступа к переменной 
        public string CompanyName
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

        

     
        public Transport AddTransport(Transport transport)
        {
     
            {
         
                transports.Add(transport);
                MessageBox.Show("Траспорт " + transport.Car +  " добавлен в фирму " + this.CompanyName);
                return transports[transports.Count - 1];
            }
           
        }

       
    }
    }

