namespace Section02
{
    static class RelationalOperators
    {
        public static void Example()
        {
            // relational operatos
            // == equal to
            // != not equal to
            // >  grater than
            // <  less than
            // >= greater than or equal to
            // <= less than or equal to

            int age = 50;
            int marks = 50;

            string grade;
            if (marks >= 75 && marks <= 100)
            {
                grade = "A";
            }
            else if (marks < 75 && marks >= 65)
            {
                grade = "B";
            }
            else if (marks < 65 && marks >= 55)
            {
                grade = "C";
            }
            else if (marks < 55 && marks >= 35)
            {
                grade = "D";
            }
            else if (marks < 35 && marks >= 0)
            {
                grade = "F";
            }
            else
            {
                grade = "Invalid marks!";
            }            
            Console.WriteLine($"{marks}: grade {grade}");

            if (grade != "A" && grade != "B")
            {
                if (age < 18)
                {
                    Console.WriteLine("You can try again!");
                }
                else
                {
                    Console.WriteLine("You failed!");
                }
            }
            else
            {
                Console.WriteLine("You passed!");
            }
        }
    }
}