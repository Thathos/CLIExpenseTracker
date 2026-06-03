namespace ExpenseTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idCounter = 1;
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
                    continue;
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("Please enter the ID of the expense you would like to update");
                    int getExpense = int.Parse(Console.ReadLine());
                    foreach (Expense expense in expensesList)
                    {
                        if (getExpense == expense.Id)
                        {
                            //Console.WriteLine($"Found expense {expense.Name}");
                            Console.WriteLine("Updating expense amount.");
                            decimal updateAmount = decimal.Parse(Console.ReadLine());
                            expense.Amount = updateAmount;
                        }
                    }

                    //update expense
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("Here are you expenses.");
                    ViewExpenses(expensesList);
                    Console.WriteLine("Please enter the ID of the task you would like to delete.");
                    int removeTask = int.Parse(Console.ReadLine());
                    //expensesList.RemoveAll(e => e.Id == )
                    DeleteExpense(expensesList, removeTask); //delete expense
                }
                else if (userChoice == 4)
                {
                    ViewExpenses(expensesList);
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
            decimal total = 0;
            foreach (Expense expense in expenses)
            {
                total += expense.Amount;
            }
            Console.WriteLine($"Total expenses: {total}");
        }

        public static void ViewExpenses(List<Expense> expenses)
        {
            foreach (Expense expense in expenses)
            {
                Console.WriteLine($"ID: {expense.Id} Expense: {expense.Name}  Amount {expense.Amount}");
            }

        }

        public static void DeleteExpense(List<Expense> expenses, int id)
        {
            expenses.RemoveAll(e => e.Id == id);
        }

    }
}
