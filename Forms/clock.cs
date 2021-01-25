using System;
using System.Windows.Forms;
using System.Timers;

namespace Zachary_Childers_CPT_185_Lab_8.Forms
{
    public partial class clock : Form
    {
        private object dt;
        public clock()
        {
            InitializeComponent();

            try
            {
                label6.Text = DateTime.Now.ToString("tt");
                label7.Text = DateTime.Now.ToString("h:mm");
                label5.Text = DateTime.Now.ToString("dddd");
                labelSECC.Text = DateTime.Now.ToString("ss");
                label4.Text = DateTime.Now.ToString("M/dd/yyyy");
                circularProgressBar2.Value = Convert.ToInt32(labelSECC.Text); //hidden second timer, needed for clock
                                                                              //but not for looks

            }
            catch (Exception)
            {
                return;
            }


            String.Format("{0:y yy yyy yyyy}", dt);  // "8 08 008 2008"   year
            String.Format("{0:M MM MMM MMMM}", dt);  // "3 03 Mar March"  month
            String.Format("{0:d dd ddd dddd}", dt);  // "9 09 Sun Sunday" day
            String.Format("{0:h hh H HH}", dt);  // "4 04 16 " hour 12/24
            String.Format("{0:m mm}", dt);  // "5 05"   minute
            /* String.Format("{0:s ss}", dt);  // "7 07"  /**/     //second
            String.Format("{0:f ff fff ffff}", dt);  // "1 12 123 1230" sec.fraction
            String.Format("{0:F FF FFF FFFF}", dt);  // "1 12 123 123" without zeroes
            String.Format("{0:t tt}", dt);  // "P PM"    A.M. or P.M.
            String.Format("{0:z zz zzz}", dt);  // "-6 -06 -06:00"   time zone


        }
    }
}
