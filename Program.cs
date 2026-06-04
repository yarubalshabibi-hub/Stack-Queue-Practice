namespace Stack___Queue_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> browserHistory = new Stack<string>();

            
            browserHistory.Push("https://www.google.com");
            browserHistory.Push("https://www.youtube.com");
            browserHistory.Push("https://www.github.com");
            browserHistory.Push("https://www.stackoverflow.com");
            browserHistory.Push("https://www.reddit.com");

            
            Console.WriteLine("Browser History: ");
            foreach (string page in browserHistory)
            {
                Console.WriteLine(page);
            }

            
            Console.WriteLine("Current Page Peek: ");
            Console.WriteLine(browserHistory.Peek());

          
            Console.WriteLine("Pressing Back: ");
            Console.WriteLine("Back 1: " + browserHistory.Pop());
            Console.WriteLine("Back 2: " + browserHistory.Pop());

           
            Console.WriteLine("Remaining History: ");
            foreach (string page in browserHistory)
            {
                Console.WriteLine(page);
            }

          
            string searchUrl = "https://www.github.com";
            Console.WriteLine("Contains Check: ");
            if (browserHistory.Contains(searchUrl))
                Console.WriteLine(searchUrl + " is still in history");
            else
                Console.WriteLine(searchUrl + " is not in history");

            
            Console.WriteLine("Total Pages Remaining: ");
            Console.WriteLine("Count: " + browserHistory.Count);
        }
    }
}
