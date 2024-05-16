
using Cars.CarInfo;

Car myCar = new Car("Toyota", 2022, 25000, 200);

// Read and display data
Console.WriteLine("Avto ma'lumotlari:");
Console.WriteLine(myCar.GetCarInfo());

// Update value
int yearsToDepreciate = 3;
decimal newPrice = myCar.CalculateDepreciation(yearsToDepreciate);
Console.WriteLine($"Mashina yangilangan narxi {yearsToDepreciate} yil o'tgandan so'ng: {newPrice}");