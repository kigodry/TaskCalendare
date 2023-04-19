using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCalendar
{
    internal class Class2
    {
        public int ChoseButton;
        public DateTime time;
        public void Delete()
        {
            Class.ClassList.Remove(this);
        }
    }
}
