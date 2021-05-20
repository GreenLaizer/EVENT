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

    public partial class Form1 : Form
    {
        // <items>
        // <item text = "Новости 2" date = "21.01.2020">
        // <item text = "Новости 2" date = "21.01.2020">
        // </items>
        public List<Event> events = new List<Event>();
        public List<Event> holidays = new List<Event>();
        public int EditType = 0;
        Event selEvent;
      
        


        public Form1()
        {
            InitializeComponent();
            refresh();

        }

        private void refresh()
        {
            listBox1.Items.Clear();
            foreach (var item in events)
            {
                if (DateTime.Compare(DateTime.Today, item.Getdate().Date) == 0)
                {

                    listBox1.Items.Add(item);
                }


            }
            listBox2.Items.Clear();
            listBox2.BeginUpdate();
            foreach (var item in holidays)
            {
                if (DateTime.Compare(DateTime.Today, item.Getdate().Date) == 0)
                {

                    listBox2.Items.Add(item);
                }


            }
            listBox2.EndUpdate();


        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.EditType = 0;
            Form2 newForm = new Form2(this);
            newForm.ShowDialog();
            refresh();
        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            events.Remove(listBox1.SelectedItem as Event);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selEvent = listBox1.SelectedItem as Event;
            dateTimePicker1.Value = selEvent.Getdate();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selEvent != null)
            {
                selEvent.SetDateTime(dateTimePicker1.Value);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.EditType = 1;
            Form2 newForm = new Form2(this);
            newForm.ShowDialog();
            refresh();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadEvent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void LoadEvent()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("xmltext.xml");
            foreach (XmlNode node in doc.DocumentElement)
            {
                string name = node.Attributes.GetNamedItem("name").Value;
                DateTime dt = Convert.ToDateTime(node.Attributes.GetNamedItem("datetime").Value);
                var isEvent = Convert.ToBoolean(node.Attributes.GetNamedItem("event").Value);
                if (isEvent) 
                    events.Add(new Event(name, dt));
                else
                    holidays.Add(new Event(name, dt));

                
                //listBox1.Items.Add(new Event(name, DateTime datetime));
            }

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            refresh();

        }
        private void SaveEvent()
        {
            XmlDocument doc = new XmlDocument();

            XmlElement root = doc.CreateElement("events");
            var en = doc.CreateXmlDeclaration("1.0", "utf-8", "");
            doc.AppendChild(en);
            doc.AppendChild(root);

            foreach (var item in events)
            {
                XmlElement ev = doc.CreateElement("Event");
                ev.SetAttribute("name", item.Getname());
                ev.SetAttribute("datetime", item.Getdate().ToString());
                ev.SetAttribute("event", true.ToString());
                root.AppendChild(ev);

            }
            foreach (var item in holidays)
            {
                XmlElement ev = doc.CreateElement("Event");
                ev.SetAttribute("name", item.Getname());
                ev.SetAttribute("datetime", item.Getdate().ToString());
                ev.SetAttribute("event", false.ToString());
                root.AppendChild(ev);

            }

            doc.Save("xmltext.xml");




        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveEvent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
     
   
}





