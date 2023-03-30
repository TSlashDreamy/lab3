using lab3;

try
{
    Ship ship = new Ship(2000, 90, 1941, 40, "La manche");
    Car car = new Car(4000, 120, 1702);
    Plain plain = new Plain(12000, 340, 1920, 500, 50);

    Console.WriteLine(ship.GetInfo());
    Console.WriteLine("New cost: " + ship.CalculateCost());

    Console.WriteLine(plain.GetInfo());
    Console.WriteLine("New cost: " + plain.CalculateCost());

    Console.WriteLine(car.GetInfo());
    Console.WriteLine("New cost: " + car.CalculateCost());
} catch (Exception exc)
{
    Console.WriteLine("Wrong object creation: " + exc);
}
