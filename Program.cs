using System.Security.Principal;

namespace sesion3_iti
{


    enum PizzaSize
    {
        Small = 1,
        Medium = 2,
        Large = 3,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region choose a pizza size using an enum called PizzaSize -price
            //Console.WriteLine("Select Pizza Size:");
            //Console.WriteLine("1 - Small");
            //Console.WriteLine("2 - Medium");
            //Console.WriteLine("3 - Large");
            //Console.Write("Enter choice: ");
            //int choice = int.Parse(Console.ReadLine());

            //if (Enum.IsDefined(typeof(PizzaSize), choice))
            //{
            //    PizzaSize selectedSize = (PizzaSize)choice;
            //    Console.WriteLine($"You selected: {selectedSize} Pizza");

            //    switch (selectedSize)
            //    {
            //        case PizzaSize.Small:
            //            Console.WriteLine("Price: $8");
            //            break;
            //        case PizzaSize.Medium:
            //            Console.WriteLine("Price: $12");
            //            break;
            //        case PizzaSize.Large:
            //            Console.WriteLine("Price: $15");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid choice.");
            //}
            #endregion
            #region BankAccount account
            //BankAccount account = new BankAccount();

            //  Console.Write("Enter initial balance: ");
            //  decimal initial = decimal.Parse(Console.ReadLine());
            //  account.Balance = initial;

            //  if (account.Balance >= 0)
            //  {
            //      Console.Write("Enter deposit amount: ");
            //      decimal deposit = decimal.Parse(Console.ReadLine());
            //      account.Deposit(deposit);
            //      Console.WriteLine($"New balance: {account.Balance}");

            //      Console.Write("Enter withdraw amount: ");
            //      decimal withdraw = decimal.Parse(Console.ReadLine());
            //      account.Withdraw(withdraw);
            //      Console.WriteLine($"Final balance: {account.Balance}");

            //  }
            #endregion

            #region Student
            //student student = new student();

            //Console.Write("Enter Student ID: ");
            //student.Id = int.Parse(Console.ReadLine());

            //Console.Write("Enter Full Name: ");
            //student.FullName = Console.ReadLine();

            //Console.Write("Enter Grade: ");
            //student.Grade = double.Parse(Console.ReadLine());

            //Console.WriteLine("\nStudent Info:");
            //Console.WriteLine($"ID: {student.Id}");
            //Console.WriteLine($"Name: {student.FullName}");
            //Console.WriteLine($"Grade: {student.Grade}");

            #endregion
        }

    }
}

