using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Event
{
    public partial class Form2 : Form
    {
        List<Event> editList;
        Form1 mainform;
        Event selEvent;
        

        public Form2(Form1 mform)
        {
            InitializeComponent();
            mainform = mform;
            if (mainform.EditType == 1)
            {
                editList = mainform.holidays;
                Text = "Редактировать Праздники";
                edTime.Visible = false;
            }
            else
            {
                editList = mainform.events;
                Text = "Редактировать события";
                edTime.Visible = true; ;
            }


            foreach (var item in editList)
            {
                listBox1.Items.Add(item);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            editList.Remove(listBox1.SelectedItem as Event);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DateTime dt = DateTime.Now;

            if (mainform.EditType == 1)
            {
                dt = dt.Date;
            }
            


            Event item = new Event(edName.Text, dt);
            
            

           

            editList.Add(item);

            listBox1.Items.Add(item);


            //listBox1.BeginUpdate();
            //foreach (var item in editList)
            //{
            //    if (DateTime.Compare(DateTime.Today, item.Getdate().Date) == 0)
            //    {

            //        listBox1.Items.Add(item);
            //    }


            //}
            //listBox1.EndUpdate();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                Event item = listBox1.SelectedItem as Event;
                edName.Text = item.Getname();
                edDate.Value = item.Getdate().Date;
                edTime.Text = item.Getdate().TimeOfDay.ToString();


            }


        }

        private void edChange_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                Event item = listBox1.SelectedItem as Event;
                item.Setname(edName.Text);
                DateTime dt = edDate.Value;

                if (mainform.EditType == 1)
                {
                    TimeSpan tm = TimeSpan.Parse(edTime.Text);
                    dt = dt.Add(tm);
                }

                item.SetDateTime(dt);

            }
        }
    }
}
