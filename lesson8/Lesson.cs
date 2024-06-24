using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{
    internal class Lesson
    {
        public int Lessoncode { get; set; }
        public String  Nameoflesson{ get; set; }
        public String Nameteather { get; set; }
        public int Numifstudent { get; set; }
       

        public string Print
        {
            get { return this.Lessoncode + " " + this.Nameoflesson + " " + this.Numifstudent + " " + this.Nameteather; }
            
        }
        

    }
}
