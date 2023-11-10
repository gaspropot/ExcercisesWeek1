using ExcercisesWeek1.Assignment1;
using ExcercisesWeek1.Assignment2;
using ExcercisesWeek1.Assignment3;
using ExcercisesWeek1.Assignment4;

//Assignment1
StudentProfessorTest.Main();

//Assignment2
PhotoBookTest.Main();

//Assignment3
Console.WriteLine("Give the dog a name:");
var dogName = Console.ReadLine();
var dog = new Dog();
dog.SetName(dogName);
dog.GetName();
dog.Eat();

//Assignment4
var car = new Car(0);
Console.WriteLine("Give amount of gasoline to refuel:");
int.TryParse(Console.ReadLine(), out var gasolineToRefuel);
car.Refuel(gasolineToRefuel);
car.Drive();