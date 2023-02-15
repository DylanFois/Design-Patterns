using Design_Patterns.Builder;

Director director = new Director();
CarBuilder builder = new CarBuilder();

Car sportsCar = director.createSportsCar(builder);
Car suv = director.createSUV(builder);

String sportsCarString = sportsCar.engine + ", " + sportsCar.doors + ", " + sportsCar.seats;
String suvString = suv.engine + ", " + suv.doors + ", " + suv.seats;

Console.WriteLine(sportsCarString);
Console.WriteLine(suvString);