using System;
using System.Xml;

namespace SpaceClassLibrary
{
    public class Planet
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Size { get; set; }
        public Items Inventory { get; set; }
        public Player player1; 
        public Planet (Player player)
            {
            this.player1 = player;
            }
        public void player1Inventory()
        {
            Console.WriteLine($"Player Inventory:\n" +
                $"Spaceoes: {player1.SpaceosAmount}\n" +
                $"Food: {player1.FoodAmount}\n" +
                $"Tools: {player1.ToolAmount}\n" +
                $"Explodium: {player1.ExplodiumAmount}\n" +
                $"Fuel: {player1.FuelAmount}\n");
        }
        public void ToolsBuySell()
        {
            bool trading = true;
            int newInput;
            do
            {
                Console.WriteLine("Choose a number: \n1) Buy \n2) Sell \n3) Exit");
                int choiceInput = Convert.ToInt32(Console.ReadLine());

                switch (choiceInput)
                {
                    case 1:
                        {
                            Console.WriteLine($"Please enter the amount of {Inventory.ToolName} you want to buy!");
                            newInput = Convert.ToInt32(Console.ReadLine());

                            if (newInput * Inventory.ToolSalePrice < player1.SpaceosAmount)
                            {
                                player1.SpaceosAmount -= (newInput * Inventory.ToolSalePrice);
                                player1.ToolAmount += newInput;
                                Inventory.ToolQuantity -= newInput;
                                Console.WriteLine($"You purchased {newInput} explodium");
                                Console.WriteLine($"You now have {player1.SpaceosAmount} spaceos AND {player1.ToolAmount} Tools.");
                                Console.WriteLine("Hit enter to continue!");
                                Console.ReadLine();
                            }
                            else if (newInput * Inventory.ToolSalePrice > player1.SpaceosAmount)
                            {
                                Console.WriteLine("You dont have enough money!\n" +
                                    "Hit enter to return to the menu.");
                                Console.ReadLine();
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"Please enter the amount of {Inventory.ToolName} you want to sell!");
                            newInput = Convert.ToInt32(Console.ReadLine());

                            if (newInput <= player1.ToolAmount)
                            {
                                player1.SpaceosAmount += (newInput * Inventory.ToolBuyPrice);
                                player1.ToolAmount -= newInput;
                                Inventory.ToolQuantity += newInput;
                                Console.WriteLine($"You Sold {newInput} explodium");
                                Console.WriteLine($"You now have {player1.SpaceosAmount} spaceos AND {player1.ToolAmount} Tools.");
                                Console.WriteLine("Hit enter to continue!");
                                Console.ReadLine();
                            }
                            else if (newInput > player1.ToolAmount)
                            {
                                Console.WriteLine("You do not have enough in your inventory!\n" +
                                    "Press any key to return to the menu!");
                                Console.ReadLine();
                            }
                            break;
                        }
                    case 3:
                        {
                            trading = false;
                            break;
                        }
                }
            } while (trading == true);
        }    
        public void ExplodiumBuySell()
        {
            bool trading = true;
            int newInput;
                do
                {
                Console.WriteLine("Choose a number: \n1) Buy \n2) Sell \n3) Exit");
                int choiceInput = Int32.Parse(Console.ReadLine());
                switch (choiceInput)
                    {
                    case 1:
                    {
                        Console.WriteLine($"Please enter the amount of {Inventory.ExplodiumName} you want to buy!");
                        newInput = Convert.ToInt32(Console.ReadLine());
                        if (newInput * Inventory.ExplodiumSalePrice < player1.SpaceosAmount)
                            {
                                player1.SpaceosAmount -= (newInput * Inventory.ExplodiumSalePrice);
                                player1.ExplodiumAmount += newInput;
                                Inventory.ExplodiumQuantity -= newInput;
                                Console.WriteLine($"You purchased {newInput} explodium");
                                Console.WriteLine($"You now have {player1.SpaceosAmount} spaceos AND {player1.ExplodiumAmount} bits of Explodium.");
                                Console.WriteLine("Hit enter to continue!");
                                Console.ReadLine();
                            }
                        else if (newInput * Inventory.ExplodiumSalePrice > player1.SpaceosAmount)
                            {
                               Console.WriteLine("You dont have enough money!\n" +
                                    "Hit enter to return to the menu.");
                               Console.ReadLine();
                            }
                    break;
                            }

                    case 2:
                        {
                                Console.WriteLine($"Please enter the amount of {Inventory.ExplodiumName} you want to sell!");
                                newInput = Convert.ToInt32(Console.ReadLine());

                        if (newInput <= player1.ExplodiumAmount)
                            {
                                player1.SpaceosAmount += (newInput * Inventory.ExplodiumBuyPrice);
                            player1.ExplodiumAmount -= newInput;
                            Inventory.ExplodiumQuantity += newInput;
                            Console.WriteLine($"You Sold {newInput} explodium");
                            Console.WriteLine($"You now have {player1.SpaceosAmount} spaceos AND {player1.ExplodiumAmount} bits of Explodium.");
                            Console.WriteLine("Hit enter to continue!");
                            Console.ReadLine();
                            }
                        else if (newInput > player1.ExplodiumAmount)
                            {
                            Console.WriteLine("You do not have enough in your inventory!\n" +
                                "Press any key to return to the menu!");
                            Console.ReadLine();
                            }
                   break;
                            }
                        case 3:
                            {
                            trading = false;
                        break;
                            }                        
                    }
                } while (trading == true);            
        }
        public void FuelBuySell()
            {
                bool trading = true;
                int newInput;
                do
                {
                Console.WriteLine("Choose a number: \n1) Buy \n2) Sell \n3) Exit");
                    int choiceInput = Int32.Parse(Console.ReadLine());

                    switch (choiceInput)
                    {
                        case 1:
                            {
                                Console.WriteLine($"Please enter the amount of {Inventory.FuelName} you want to buy!");
                                newInput = Convert.ToInt32(Console.ReadLine());

                                if (newInput * Inventory.FuelSalePrice < player1.SpaceosAmount)
                                {
                                    player1.SpaceosAmount -= (newInput * Inventory.FuelSalePrice);
                                    player1.FuelAmount += newInput;
                                    Inventory.FuelQuantity -= newInput;
                                    Console.WriteLine($"You purchased {newInput} Fuel");
                                    Console.WriteLine($"You now have {player1.SpaceosAmount} spaceos AND {player1.FuelAmount} groglons of Fuel.");
                                    Console.WriteLine("Hit enter to continue!");
                                    Console.ReadLine();
                                }
                                else if (newInput * Inventory.FuelSalePrice > player1.SpaceosAmount)
                                {
                                    Console.WriteLine("You dont have enough money!\n" +
                                        "Hit enter to return to the menu.");
                                    Console.ReadLine();
                                }
                                break;
                            }

                        case 2:
                            {
                                Console.WriteLine($"Please enter the amount of {Inventory.FuelName} you want to sell!");
                                newInput = Convert.ToInt32(Console.ReadLine());

                            if (newInput <= player1.FuelAmount)
                                {
                                    player1.SpaceosAmount += (newInput * Inventory.FuelBuyPrice);
                                    player1.FuelAmount -= newInput;
                                    Inventory.FuelQuantity += newInput;
                                    Console.WriteLine($"You Sold {newInput} Fuel");
                                    Console.WriteLine($"You now have {player1.SpaceosAmount} spaceos AND {player1.FuelAmount} groglons of Fuel.");
                                    Console.WriteLine("Hit enter to continue!");
                                    Console.ReadLine();
                                }
                                else if (newInput > player1.FuelAmount)
                                {
                                    Console.WriteLine("You do not have enough in your inventory!\n" +
                                        "Press any key to return to the menu!");
                                    Console.ReadLine();
                                }
                                break;
                            }
                        case 3:
                            {
                                trading = false;
                                break;
                            }

                    }
                } while (trading == true);

            }
        public void FoodBuySell()
        {
            bool trading = true;
            int newInput;
            string inputQty;
            do
            {
                Console.WriteLine("Choose a number: \n1) Buy \n2) Sell \n3) Exit");
                int choiceInput = Int32.Parse(Console.ReadLine());

                switch (choiceInput)
                {
                    case 1:
                        {
                            Console.WriteLine($"Please enter the amount of {Inventory.FoodName} you want to buy!");
                            newInput = Convert.ToInt32(Console.ReadLine());

                            if (newInput * Inventory.FoodSalePrice < player1.SpaceosAmount)
                            {
                                player1.SpaceosAmount -= (newInput * Inventory.FoodSalePrice);
                                player1.FoodAmount += newInput;
                                Inventory.FoodQuantity -= newInput;
                                Console.WriteLine($"You purchased {newInput} Food");
                                Console.WriteLine($"You now have {player1.SpaceosAmount} spaceos AND {player1.FoodAmount} days of rations.");
                                Console.WriteLine("Hit enter to continue!");
                                Console.ReadLine();
                            }
                            else if (newInput * Inventory.FoodSalePrice > player1.SpaceosAmount)
                            {
                                Console.WriteLine("You dont have enough money!\n" +
                                    "Hit enter to return to the menu.");
                                Console.ReadLine();
                            }
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine($"Please enter the amount of {Inventory.FoodName} you want to sell!");
                            inputQty = Console.ReadLine();
                            newInput = Int32.Parse(inputQty);


                            if (newInput <= player1.FoodAmount)
                            {
                                player1.SpaceosAmount += (newInput * Inventory.FoodBuyPrice);
                                player1.FoodAmount -= newInput;
                                Inventory.FoodQuantity += newInput;
                                Console.WriteLine($"You Sold {newInput} Food");
                                Console.WriteLine($"You now have {player1.SpaceosAmount} spaceos AND {player1.FoodAmount} days of rations.");
                                Console.WriteLine("Hit enter to continue!");
                                Console.ReadLine();
                            }
                            else if (newInput > player1.FoodAmount)
                            {
                                Console.WriteLine("You do not have enough in your inventory!\n" +
                                    "Press any key to return to the menu!");
                                Console.ReadLine();
                            }
                            break;
                        }
                    case 3:
                        {
                            trading = false;
                            break;
                        }

                }
            } while (trading == true);
        }    
        public void BuySell()
        {
            Console.Clear();
            player1Inventory();
            bool condition = true;
            //player1Inventory();
            Console.WriteLine();
            Console.WriteLine($"Welcome to the {this.Name} Inventory!");
            
            while (condition == true)
            {
                string select = "";
                Console.WriteLine($"Select the number of the item you wish to sell or purchase! \n" +
                  $"1) {Inventory.FoodName} Sell for: {Inventory.FoodBuyPrice} Buy for: {Inventory.FoodSalePrice} \n" +
                  $"2) {Inventory.FuelName} Sell for: {Inventory.FuelBuyPrice} Buy for: {Inventory.FuelSalePrice} \n" +
                  $"3) {Inventory.ExplodiumName} Sell for: {Inventory.ExplodiumBuyPrice} Buy for: {Inventory.ExplodiumSalePrice} \n" +
                  $"4) {Inventory.ToolName} Sell for: {Inventory.ToolBuyPrice} Buy for: {Inventory.ToolSalePrice} \n" +
                  $"5) Exit");
                Console.WriteLine();
                select = Console.ReadLine();
                switch (select)
                {
                    case "1":
                        Console.WriteLine();
                        this.FoodBuySell();
                        break;
                    case "2":
                        Console.WriteLine();
                        this.FuelBuySell();
                        break;
                    case "3":
                        Console.WriteLine();
                        this.ExplodiumBuySell();
                        break;
                    case "4":
                        Console.WriteLine();
                        this.ToolsBuySell();
                        break;
                    case "5":
                        condition = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a correct number!");
                        select = Console.ReadLine();
                        condition = true;
                        break;
                }
                continue;
            }
        }
        public void Explore()
        {
            Console.WriteLine(Description);
            Console.WriteLine($"Size: {Size}km");
        }     
        public void Leave()
        {
            Console.WriteLine("Select L to confirm decision");
        }
        public void Welcome()
        {
            //if the input by the user parses to an integer and is between 1 and 5, return the input.            
            int onplanet = 0;
            while (onplanet == 0)
            {
                
                Console.WriteLine("Welcome to " + this.Name);
                Console.WriteLine("Would you like to:\n1) Explore\n2) Buy/Sell \n3) Leave");
                string temp;
                int tempInt;
                int input = 0;
                temp = Console.ReadLine();
                if (int.TryParse(temp, out tempInt) && (tempInt >= 1 && tempInt <= 4))
                {
                    input = tempInt;
                }
                else
                {
                    //if the input by the user doesnt parse to an integer or is not between 1 and 5, do not return the input. Loop until user enters an acceptable value.
                    Console.WriteLine("Please enter a nubmer listed above and press enter.");
                    while (!int.TryParse(Console.ReadLine(), out tempInt) || (tempInt < 1 || tempInt > 4))
                    {
                        Console.WriteLine("Please enter a nubmer listed above and press enter.");
                    }
                    input = tempInt;
                }
                switch (input)
                {
                    case 1: //Explore
                        this.Explore();
                        Console.ReadKey();
                        break;
                    case 2: //Buy
                        this.BuySell();
                        Console.ReadKey();
                        break;
                    case 3: //Leave
                        Console.Clear();
                        Console.WriteLine($"You wave goodbye to the citizens of {this.Name} as your scooter takes off.\n\n");
                        Console.WriteLine($"You used 10 gallons of fuel during your travel!\n" +
                        $"You have {player1.FuelAmount -= 10} gallons left.\n\nPress any key to return to space.");
                        Console.ReadLine();
                        onplanet = 1;
                        break;
                }
                if (player1.SpaceosAmount > 10000)
                {
                    Console.WriteLine("Congratulations, You have won the game!");
                    Environment.Exit(0);
                }
                continue;
            }            
        }      
    }
}
