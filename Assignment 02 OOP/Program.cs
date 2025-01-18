namespace Assignment_02_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region First Project 

            #region 2.Override the ToString Function to produce this output:

            //Point3D P = new Point3D(10,10, 10);
            //Console.WriteLine(P.ToString());

            #endregion

            #region 3. Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).
            //Point3D P1 = ReadPoint("Enter coordinates for Point 1 (x  y  z): ");
            //Point3D P2 = ReadPoint("Enter coordinates for Point 2 (x  y  z): ");
            //Console.WriteLine($" P1 = {P1}");
            //Console.WriteLine($" P2 = {P2}");

            #endregion

            #endregion



        }


        static Point3D ReadPoint(string message)
        {
            Console.Write(message);
            string? input = Console.ReadLine();
            string[] parts = input.Split(" ");

            try
            {
                int X = int.Parse(parts[0]);
                int Y = parts.Length > 1 ? int.Parse(parts[1]) : 0;
                int Z = parts.Length > 2 ? int.Parse(parts[2]) : 0;

                return new Point3D(X, Y, Z);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter integers.");
                return ReadPoint(message);
            }
        }
    }
}
