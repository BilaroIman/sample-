// See https://aka.ms/new-console-template for more information
double km, meter, feet, cm, inches;
Console.WriteLine("Enter the Distance in kilometer:");
km = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("kilomoter to meter:"); 
Console.WriteLine(km * 1000.0);

Console.WriteLine("kilomoter to feet:");
Console.WriteLine(km * 3280.84);

Console.WriteLine("kilomoter to centimeter:");
Console.WriteLine(km * 39370.1);

Console.WriteLine("kilomoter to inches:");
Console.WriteLine(km * 100000);




