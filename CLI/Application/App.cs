using CLI.Domain.Information;

namespace CLI.Application
{
    internal class App
    {
        private const int SLEEPTIME = 2 * 1000;

        private readonly InformationService _informationService;
        private readonly  LogService _logService;

        public App(InformationService informationService, LogService logService)
        {
            _informationService = informationService;
            _logService = logService;
        }
        public void Run()
        {
            try
            {
                _logService.LogInformation("LOG INICIALIZADO");
                // logging of application start would be called here
                DrawMenu();
                var option = ReadOption();
                while (option != 6)
                {
                    switch (option)
                    {
                        case 1:
                            var name = _informationService.ReadUserFullname();                 
                            _logService.LogInformation($"Voce digitou: {name}");
                          
                            // logging of the read user fullname operation would be called here
                            break;
                        case 2:
                            var ocupation = _informationService.ReadOccupation();
                            _logService.LogInformation($"Voce digitou: {ocupation}");

                            // logging of the read occupation operation would be called here
                            break;
                        case 3:
                           var birthDate =  _informationService.ReadBirthDate();
                            _logService.LogInformation($"Voce digitou: {birthDate}");
                            // logging of the read birth date operation would be called here
                            break;
                        case 4:
                            var hobbies = _informationService.ReadHobbies();
                            _logService.LogInformation($"Voce digitou: {hobbies}");
                            // logging of the read hobbies operation would be called here
                            break;
                        case 5:
                            _logService.ListLogs();
                            break;
                    }
                    DrawMenu();
                    option = ReadOption();
                }
                _logService.LogInformation("LOG Finalizado");
                Exit();
                // logging of application exit would be called here
                
            }
            catch (Exception ex)
            {
                _logService.LogInformation(ex.Message);
                // logging of application error would be called here
            }

        }

        
        private void DrawMenu()
        {
            Console.Clear();

            Console.WriteLine("Hello, Miguel!");
            Console.WriteLine("This is an exercise to assess your programming, communication and problem solving skills.");
            Console.WriteLine();
            Console.WriteLine("Enter your option: ");
            Console.WriteLine("1. Enter full name");
            Console.WriteLine("2. Enter profession");
            Console.WriteLine("3. Enter birth date");
            Console.WriteLine("4. Enter hobbies");
            Console.WriteLine("5. Show operation logs");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
           
        }

        private int ReadOption()
        {
            var input = Console.ReadLine();
            int.TryParse(input, out int option);
            if (option < 1 || option > 6)
            {
                Console.WriteLine("Invalid option.");
                Thread.Sleep(SLEEPTIME);
                DrawMenu();
            }

            return option;
        }

        private void Exit()
        {
            // In here you should show the logs or point to a file with the logs
            _logService.GenerateFile();
            Console.WriteLine("Thanks for playing.");
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("Bye!");
            Thread.Sleep(SLEEPTIME);
        }
    }
}
