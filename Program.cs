namespace CSharp_Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using a class


            PointClass pointClass = new PointClass(200, 300);
            PointClass pointClass2 = pointClass;
            Console.WriteLine("Class");
            Console.WriteLine("PointClass 1: " + pointClass);
            Console.WriteLine("PointClass 2: " + pointClass2);
            Console.WriteLine("Changing x and y of Point 2 to 30 and 40");
            pointClass2.X = 30;
            pointClass2.Y = 40;
            Console.WriteLine("PointClass 1: " + pointClass);
            Console.WriteLine("PointClass 2: " + pointClass2);
            Console.WriteLine();
            Console.WriteLine("The origin PointClass is altered because they point to the same object on the heap. So when we change the values for pointClass2, it effects the first PointClass also");
            Console.WriteLine("-----------------------------");
            // Using a struct
            Console.WriteLine();
            Point point = new Point(200, 300);
            Point point2 = point;
            Console.WriteLine("Struct");
            Console.WriteLine("Point 1: " + point);
            Console.WriteLine("Point 2: " + point2);
            Console.WriteLine("Changin x and y of Point 2 to 30 and 40");

            point2.X = 30;
            point2.Y = 40;
            Console.WriteLine("Point 1: " + point);
            Console.WriteLine("Point 2: " + point2);
            Console.WriteLine();
            Console.WriteLine("The original Point isn't change because structs store the same values, but they are independent of each other. Like a photo copy of a paper. What you do to the paper doesn't influence the first paper");

   
            Console.ReadKey();
        } // Main

        public static void ChangePoint(Point point)
        {
            point = new Point(20, 20);
        }

        public static void ChangePoint(PointClass point)
        {
            point = new PointClass(20, 20);
        }

    } // class

} // namespace