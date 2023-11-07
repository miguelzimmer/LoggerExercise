namespace CLI.Domain.Information
{
    internal class InformationService
    {
    
        public string ReadUserFullname()
        {
            Console.WriteLine("What's your name?");
            return Console.ReadLine()!;
        }

         public string ReadOccupation()
        {
            Console.WriteLine("What's your profession?");
            return Console.ReadLine()!;
        }

        public string ReadBirthDate()
        {
            Console.WriteLine("What's your birth date?");
            return Console.ReadLine()!;
        }

        public string ReadHobbies()
        {
            Console.WriteLine("What's your Hobbies?");
            return Console.ReadLine()!;
        }
    }
}
