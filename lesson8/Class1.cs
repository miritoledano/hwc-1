namespace ClassLibrary2
{
    public class Class1
    {
        public static int ReadInt(string c = "enter numer ")
        {
            Console.WriteLine(c);
            string x = Console.ReadLine();
            int result;
            while (!int.TryParse(x, out result))
            {
                Console.WriteLine("enter num again");
                x = Console.ReadLine();
            }

            return result;
        }
        public static Object ReadEnum(Type typeObject, string c = "enter num for emnum")
        {
            Console.WriteLine(c);
            int result = ReadInt(c);
            while (!Enum.IsDefined(typeObject, result)) {

                Console.WriteLine("לא תקין");
                result = ReadInt();
            }
            return Convert.ChangeType(
                typeObject, (TypeCode)result);


        }

    }
}