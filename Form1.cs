using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_1
{
    public partial class Form1 : Form
    {
        private Firm Firm;
        private Transport trans;
        
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Firm = new Firm(textBox1.Text);
            //Firm.Add(new Firm(textBox1.Text));
        }
            
    private void button2_Click(object sender, EventArgs e)
            
         {
             trans = new Transport(textBox2.Text);
             Firm.AddTransport(transport);

          // Transport.Add(new Firm(textBox1.Text), new Transport(textBox2.Text));
         }
        
       private void button3_Click(object sender, EventArgs e)
        {
          
            Driver drivs = new Driver(textBox3.Tex
            trans.AddDriver(drivs);               

          //  Driver.Add(new Firm(textBox1.Text), new Transport(textBox2.Text), new Driver(textBox3.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В фирме " + Firm.CompanyName + " с транспортом " + Firm.AddTransport(trans).Car + 
                " связан водитель" + Firm.AddTransport(trans).GetDriver );
                
                //trans.Car + " связан водитель " + trans.GetDriver().FIO);
         //По нажатию кнопки отображается ее водитель и ее транспорт.   
        }


    }
}

