namespace Advenced03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise01
            List<int>grades=new List<int>();
            grades.Add(85);
            grades.Add(92);
            grades.Add(78);
            grades.Add(95);
            grades.Add(88);
            grades.Add(70);
            grades.Add(100);
            grades.Add(65);
            foreach (int item in grades)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(grades.Count);
            Console.WriteLine(grades[0]);
            Console.WriteLine(grades[(grades.Count)-1]);


            grades.Sort();
            foreach (int item in grades)
            {
                Console.WriteLine(item);
            }
         

            int above90 = grades.Find(x => x > 90);
            Console.WriteLine("first grade above 90 :" +above90); 

            List<int> failing_grades = new List<int>();

            failing_grades = grades.FindAll(x => x < 75);

            foreach (int item in failing_grades)
            {
                Console.WriteLine(item);
            }

            grades.RemoveAll(x => x < 75);

            Console.WriteLine(grades.Contains(100)); 
           

            List<string>strGredes=new List<string>();

            foreach (int item in grades)
            {
                strGredes.Add("Grade: " + item);
            }

            foreach (string item in strGredes)
            {
                Console.WriteLine(item);
            }


            #endregion

        }
    }
}
