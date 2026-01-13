namespace Section03
{
    static class AdventureGame
    {
        public static void Example()
        {
            Console.WriteLine("----- welcome to the adventure game -----");

            Console.Write("select character name: ");
            string? name = Console.ReadLine()?.Trim();

            Console.WriteLine("\n1. Warrior \n2. Wizard \n3. Barbarian  \n4. Archer");

            int classNum;
            int[] validClasses = [1, 2, 3, 4];
            while (true)
            {
                Console.Write("select class type: ");
                string? classStr = Console.ReadLine();

                bool isValidClass = int.TryParse(classStr, out classNum);
                if (isValidClass && validClasses.Contains(classNum))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please select a valid class!\n");
                }
            }

            string className = "Wahala";
            switch (classNum)
            {
                case 1:
                    className = "Warrior";
                    break;
                case 2:
                    className = "Wizard";
                    break;
                case 3:
                    className = "Barbarian";
                    break;
                case 4:
                    className = "Archer";
                    break;
            }

            Console.WriteLine($"\nYou, {name} the {className} find yourself at the edge of a dark forest...");
            string? choice1;
            while (true)
            {
                Console.Write("Do you enter the forest or camp outside? (enter/camp) ");
                choice1 = Console.ReadLine()?.Trim();

                if (string.Equals(choice1?.ToLower(), "enter") || string.Equals(choice1?.ToLower(), "camp"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please select a valid action!\n");
                }
            }

            if (string.Equals(choice1, "camp"))
            {
                Console.WriteLine("\nA bear attacks and eats you while you were peacefully sleeping...");
                Console.WriteLine("----- you died -----");
            }            
            else
            {
                Console.WriteLine("\nYou came to a fork in the road.....");
                string? choice2;
                while (true)
                {
                    Console.Write("Do you go left or right? (left/right) ");
                    choice2 = Console.ReadLine()?.Trim();

                    if (string.Equals(choice2?.ToLower(), "left") || string.Equals(choice2?.ToLower(), "right"))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please select a valid action!\n");
                    }
                }

                if (string.Equals(choice2, "left"))
                {
                    Console.WriteLine("\nYou fall into a deep dark pit and starve...");
                    Console.WriteLine("----- you died -----");
                }
                else
                {
                    Console.WriteLine("\nYou find a random chest under a tree.....");
                    string? choice3;
                    while (true)
                    {
                        Console.Write("Do you open it or not? (open/no) ");
                        choice3 = Console.ReadLine()?.Trim();

                        if (string.Equals(choice3?.ToLower(), "open") || string.Equals(choice3?.ToLower(), "no"))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please select a valid action!\n");
                        }
                    }

                    if (string.Equals(choice3, "open"))
                    {
                        Console.WriteLine("\nYou find the lost treassure of the dark forest...");
                        Console.WriteLine("----- you won -----");
                    }
                    else
                    {
                        Console.WriteLine("\nYou fall into a deep dark pit and starve...");
                        Console.WriteLine("----- you died -----");
                    }
                }                
            }
        }
    }
}