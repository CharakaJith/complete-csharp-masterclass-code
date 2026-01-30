namespace Section05.Properties
{
    class Student
    {
        // private backing field for age
        private int _age;
        private bool _isSenior;

        public string Name { get; set; }
        public int Age 
        { 
            get
            {
                return _age;
            } 
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Student must be over 18!");
                }   
                else
                {
                    _age = value;
                }     
            } 
        }
        public bool IsSenior
        {
            get
            {
                if (Age > 23)
                    return true;
                else
                    return false;
            }
            set { _isSenior = value; }
        }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            IsSenior = Age > 23;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"{Name} is {Age} years old");
            Console.WriteLine($"{Name} is a {(_isSenior ? "senior" : "not a senior")}\n");
        }
    }
}