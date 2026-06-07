namespace Stack___Queue_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Problem1
            Stack<string> browserHistory = new Stack<string>();

            
            browserHistory.Push("https://www.google.com");
            browserHistory.Push("https://www.youtube.com");
            browserHistory.Push("https://www.github.com");
            browserHistory.Push("https://www.instagram.com");
            browserHistory.Push("https://www.tiktok.com");

            
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
                Console.WriteLine(searchUrl + "in history");
            else
                Console.WriteLine(searchUrl + "not in history");

            
            Console.WriteLine("Total Pages Remaining: ");
            Console.WriteLine("Count: " + browserHistory.Count);


            ////Problem2
            

            Queue<string> checkInQueue = new Queue<string>();

           
            checkInQueue.Enqueue("Ahmed");
            checkInQueue.Enqueue("Laith");
            checkInQueue.Enqueue("Mohammed");
            checkInQueue.Enqueue("Salim");
            checkInQueue.Enqueue("Khalid");

           
            Console.WriteLine("Waiting Guests: ");
            foreach (string guest in checkInQueue)
            {
                Console.WriteLine(guest);
            }

           
            Console.WriteLine("Next Guest Peek: ");
            Console.WriteLine(checkInQueue.Peek());

            
            Console.WriteLine("Serving Guests: ");
            Console.WriteLine("Served: " + checkInQueue.Dequeue());
            Console.WriteLine("Served: " + checkInQueue.Dequeue());

           
            Console.WriteLine("Remaining Queue: ");
            foreach (string guest in checkInQueue)
            {
                Console.WriteLine(guest);
            }

           
            string searchGuest = "Salim";
            Console.WriteLine("Contains Check: ");
            if (checkInQueue.Contains(searchGuest))
                Console.WriteLine(searchGuest + " is still waiting");
            else
                Console.WriteLine(searchGuest + " is not in queue");
            Console.WriteLine("Total Guests Waiting: ");
            Console.WriteLine("Count: " + checkInQueue.Count);




            ///Problem3
            Stack<string> undoStack = new Stack<string>();
            Stack<string> tempStack = new Stack<string>();

            undoStack.Push("Hello");
            undoStack.Push("Mr");
            undoStack.Push("Yarob");
            undoStack.Push("Muscat");
            undoStack.Push("GoodMorning");
            undoStack.Push("Almudhaibi");
            undoStack.Push("Oman is great");

            
            Console.WriteLine("Full Undo History: ");
            foreach (string action in undoStack)
            {
                Console.WriteLine(action);
            }

           
            Console.WriteLine("Next Undo Peek: ");
            Console.WriteLine(undoStack.Peek());

            
            Console.WriteLine("Undoing Last 2 Actions: ");
            Console.WriteLine("Undo: " + undoStack.Pop());
            Console.WriteLine("Undo: " + undoStack.Pop());

            
            Console.WriteLine("Remaining Undo History: ");
            foreach (string action in undoStack)
            {
                Console.WriteLine(action);
            }

          
            string targetAction = "Yarob";
            Console.WriteLine("Before Select Undo: ");
            foreach (string action in undoStack)
            {
                Console.WriteLine(action);
            }

            
            while (undoStack.Count > 0 && undoStack.Peek() != targetAction)
            {
                tempStack.Push(undoStack.Pop());
            }

           
            if (undoStack.Count > 0 && undoStack.Peek() == targetAction)
            {
                undoStack.Pop();
                Console.WriteLine("Removed: " + targetAction);
            }

           
            while (tempStack.Count > 0)
            {
                undoStack.Push(tempStack.Pop());
            }

          
            Console.WriteLine("After Select Undo: ");
            foreach (string action in undoStack)
            {
                Console.WriteLine(action);
            }

            Console.WriteLine("Final Count: ");
            Console.WriteLine("Remaining actions: " + undoStack.Count);

        }
    }
}
