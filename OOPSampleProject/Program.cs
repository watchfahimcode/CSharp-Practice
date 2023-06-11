// See https://aka.ms/new-console-template for more information

using OOPSampleProject.Models;


var engine = new Engine()
{

    EngineModel = "H932klsd",
    EngineBrand = "Lamborghini",
    EngineHorsePower = 6000

};

var car = new Car(engine);



string carInfo = "";
Console.WriteLine("Start Car...");
 carInfo = car.Start();
Console.WriteLine(carInfo);


Console.WriteLine("Innitiate Accelaration...");
carInfo = car.Accelarate(); 

Console.WriteLine(carInfo);
