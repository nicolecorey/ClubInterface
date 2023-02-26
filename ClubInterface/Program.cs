interface IClub
{
    //Properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //Methods
    public string Fullname();
}
class Program
{
    class ClubMember : IClub
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Hobby { get; set; }

        public ClubMember()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Gender = string.Empty;
            Age = 0;
            Hobby = string.Empty;
        }
        public ClubMember(int id, string firstName, string lastName, string gender, int age, string hobby)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Age = age;
            Hobby = hobby;
        }

        public string Fullname()
        {
            return FirstName + " " + LastName;
        }
        public string Display()
        {
            return "Gender: " + Gender + "\nHobby: " + Hobby + "\nAge: " + Age;
        }
    }
    static void Main(string[] args)
    {
        
        ClubMember Bob = new ClubMember(10, "Bob", "Ross", "Male", 50, "Painting");
        Console.WriteLine($"ID:" + Bob.Id);
        Console.WriteLine($"Name:" + Bob.Fullname());
        Console.WriteLine($"{Bob.Display()}");


        ClubMember Chuck = new ClubMember();
        Chuck.Id = 20;
        Chuck.FirstName = "Chuck";
        Chuck.LastName = "Norris";
        Chuck.Gender = "Male";
        Chuck.Age = 40;
        Chuck.Hobby = "Fighting";
        Console.WriteLine($"ID:" + Chuck.Id);
        Console.WriteLine($"Name:" + Chuck.Fullname());
        Console.WriteLine($"{Chuck.Display()}");

    }
}
