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

            #region Exercise02 
            SortedDictionary<int, string> players = new SortedDictionary<int, string>();
            
            players.Add(500, "Ahmed");
            players.Add(200, "Sara");
            players.Add(800, "Ali");
            players.Add(350, "Mona");

            foreach(var item in players)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(players.First().Key);
            Console.WriteLine(players.First().Value);

            Console.WriteLine(players.ContainsKey(500));

            Console.WriteLine( players.TryGetValue(999,out string value));

            players.Remove(200);

            foreach (var item in players)
            {
                Console.WriteLine(item);
            }


            #endregion

            #region Exercise03
            Dictionary<string, string> phoneBook =new Dictionary<string, string>();

            phoneBook.Add("Ahmed", "01011111111");
            phoneBook.Add("Sara", "01122222222");
            phoneBook.Add("Ali", "01233333333");
            phoneBook.Add("Mona", "01544444444");

            phoneBook["tarek"] = "01154565445366";

            try
            {
                phoneBook.Add("Ahmed", "01099999999");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine( phoneBook.TryAdd("tarek", "01025454555"));

            Console.WriteLine(phoneBook.ContainsKey("amr"));

            if (phoneBook.TryGetValue("Youssef", out string ?value02))
            {
                Console.WriteLine(value02);
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            foreach (string name in phoneBook.Keys)
            {
                Console.Write(name + " ");
            }
            foreach (string name in phoneBook.Values)
            {
                Console.Write(name + " ");
            }

            Console.WriteLine();



            #endregion

            #region Exercise04

            HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            emails.Add("ahmed@test.com");
            emails.Add("AHMED@test.com");
            emails.Add("sara@test.com");
            emails.Add("Sara@Test.Com");

            Console.WriteLine(emails.Count);
            //the actually stored is 2 because hashset stores unique elements

            HashSet<int> setA = new HashSet<int>
            {
                1, 2, 3, 4, 5
            };

            HashSet<int> setB = new HashSet<int>
            {
                4, 5, 6, 7, 8
            };

            HashSet<int> union = new HashSet<int>(setA);
            union.UnionWith(setB);
            foreach (int x in union)
            {
                Console.WriteLine(x);
            }

            HashSet<int> intersection = new HashSet<int>(setA);
            intersection.IntersectWith(setB);

            foreach (int x in intersection)
            {
                Console.WriteLine(x);
            }

            HashSet<int> difference = new HashSet<int>(setA);
            difference.ExceptWith(setB);

            foreach (int x in difference)
            {
                Console.WriteLine(x);

            }

            HashSet<int> check = new HashSet<int> { 1, 2 };

            Console.WriteLine( check.IsSubsetOf(setA));
            #endregion

            #region Exercise05

            Queue<string> documents = new Queue<string>();
            documents.Enqueue("Report.pdf");
            documents.Enqueue("Invoice.pdf");
            documents.Enqueue("Letter.docx");
            documents.Enqueue("Resume.pdf");
            documents.Enqueue("Photo.jpg");


            foreach (string document in documents)
            {
                Console.WriteLine(document);
            }

            Console.WriteLine(documents.Count);

            Console.WriteLine(documents.Peek());



            while (documents.Count > 0)
            {
                Console.WriteLine("Printing: " + documents.Dequeue());
            }

            bool result = documents.TryDequeue(out string? val);
            Console.WriteLine(result);


            #endregion

            #region Exercise06
            Stack<string> history = new Stack<string>();

            history.Push("google.com");
            history.Push("github.com");
            history.Push("stackoverflow.com");
            history.Push("youtube.com");
            history.Push("claude.ai");

            Console.WriteLine(history.Peek() );

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(history.Pop()); 
            }
            
            Console.WriteLine(history.Peek());

            while (history.Count > 0)
            {
                history.Pop();
            }

            Console.WriteLine(history.TryPop(out string page));


            #endregion
        }
    }
}
