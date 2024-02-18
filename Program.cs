namespace Prog_OOP_Midterm_Part1
{
    internal class Program
    {

        // Juan Hernandez
        // Midterm - Part 1
        // 02/17/2024
        static void Main()
        {
            //List<string> localList = new List<string>();   
            //localList.Add("A"); 
            //localList.Add("B");
            //localList.Add("C");
            //localList.Add("D");
            //localList.Add("E");
            //List<string> dataList = MyDatabase.Data;
            // Display or manipulate the local list as needed.
            //foreach (string item in dataList)
            //{
            //Console.WriteLine(item);
            //}
            //Console.WriteLine();// new line
            //Product product = new Product("T-shirt ", 19.99, "Medium", "Red", "", "");
            //product.DisplayProductInformation();

            //Groceries banana = new Groceries("Banana", 0.99, "2024-02-10");
            // Call the DisplayProductInfo method to display the banana's details
            //banana.DisplayProductInfo();

            // Testing Clothing
            //Clothing tShirt = new Clothing("T-shirt", 19.99, "Medium", "Red");
            //tShirt.DisplayProductInfo();

            // Testing Electronics
            //Electronics smartphone = new Electronics("Smartphone", 799.99, "Apple");
            //smartphone.DisplayProductInfo();

            //Console.WriteLine();// new line
            // new List
            //List<Product> productList = new List<Product>();
            //productList.Add(tShirt);
            //productList.Add(smartphone);
            //productList.Add(banana);
            // Display list
            //foreach (Product product in productList)
            //{

            //product.DisplayProductInfo();
            //}

            //***************************************************************************//
            // Access the static property to get the data
            //List<Product> productList = MyDatabase.Data;

            // Display the data from the static class
            //foreach (Product product in productList)
            //{

            //product.DisplayProductInfo();
            //}

            //***************************************************************************//
            // Using our UpdateConfig method to change our connection string. Make sure to pass in the correct information
            //Config.UpdateConnectionString("CramberryFarms", "training", "Admin", "1234");

            // Saving the connectionString to a local variable
            //string connectionString = Config.connectionString;

            // Using the Database.ConnectToDatabase() method that takes a formatted connection string to connect
            //Database db = Database.ConnectToDatabase(connectionString);

            // If it connects, grab the data as a list of product
            // In the real world theres a lot of framework and code to make this happen
            //List<Product> data = db.Data();

            // Display our list of product from the training table.
            //foreach (Product d in data)
            //{
            //d.DisplayProductInfo();
            //}

            // Update Connection String
            Config.UpdateConnectionString("CramberryFarms", "main", "Admin", "1234");
            // Save connection String locally
            string connectionString = Config.connectionString;

            // Connect to database
            Database db = Database.ConnectToDatabase(connectionString);

            // Pull the data
            List<Product> data = db.Data();
            // Saving a reference to an object in our list
            Product testGetType = data[0];

            // Display the type of the object
            Console.WriteLine(testGetType.GetType());

            // Saving a local variable holding the type of a specific object, here groceries.
            Type groceryType = typeof(Groceries);

            // Comparing GetType to typeof(Groceries)
            bool sameType = testGetType.GetType() == groceryType;

            // Printing the result
            Console.WriteLine($"Are they the same time:  {sameType}");

            // Menu -------------------------------------

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Display All Items");
                Console.WriteLine("2. Display Electronics");
                Console.WriteLine("3. Display Groceries");
                Console.WriteLine("4. Display Clothing");
                Console.WriteLine("5. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayAllItems(data);
                        break;
                    case 2:
                        DisplayElectronics(data);
                        break;
                    case 3:
                         DisplayGroceries(data);
                        break;
                    case 4:
                        DisplayClothing(data);
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            static void DisplayAllItems(List<Product> data)
            {
                foreach (Product product in data)
                {
                    product.DisplayProductInfo();
                }

            }

            static void DisplayElectronics(List<Product> data)
            {
                // Code to display all Electronics
                foreach (Product product in data)
                {
                    if (product.GetType() == typeof(Electronics)) {
                        product.DisplayProductInfo();
                    }
                }
            }

            static void DisplayGroceries(List<Product> data)
            {
                // Code to display all Groceries
                foreach (Product product in data)
                {
                    if (product.GetType() == typeof(Groceries))
                    {
                        product.DisplayProductInfo();
                    }
                }
            }

            static void DisplayClothing(List<Product> data)
            {
                // Code to display all Clothing
                foreach (Product product in data)
                {
                    if (product.GetType() == typeof(Clothing))
                    {
                        product.DisplayProductInfo();
                    }
                }

            }
        }        
    }
}// Done
