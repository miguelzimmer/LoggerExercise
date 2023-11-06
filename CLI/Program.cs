// See https://aka.ms/new-console-template for more information
using CLI;
using CLI.Application;
using CLI.Domain.Information;

var service = new InformationService();
var log = new LogService();

var app = new App(service,log);
app.Run();
