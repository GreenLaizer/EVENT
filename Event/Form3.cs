using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event
{
    public partial class Form3 : Form
    {
        public List<Event> holidays = new List<Event>();
        Event selEvent;


        public Form3()
        {
            InitializeComponent();

        }
        public override void Refresh()
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            holidays.Remove(listBox1.SelectedItem as Event);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selEvent = listBox1.SelectedItem as Event;
            dateTimePicker1.Value = selEvent.Getdate();


        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            holidays.Add(new Event("25 Ноября. ПН", Convert.ToDateTime("2020-11-23T00:00:00")));


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selEvent != null)
            {
                selEvent.SetDateTime(dateTimePicker1.Value);

            }
            listBox1.Items.Add(holidays[1]);

            listBox1.BeginUpdate();
            foreach (var item in holidays)
            {
                if (DateTime.Compare(DateTime.Today, item.Getdate().Date) == 0)
                {

                    listBox1.Items.Add(item);
                }


            }
            listBox1.EndUpdate();



        }
    }
     
}
