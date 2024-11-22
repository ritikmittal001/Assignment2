using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Q1 ob1 = new Q1();
            Q2 ob2 = new Q2();
            Q3 q3 = new Q3();
            Q4 q4 = new Q4();
            Q5 q5 = new Q5();

        }
    }

    class Q1
    {
      public  Q1()
        {
           
            int sum = 0;
            int[] price=new int[5];
            for (int i = 0; i < 5; i++)
            {
                price[i] = Convert.ToInt32(Console.ReadLine());
                sum += price[i];
            }
            if (sum > 300) 
            {
                int discount = (sum * 10) / 100;
                sum -= discount;
            }
            Console.WriteLine($"total payable amout {sum}");
            Console.ReadLine();
        }
    }

    class Q2
    {
        public Q2()
        {
            Console.WriteLine("enter the temperature in celcius");
            double celcius=Convert.ToDouble(Console.ReadLine());
            if(celcius <0)
            {
                Console.WriteLine("Freezing temparature");   
            }
            double faharenhite = ((9 / 5) * celcius + 32);
            Console.WriteLine(faharenhite);
            Console.ReadLine();
        }
        
    }

    class Q3
    {
        public int amount = 0, Cash;

        public Q3()
        {
            Console.WriteLine("Enter the option 1 for Withdrawl , 2 for deposite , 3 for check balance ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the Cash to execute the transaction");
            Cash = Convert.ToInt32(Console.ReadLine());
          
            switch (choice)
            {
                case 1:
                    withdrawl();
                    break;
                case 2:
                    deposite();
                    break;
                case 3:
                    Checkbalence();
                    break;
                default:
                    Console.WriteLine("you enter wrong option");
                    break;
            }
            Console.ReadLine();
        }
        public void withdrawl()
        {
            if (amount<Cash)
            {
                Console.WriteLine("Insufficent balance");
            }
            else
            {
                amount = amount - Cash;
                Console.WriteLine($"Amount debited SuccessFully{Cash}");
            }
        }
        public void deposite()
        {
            amount += Cash;
            Console.WriteLine($"Amount deposited  = {Cash} and total amount is {amount}");
        }
        public void Checkbalence()
        {
            Console.WriteLine($"Amount in your Account is {amount}");
        }
   
    }

    class Q4
    {
        public Q4()
        {
            int[] arr = new int[5];
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }
            int avg=sum/arr.Length;
            if (avg > 90)
            {
                Console.WriteLine($"the grade is A {avg}");
            }
            else if (avg > 70)
            {
                Console.WriteLine($"the grade is B {avg}");
            }
            else if (avg > 60)
            {
                Console.WriteLine($"the grade is C  {avg}");
            }
            else if (avg > 40)
            {
                Console.WriteLine($"the grade is {avg}");
            }
            else {
                Console.WriteLine("you are Fail ");
            }
           

        }
    }


    class Q5
    {
        public Q5()
        {
            Console.WriteLine("Enter the password");
            String password = Console.ReadLine();

            bool isValid = ValidatePassword(password);

            if (isValid)
            {
                Console.WriteLine("Password is valid.");
            }
            else
            {
                Console.WriteLine("Password is not valid. Please ensure it meets the following criteria:");
                Console.WriteLine("- At least 8 characters long");
                Console.WriteLine("- Contains at least one uppercase letter");
                Console.WriteLine("- Contains at least one lowercase letter");
                Console.WriteLine("- Contains at least one number");
            }
        }

        static bool ValidatePassword(string password)
        {
            bool hasUppercase = false;
            bool hasLowercase = false;
            bool hasNumber = false;

            if (password.Length < 8)
            {
                return false;
            }

            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    hasUppercase = true;
                }
                else if (char.IsLower(c))
                {
                    hasLowercase = true;
                }
                else if (char.IsDigit(c))
                {
                    hasNumber = true;
                }
            }

            return hasUppercase && hasLowercase && hasNumber;
        }
    }

    class Q6
    {
        
        static void Main(string[] args)
        {
            Console.Write("Enter distance traveled (km): ");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Is it night (yes/no)? ");
            bool isNight = Console.ReadLine().ToLower() == "yes";

            double fare = CalculateFare(distance, isNight);
            Console.WriteLine("Fare: Rs. " + fare);
        }

        static double CalculateFare(double distance, bool isNight)
        {
            double baseFare = 20;
            double perKmRate = 10;
            double nightSurcharge = 10;

            double fare = baseFare + (distance - 2) * perKmRate;
            if (isNight)
            {
                fare += nightSurcharge;
            }
            return fare;
        }
    }
    class Q7
    {
        static void Main(string[] args)
    {
        bool[] attendance = new bool[5];
        int totalDaysAttended = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Was the student present on day " + (i + 1) + " (yes/no)? ");
            attendance[i] = Console.ReadLine().ToLower() == "yes";
            if (attendance[i])
            {
                totalDaysAttended++;
            }
        }

        Console.WriteLine("Total days attended: " + totalDaysAttended);
        Console.WriteLine("Perfect attendance: " + (totalDaysAttended == 5));
    }
}

    class Q8
    {
        static void Main(string[] args)
        {
            double[] expenses = new double[12];
            double totalExpenses = 0;
            int maxMonth = 0;
            int minMonth = 0;

            for (int i = 0; i < 12; i++)
            {
                Console.Write("Enter expenses for month " + (i + 1) + ": ");
                expenses[i] = Convert.ToDouble(Console.ReadLine());
                totalExpenses += expenses[i];
                if (i == 0 || expenses[i] > expenses[maxMonth])
                {
                    maxMonth = i;
                }
                if (i == 0 || expenses[i] < expenses[minMonth])
                {
                    minMonth = i;
                }
            }

            Console.WriteLine("Total expenses: " + totalExpenses);
            Console.WriteLine("Month with highest expenses: " + (maxMonth + 1));
            Console.WriteLine("Month with lowest expenses: " + (minMonth + 1));
        }

    }
    class Q9
    {

        static void Main(string[] args)
        {
            List<Item> cart = new List<Item>();

            while (true)
            {
                Console.WriteLine("1. Add item");
                Console.WriteLine("2. Remove item");
                Console.WriteLine("3. View cart");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Enter item name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter item price: ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        cart.Add(new Item(name, price));
                        break;
                    case 2:
                        Console.Write("Enter item name to remove: ");
                        string removeName = Console.ReadLine();
                        cart.RemoveAll(item => item.Name == removeName);
                        break;
                    case 3:
                        double total = 0;
                        foreach (Item item in cart)
                        {
                            Console.WriteLine(item.Name + ": " + item.Price);
                            total += item.Price;
                        }
                        Console.WriteLine("Total: " + total);
                        break;
                    case 4:
                        return;
                }
            }
        }
        class Item
        {
            public string Name { get; set; }
            public double Price { get; set; }

            public Item(string name, double price)
            {
                Name = name;
                Price = price;
            }
        }


        class Q10
        {

            static void Main(string[] args)
            {
                Console.Write("Enter hourly wage: ");
                double hourlyWage = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter hours worked per week: ");
                double hoursWorked = Convert.ToDouble(Console.ReadLine());

                double monthlySalary = CalculateMonthlySalary(hourlyWage, hoursWorked);
                Console.WriteLine("Monthly salary: " + monthlySalary);
            }

            static double CalculateMonthlySalary(double hourlyWage, double hoursWorked)
            {

                double weeklySalary = hourlyWage * hoursWorked;
                double monthlySalary = weeklySalary * 4;
                return monthlySalary;
            }
        }


    }
}
    

