namespace lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Computer c1 = new Computer(15) ;
            Console.WriteLine(c1.ComputerStations);
            c1.NameRoom = "jbihe";
            c1.Idroom = 4;

            Console.WriteLine(  c1.Rt);
            Lesson lesson = new Lesson() ;
            lesson.Numifstudent = 15;
            lesson.Numifstudent = 15;
            lesson.Nameoflesson = "miri";
            lesson.Nameteather = "m";
            Console.WriteLine(lesson.Print);
            Console.WriteLine(c1.Emptyplase);
            Console.WriteLine(c1.Arr[0]+" "+c1.Arr[1]+" " + c1.Arr[3]);
        }
    }
}
