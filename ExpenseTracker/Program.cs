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
                    Console.WriteLine("Would you like to make another transaction?");
                    int goAgain = int.Parse(Console.ReadLine());
                    if (goAgain == 1)
                    {
                        continue;
                    }
                    else
                    {
                        appLoop = false;
                    }
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
                        Console.WriteLine($"{expense.Name}");
                    }
                }
                else if (userChoice == 5)
                {
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
    }
}
