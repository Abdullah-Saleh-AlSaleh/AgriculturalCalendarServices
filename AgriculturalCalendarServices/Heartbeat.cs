using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace AgriculturalCalendarServices
{
   public  class Heartbeat
    { 
        private readonly System.Timers.Timer _timer;
        public Heartbeat()
        {
            _timer = new System.Timers.Timer(10000) { AutoReset=true};
            _timer.Elapsed += _timer_Elapsed;
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {

                    NotifyIcon notifyIcon1 = new NotifyIcon();
            CultureInfo CurrentCulture = CultureInfo.GetCultureInfo("ar-AE");
            CultureInfo SA = CultureInfo.GetCultureInfo("ar-SA");
            HijriCalendar hijri1 = new HijriCalendar();
            int m = Convert.ToInt32(DateTime.Now.ToString("yyyy", CurrentCulture));
            DateTime date = DateTime.Now;
            int Now = hijri1.GetYear(date);
            int NewYear;

            string Addhijri1 = hijri1.AddYears(DateTime.Now, 1).ToString("yyyy");
            DateTime IFDATE1 = DateTime.Now;
            DateTime IFDATE2 = new DateTime(m, 12, 28);
            int IfDates1 = Convert.ToInt32(IFDATE1.ToString("yyyyMMdd"));
            int IfDates2 = Convert.ToInt32(IFDATE2.ToString("yyyyMMdd"));
            //string AddYears = DateTime.Now.AddYears(1).ToString("yyyy", CurrentCulture);

            if (IfDates1 > IfDates2)
            {
                HijriCalendar hijri = new HijriCalendar();
                //int NewYears = Convert.ToInt32(AddYears);
                int NewYears = Convert.ToInt32(Addhijri1);
                DateTime dt1 = new DateTime(NewYears, 1, 1, hijri);
                DateTime dt2 = new DateTime(NewYears, 2, 1, hijri);
                DateTime dt3 = new DateTime(NewYears, 3, 1, hijri);
                DateTime dt4 = new DateTime(NewYears, 4, 1, hijri);
                DateTime dt5 = new DateTime(NewYears, 5, 1, hijri);
                DateTime dt6 = new DateTime(NewYears, 6, 1, hijri);
                DateTime dt7 = new DateTime(NewYears, 7, 1, hijri);
                DateTime dt8 = new DateTime(NewYears, 8, 1, hijri);
                DateTime dt9 = new DateTime(NewYears, 9, 1, hijri);
                DateTime dt10 = new DateTime(NewYears, 10, 1, hijri);
                DateTime dt11 = new DateTime(NewYears, 11, 1, hijri);
                DateTime dt12 = new DateTime(NewYears, 12, 1, hijri);
                var Data1 = new List<Date>()
            {
                new Date(){Id=1,Month1=dt1,Month2=dt2,Month3=dt3,Month4=dt4,Month5=dt5,Month6=dt6,Month7=dt7,Month8=dt8,Month9=dt9,Month10=dt10,Month11=dt11,Month12=dt12}


            };
                foreach (var item in Data1)
                {
                    int DateNow, ToInt1, ToInt2, ToInt3, ToInt4, ToInt5, ToInt6, ToInt7, ToInt8, ToInt9, ToInt10, ToInt11, ToInt12;
                    //   DateNow = Convert.ToInt32(Convert.ToString(hijri.GetYear(DateTime.Now)+hijri.GetMonth(DateTime.Now)+hijri.GetDayOfMonth(DateTime.Now)).Replace("+",""));
                    DateNow = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd", SA));
                    ToInt1 = Convert.ToInt32(item.Month1.ToString("yyyyMMdd", SA));
                    ToInt2 = Convert.ToInt32(item.Month2.ToString("yyyyMMdd", SA));
                    ToInt3 = Convert.ToInt32(item.Month3.ToString("yyyyMMdd", SA));
                    ToInt4 = Convert.ToInt32(item.Month4.ToString("yyyyMMdd", SA));
                    ToInt5 = Convert.ToInt32(item.Month5.ToString("yyyyMMdd", SA));
                    ToInt6 = Convert.ToInt32(item.Month6.ToString("yyyyMMdd", SA));
                    ToInt7 = Convert.ToInt32(item.Month7.ToString("yyyyMMdd", SA));
                    ToInt8 = Convert.ToInt32(item.Month8.ToString("yyyyMMdd", SA));
                    ToInt9 = Convert.ToInt32(item.Month9.ToString("yyyyMMdd", SA));
                    ToInt10 = Convert.ToInt32(item.Month10.ToString("yyyyMMdd", SA));
                    ToInt11 = Convert.ToInt32(item.Month11.ToString("yyyyMMdd", SA));
                    ToInt12 = Convert.ToInt32(item.Month12.ToString("yyyyMMdd", SA));
             
                    if (DateNow == ToInt1)
                    {

                        //this.Hide();

                        notifyIcon1.ShowBalloonTip(1000, item.Month1.ToString("MMM"), "شهر جديد ", ToolTipIcon.Info);
                    }
                    if (DateNow == ToInt2)
                    {
                        //  this.Hide();
                        notifyIcon1.ShowBalloonTip(1000, item.Month2.ToString("MMM"), "فلفل ", ToolTipIcon.Info);
                    }
                    if (DateNow == ToInt3)
                    {
                        //  this.Hide();
                        notifyIcon1.ShowBalloonTip(1000, item.Month3.ToString("MMM"), "الملوخية,شمام ", ToolTipIcon.Info);
                    }
                    if (DateNow == ToInt4)
                    {
                        //  this.Hide();
                        notifyIcon1.ShowBalloonTip(1000, item.Month4.ToString("MMM"), "شهر جديد  ", ToolTipIcon.Info);
                    }
                    if (DateNow == ToInt5)
                    {
                        // this.Hide();
                        notifyIcon1.ShowBalloonTip(1000, item.Month5.ToString("MMM"), "الملوخية ", ToolTipIcon.Info);
                    }
                    if (DateNow == ToInt6)
                    {
                      
                        notifyIcon1.ShowBalloonTip(1000, item.Month6.ToString("MMM"), "شهر جديد  ", ToolTipIcon.Info);
                    }
                    if (DateNow == ToInt7)
                    {
                        //  this.Hide();
                        notifyIcon1.ShowBalloonTip(1000, item.Month7.ToString("MMM"), "شهر جديد  ", ToolTipIcon.Info);
                    }
                    if (DateNow == ToInt8)
                    {
                       
                        notifyIcon1.ShowBalloonTip(1000, item.Month8.ToString("MMM"), "الفراولة,خيار,الزهرة,الملفوف", ToolTipIcon.Info);
                    }
                    if (DateNow == ToInt9)
                    {
                        // this.Hide();
                        notifyIcon1.ShowBalloonTip(1000, item.Month9.ToString("MMM"), "طماطم و باذنجان و فلفل ", ToolTipIcon.Info);
                    }
                    if (DateNow == ToInt10)
                    {
                        // this.Hide();
                        notifyIcon1.ShowBalloonTip(1000, item.Month10.ToString("MMM"), "كزبرة بقدونس ", ToolTipIcon.Info);
                    }
                    if (DateNow == ToInt11)
                    {
                        //  this.Hide();
                        notifyIcon1.ShowBalloonTip(1000, item.Month11.ToString("MMM"), "شمندر سبائخ ", ToolTipIcon.Info);
                    }
                    if (DateNow == ToInt12)
                    {
                        //  this.Hide();
                        notifyIcon1.ShowBalloonTip(1000, item.Month12.ToString("MMM"), "شهر جديد  ", ToolTipIcon.Info);
                    }

                }
            }
            else
            {
                DateTime dt1 = new DateTime(Now, 1, 1, hijri1);
                DateTime dt2 = new DateTime(Now, 2, 1, hijri1);
                DateTime dt3 = new DateTime(Now, 3, 1, hijri1);
                DateTime dt4 = new DateTime(Now, 4, 1, hijri1);
                DateTime dt5 = new DateTime(Now, 5, 1, hijri1);
                DateTime dt6 = new DateTime(Now, 6, 1, hijri1);
                DateTime dt7 = new DateTime(Now, 7, 1, hijri1);
                DateTime dt8 = new DateTime(Now, 8, 1, hijri1);
                DateTime dt9 = new DateTime(Now, 9, 1, hijri1);
                DateTime dt10 = new DateTime(Now, 10, 1, hijri1);
                DateTime dt11 = new DateTime(Now, 11, 1, hijri1);
                DateTime dt12 = new DateTime(Now, 12, 1, hijri1);
                var Data1 = new List<Date>()
            {
                new Date(){Id=1,Month1=dt1,Month2=dt2,Month3=dt3,Month4=dt4,Month5=dt5,Month6=dt6,Month7=dt7,Month8=dt8,Month9=dt9,Month10=dt10,Month11=dt11,Month12=dt12}


            };
                foreach (var item in Data1)
                {
                    int DateNow, ToInt1, ToInt2, ToInt3, ToInt4, ToInt5, ToInt6, ToInt7, ToInt8, ToInt9, ToInt10, ToInt11, ToInt12;
                    //   DateNow = Convert.ToInt32(Convert.ToString(hijri.GetYear(DateTime.Now)+hijri.GetMonth(DateTime.Now)+hijri.GetDayOfMonth(DateTime.Now)).Replace("+",""));
                    DateNow = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd", SA));
                    ToInt1 = Convert.ToInt32(item.Month1.ToString("yyyyMMdd", SA));
                    ToInt2 = Convert.ToInt32(item.Month2.ToString("yyyyMMdd", SA));
                    ToInt3 = Convert.ToInt32(item.Month3.ToString("yyyyMMdd", SA));
                    ToInt4 = Convert.ToInt32(item.Month4.ToString("yyyyMMdd", SA));
                    ToInt5 = Convert.ToInt32(item.Month5.ToString("yyyyMMdd", SA));
                    ToInt6 = Convert.ToInt32(item.Month6.ToString("yyyyMMdd", SA));
                    ToInt7 = Convert.ToInt32(item.Month7.ToString("yyyyMMdd", SA));
                    ToInt8 = Convert.ToInt32(item.Month8.ToString("yyyyMMdd", SA));
                    ToInt9 = Convert.ToInt32(item.Month9.ToString("yyyyMMdd", SA));
                    ToInt10 = Convert.ToInt32(item.Month10.ToString("yyyyMMdd", SA));
                    ToInt11 = Convert.ToInt32(item.Month11.ToString("yyyyMMdd", SA));
                    ToInt12 = Convert.ToInt32(item.Month12.ToString("yyyyMMdd", SA));
    

                    if (DateNow == ToInt1)
                    {

                        //this.Hide();

                        notifyIcon1.ShowBalloonTip(1000, item.Month1.ToString("MMM"), "شهر جديد ", ToolTipIcon.Info);
                    }
                    if (DateNow == ToInt2)
                    {
                        //  this.Hide();
                        notifyIcon1.ShowBalloonTip(1000, item.Month2.ToString("MMM"), "فلفل ", ToolTipIcon.Info);
                    }
                    if (DateNow == ToInt3)
                    {
                        //  this.Hide();
                        notifyIcon1.ShowBalloonTip(1000, item.Month3.ToString("MMM"), "الملوخية,شمام ", ToolTipIcon.Info);
                    }
                    if (DateNow == ToInt4)
                    {
                        //  this.Hide();
                        notifyIcon1.ShowBalloonTip(1000, item.Month4.ToString("MMM"), "شهر جديد  ", ToolTipIcon.Info);
                    }
                    if (DateNow == ToInt5)
                    {
                        // this.Hide();
                        notifyIcon1.ShowBalloonTip(1000, item.Month5.ToString("MMM"), "الملوخية ", ToolTipIcon.Info);
                    }
                    if (DateNow == ToInt6)
                    {
                     
                        notifyIcon1.ShowBalloonTip(1000, item.Month6.ToString("MMM"), "شهر جديد  ", ToolTipIcon.Info);
                    }
                    if (DateNow == ToInt7)
                    {
                        //  this.Hide();
                        notifyIcon1.ShowBalloonTip(1000, item.Month7.ToString("MMM"), "شهر جديد  ", ToolTipIcon.Info);
                    }
                    if (DateNow == ToInt8)
                    {
                     
                        notifyIcon1.ShowBalloonTip(1000, item.Month8.ToString("MMM"), "الفراولة,خيار,الزهرة,الملفوف", ToolTipIcon.Info);
                    }
                    if (DateNow == ToInt9)
                    {
                        // this.Hide();
                        notifyIcon1.ShowBalloonTip(1000, item.Month9.ToString("MMM"), "طماطم و باذنجان و فلفل ", ToolTipIcon.Info);
                    }
                    if (DateNow == ToInt10)
                    {
                        // this.Hide();
                        notifyIcon1.ShowBalloonTip(1000, item.Month10.ToString("MMM"), "كزبرة بقدونس ", ToolTipIcon.Info);
                    }
                    if (DateNow == ToInt11)
                    {
                        //  this.Hide();
                        notifyIcon1.ShowBalloonTip(1000, item.Month11.ToString("MMM"), "شمندر سبائخ ", ToolTipIcon.Info);
                    }
                    if (DateNow == ToInt12)
                    {
                        //  this.Hide();
                        notifyIcon1.ShowBalloonTip(1000, item.Month12.ToString("MMM"), "شهر جديد  ", ToolTipIcon.Info);
                    }

                }
            }





        }
        public void Start()
        {
            _timer.Start();
        }
        public void Stop()
        {
            _timer.Stop(); 
        }
    }
}
