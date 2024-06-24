using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson8
{

    internal class Computer

    {
        int computerstations;
        private Lesson lesson;

        public Lesson Lesson
        {
            get
            {
                return new Lesson() { Lessoncode = this.Lesson.Lessoncode, Nameoflesson = this.Lesson.Nameoflesson, Nameteather = this.Lesson.Nameteather, Numifstudent = this.Lesson.Numifstudent };


            }
        }
        
        
      private String[]arr= {"hh","h65","jjj" };
        public string[] Arr
        {
            get { string[] arr1 = new string[arr.Length];
                Array.Copy(arr, arr1, arr.Length);
                    return arr1;
                    }
        }
        public int Emptyplase
        {
            get { return maxStudentInRoom-computerstations; }
         
        } 


        Computer()
        {
            Random rnd = new Random();
            int x = rnd.Next(1, 100);
            Cntroom = x;
           
            Console.WriteLine("  עמדות הכנס מיספר");
            computerstations= Shgiot.ReadInt();



        }
        public Computer(int C)
        {
            ComputerStations = C;
       
        }


        private const int maxStudentInRoom=100;


        public string NameRoom { get; set; }
        private int idroom;

        public int Idroom
        {
            get { return idroom; }
            set { idroom =Cntroom; }
        }


        public String Rt
        {
            get { return this.NameRoom+" "+ this.Idroom+" "+ this.ComputerStations; }
         
        }
        RoomSHap roomSHap { get; set; }

      
        public int ComputerStations
        {
            get
            {
                if (computerstations <= maxStudentInRoom)
                {
                    return computerstations;
                }
                else
                {

                    return -1;

                }
            }
            private set
            {
                if (computerstations <= maxStudentInRoom)
                {
                    computerstations = value;

                }
                else
                    Console.WriteLine("חריגה");
            }
        }
        private int floor;

        public int Floor
        {
            get { return floor; }
            set { floor = value; }
        }

        public static int Cntroom { get; private set; }

        internal void Tostring()
        {
            throw new NotImplementedException();
        }
    }
}