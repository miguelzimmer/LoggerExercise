// See https://aka.ms/new-console-template for more information
using CLI;
using CLI.Application;
using CLI.Domain.Information;

var log = new LogService();
var service = new InformationService(log);


var app = new App(service,log);
app.Run();
