namespace ValueTypeReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            //value type
            var x = 10;
            var y = x;
            y = 90;
            Console.WriteLine(x);//print 10



            //reference type
            var user = new User { Age = 50 };
            var user2 = user;

            user2.Age = 90;
            Console.WriteLine(user.Age);//print 90

        }
    }

    class User
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
