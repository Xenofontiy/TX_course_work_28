using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX_course_work_28.DataGrid
{
    class DataGrid_time_table
    {
        private string _Hall;
        public string Hall
        {
            get { return _Hall; }
            set { _Hall = value; }
        }

        private int _Time_1;
        public int Time_1 
        { 
            get { return _Time_1; }
            set { _Time_1 = value; }
        }

        private int _Time_2;
        public int Time_2 
        { 
            get { return _Time_2; }
            set { _Time_2 = value; }
        }

        private int _Time_3;
        public int Time_3 
        { 
            get { return _Time_3; }
            set { _Time_3 = value; }
        }

        private int _Time_4;
        public int Time_4 
        { 
            get { return _Time_4; }
            set { _Time_4 = value; }
        }

        private int _Time_5;
        public int Time_5 { 
            get { return _Time_5; }
            set { _Time_5 = value; }
        }


        /*public DataGrid_time_table(string Hall, int Time_1, int Time_2, int Time_3, int Time_4, int Time_5*, int Sum, int Profit)
        {
            this.Hall = Hall;
            this.Time_1 = Time_1;
            this.Time_2 = Time_2;
            this.Time_3 = Time_3;
            this.Time_4 = Time_4;
            this.Time_5 = Time_5;
            this.Sum = Sum;
            this.Profit = Profit; 
        }
        public string Hall { get; set; }
        public int Time_1 { get; set; }
        public int Time_2 { get; set; }
        public int Time_3 { get; set; }
        public int Time_4 { get; set; }
        public int Time_5 { get; set; }
        public int Sum { get; set; }
        public int Profit { get; set; }*/
    }
}

