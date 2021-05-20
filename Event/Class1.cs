using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Event
{
    public class Date
    {
        protected DateTime datetime; // 123123123.123123123


        public Date()
        {
            datetime = DateTime.MinValue;
        }
        public Date(DateTime dt)
        {
            this.datetime = dt;
        }
        public void SetDateTime(DateTime dt)
        {
            this.datetime = dt;
        }
        public DateTime Getdate()
        {
            return datetime;
        }

    }

    public class Event : Date 
        {
        protected string name;

        public Event()
        {
            name = "no name";
            datetime = DateTime.MinValue;
        }
        public Event(string name, DateTime datetime)
        {
            this.name = name;
            this.datetime = datetime;
        }
        public void Setname(string name)
        {
            this.name = name;
        }
        public string  Getname()
        {
            return name;
        }

        public override string ToString()
        {

            if (DateTime.Compare(datetime, datetime.Date) == 0)
                return this.datetime.ToShortTimeString() + ": " + this.name;
            else
                return this.datetime.ToLongDateString() + ": " + this.name;

        }


    }
    
}
