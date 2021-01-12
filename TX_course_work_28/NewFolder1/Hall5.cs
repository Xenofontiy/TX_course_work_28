using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TX_course_work_28.NewFolder1
{
    class Hall5: interfacee
        
    {
        public string _Room;
        public string _Name;
        public string _Information;
        public Hall5(string Room, string Name, string Information )
        {
            _Room = Room;
            _Name = Name;
            _Information = Information;
        }
        public string room { get => _Room; set => _Room = value; }
        public string name { get => _Name; set => _Name = value; }

        public string information { get => _Information; set => _Information = value; }
    }
}
