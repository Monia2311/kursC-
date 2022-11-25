using ALXCalculator;
using ALXCalculator.Interfaces;//trzeba dodać alt+enter po najechaniu na ICalculator

Console.WriteLine("-- ALX CALCULATOR --");
ICalculator calculator = new Calculator();
calculator.Run();

Console.WriteLine("--------------------");
