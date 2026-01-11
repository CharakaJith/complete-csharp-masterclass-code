namespace Section01
{
    static class StringSpecialCharacters
    {
        public static void Example()
        {
            string str1 = "This is a \"string\" with a / and a colon.";
            string str2 = "This is a \"string\" with a \\.";
            string str3 = "This is a \"string\" with a \nline break.";
            string str4 = "This is a \"string\" with a \ttab space.";

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);
        }
    }
}