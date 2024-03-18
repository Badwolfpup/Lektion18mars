using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lektion18mars
{
    public class Uppgifter
    {
        public string Uppgift { get; set; }

        public string Datum { get; set; }

        public string Tid { get; set; }

        public  Timer Alarm { get; set; }

        public Uppgifter(string uppgift, string datum, string tid)
        {
            Uppgift = uppgift;
            Datum = datum;
            Tid = tid;   
            SetTimer();
        }

        private void SetTimer()
        {
            TimeSpan TidTillAlarm = (DateTime.Parse(Datum).Date + DateTime.Parse(Tid).TimeOfDay) - DateTime.Now;
            
            int sekunder = (int)TidTillAlarm.TotalSeconds +1;
            if (sekunder < 60) sekunder = 60;
            Alarm = new Timer(VisaMeddelande, null, sekunder, Timeout.Infinite);
        }

        private void VisaMeddelande(object state)
        {
            MessageBox.Show(Uppgift);
        }
    }
}
