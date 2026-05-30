namespace ExpenseTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idCounter = 0;
            List<Expense> expensesList = new List<Expense>(); //list to hold list of expenses
            bool appLoop = true;
            while (appLoop)
            {

                Console.WriteLine("Welcome to your expense tracker. Please select an option.");
                Console.WriteLine("1.)Add expense");
                Console.WriteLine("2.)Update expense");
                Console.WriteLine("3.)Delete expense");
                Console.WriteLine("4.)View all expenses");
                Console.WriteLine("5.)View summary of expenses");
                Console.WriteLine("6.)View summary for specific month");
                Console.WriteLine("7.)Exit app");

                int userChoice = int.Parse(Console.ReadLine());
                if (userChoice == 1) //add expense
                {
                    Console.WriteLine("What is the expense?");
                    string expName = Console.ReadLine();
                    Console.WriteLine("How much was the expense?");
                    decimal expAmount = decimal.Parse(Console.ReadLine());
                    Expense newExpense = new Expense(expName, expAmount, idCounter++); //create expense form user input
                    expensesList.Add(newExpense); //add to the expense list
                    //Console.WriteLine("Would you like to make another transaction?");
                    //int goAgain = int.Parse(Console.ReadLine());
                    continue;
                }
                else if (userChoice == 2)
                {
                    //update expense
                }
                else if (userChoice == 3)
                {
                    //delete expense
                }
                else if (userChoice == 4)
                {
                    foreach (Expense expense in expensesList)
                    {
                        Console.WriteLine($"ID: {expense.Id} Expense: {expense.Name}  Amount {expense.Amount}");
                    }
                    continue;
                }
                else if (userChoice == 5)
                {
                    ViewSummary(expensesList);
                    //summary of all expenses
                }
                else if (userChoice == 6)
                {
                    //summary for specific month
                }
                else if (userChoice == 7)
                {
                    Console.WriteLine("Goodbye!");
                    appLoop = false; 
                }
            }
        }
        public static void ViewSummary(List<Expense> expenses)
        {
            //decimal total = 0;
            //for (int i = 0; i< expenses.Count; i++)
            //{
            //    total += expenses.Amount;
            //}
            decimal total = 0;
            foreach (Expense expense in expenses)
            {
                total += expense.Amount;
            }
            Console.WriteLine($"Total expenses: {total}");
        }

    }
}
