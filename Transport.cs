using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_1
{
    class Transport
    {
        // Приватная переменная для хранения марок автомобилей
        private string name;
       
        // Коллекция водителей 
        private List<Driver> drivers = new List<Driver>();
       

        // Конструктор класса Transport
        public Transport()
        {
            this.name = "";
          
        }

        public Transport(string name)
        {
            this.name = name;
          
        }

        // Свойство для доступа к приватной переменной с маркой автомобиля
       public string Car
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

    public Driver GetDriver()
        {
            return drivers[drivers.Count - 1];
        }


     public Driver AddDriver(Driver d)
            {
                
                drivers.Add(d);
                MessageBox.Show("Водитель " + d.FIO +  " добавлен к транспорту " + this.Car + " " );
                return drivers[drivers.Count - 1];
            }
        } 
    }

