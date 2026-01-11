namespace Section01
{
    static class TypedVariables
    {
        public static void Example()
        {
            // implicitly typed variable
            var name = "John Doe";
            var age = 10;

            Console.WriteLine($"name: {name} | age: {age}");

            // explicitly typed variable
            string name2 = "Jane Doe";
            int age2 = 12;

            Console.WriteLine($"\nname: {name2} | age: {age2}");
        }
    }
}