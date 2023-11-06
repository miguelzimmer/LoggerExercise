namespace CLI.Domain.Information
{
    internal class InformationService
    {
        LogService log = new LogService();  
        public void ReadUserFullname()
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine()!;
            string dateTime = DateTime.Now.ToString();
            Console.ReadLine();
            log.LogInformation(name, dateTime);
           
        }

        public void ReadOccupation()
        {
          Console.WriteLine("What's your profession?");
          string occupation = Console.ReadLine()!;
          string dateTime = DateTime.Now.ToString();
          log.LogInformation(occupation, dateTime);
        
        }

        public void ReadBirthDate()
        {
          Console.WriteLine("What's your birth date?");
          string birthDate = Console.ReadLine()!;
          string dateTime = DateTime.Now.ToString();
          log.LogInformation(birthDate, dateTime);
        }

        public void ReadHobbies()
        {
          Console.WriteLine("What's your Hobbies?");
          string hobbies = Console.ReadLine()!;
          string dateTime = DateTime.Now.ToString();
          log.LogInformation(hobbies, dateTime);

        }
    }
}
