using System;
namespace LineComparison
{
    public class CalculateLength
    {
        int x1, x2, y1, y2;
        public CalculateLength(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }
        public double Calculate()
        {
            double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine(result);
            return result;
        }
        public void CheckEquality(double line1, double line2)
        {
            if (line1.Equals(line2))
                Console.WriteLine("Both lines are equal");
            else
                Console.WriteLine("Lines are not equal");
        }
        public void CompareLines(double line1, double line2)
        {
            if (line1.CompareTo(line2)==0)
                Console.WriteLine("Both lines are equal");              
            if (line1.CompareTo(line2)> 0)
                Console.WriteLine("Line1 is Greater than Line2");              
            else
                Console.WriteLine("Line1 is Less than Line2 ");                
        }
    }
}
