namespace VendingMachine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our Vending Machine");
            bool vending = true;
            VendingMachine vm = new VendingMachine();
            while (vending)
            {
                Console.WriteLine("\nEnter your choice");
                Console.WriteLine("1. Insert Coin");
                Console.WriteLine("2. Enter code");
                Console.WriteLine("3. Show Inventory");
                Console.WriteLine("4. View Delivery Bin");
                Console.WriteLine("5. Empty Delivery Bin");
                Console.WriteLine("9. Quit\n");
                String mainChoice = Console.ReadLine();
                switch (mainChoice)
                {
                    case "1":
                        Console.WriteLine("*** Insert coins ***");
                        bool insertingCoins = true;
                        while(insertingCoins)
                        {
                            Console.WriteLine("\nEnter your choice");
                            Console.WriteLine("1. Insert Penny");
                            Console.WriteLine("2. Insert Nickel");
                            Console.WriteLine("3. Insert Dime");
                            Console.WriteLine("4. Insert Quarter");
                            Console.WriteLine("5. Insert Half Dollar");
                            Console.WriteLine("6. Insert Dollar");
                            Console.WriteLine("9. Quit\n");
                            String coinChoice = Console.ReadLine();
                            switch(coinChoice)
                            {
                                case "1":
                                    vm.Insert(new Coin(COIN.PENNY));
                                    break;
                                case "2":
                                    vm.Insert(new Coin(COIN.NICKEL));
                                    break;
                                case "3":
                                    vm.Insert(new Coin(COIN.DIME));
                                    break;
                                case "4":
                                    vm.Insert(new Coin(COIN.QUARTER));
                                    break;
                                case "5":
                                    vm.Insert(new Coin(COIN.HALF_DOLLAR));
                                    break;
                                case "6":
                                    vm.Insert(new Coin(COIN.DOLLAR));
                                    break;
                                case "9":
                                    Console.WriteLine("\nReturning to the Main Menu.\n");
                                    insertingCoins = false;
                                    break;
                                default:
                                    Console.WriteLine("\nInvalid choice. Try again\n");
                                    break;
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine("*** Enter code ***");
                        String code = Console.ReadLine();
                        vm.EnterCode(code);
                        break;
                    case "3":
                        Console.WriteLine("*** Show Inventory ***");
                        vm.ShowInventory();
                        break;
                    case "4":
                        Console.WriteLine("*** View Delivery Bin ***");
                        foreach(Product product in vm.DeliveryBin)
                        {
                            Console.WriteLine(product.Description);
                        }
                        break;
                    case "5":
                        Console.WriteLine("*** Empty Delivery Bin ***");
                        /*
                        foreach(Product product in vm.DeliveryBin)
                        {
                            Console.WriteLine(product.Description + "\n");
                            vm.DeliveryBin.Remove(product);
                        }
                        */
                        while(vm.DeliveryBin.Count > 0)
                        {
                            Console.WriteLine(vm.DeliveryBin[0]);
                            vm.DeliveryBin.RemoveAt(0);
                        }
                        break;
                    case "9":
                        vending = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            }
            Console.WriteLine("Thank you for using our Vending Machine.");
        }
    }
}
