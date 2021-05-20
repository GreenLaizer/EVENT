using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Event
{
    class timer
        {

            private void timer1_Tick(object sender, EventArgs e)
            {
                int h = DateTime.Now.Hour;
                int m = DateTime.Now.Minute;
                int s = DateTime.Now.Second;

                string time = "";

                if (h < 10)
                {
                    time += "0" + h;
                }
                else
                {
                    time += h;
                }

                time += ":";

                if (m < 10)
                {
                    time += "0" + m;
                }
                else
                {
                    time += m;
                }

                time += ":";

                if (s < 10)
                {
                    time += "0" + s;
                }
                else
                {
                    time += s;
                }


                string data = "";

                int day = DateTime.Now.Day;
                int month = DateTime.Now.Month;
                int year = DateTime.Now.Year;

                if (day < 10)
                {
                    data += "0" + day;
                }
                else
                {
                    data += day;
                }
                data += ".";
                if (month < 10)
                {
                    data += "0" + month;
                }
                else
                {
                    data += month;
                }
                data += ".";
                data += year;

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void label2_Click(object sender, EventArgs e)
            {

            }
        
    }
}
