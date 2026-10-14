/*
*Christian Michael Lehman
*CSCI 1250, Section 002
*Lab 04, The Group Trip
*October 7, 2026
*Calculates the fuel, food, and work hours behind a road trip.
*/

//part 1 - The Trip
Console.Write("What is the round trip in miles? ");
int tripMiles = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the miles per gallon of your car? ");
int milesPerGallon = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the gas price per gallon? ");
double gasPrice = Convert.ToDouble(Console.ReadLine());

Console.Write("How many pizzas will you order? ");
int numberOfPizzas = Convert.ToInt32(Console.ReadLine());

Console.Write("What's the cost of 1 piza? ");
double onePizzaCost = Convert.ToDouble(Console.ReadLine());

const double Slices = 8;
//math

double gallonsNeeded = tripMiles / (double)milesPerGallon;
double fuelCost = gallonsNeeded * gasPrice;
double totalPizzaCost = numberOfPizzas * onePizzaCost;
double tripTotal = fuelCost + totalPizzaCost;

//output
System.Console.WriteLine("=== Part 1: The Trip ===");
System.Console.WriteLine("Fuel Cost: " + FuelCost(tripMiles, milesPerGallon, gasPrice).ToString("C"));
System.Console.WriteLine("Pizza cost: " + totalPizzaCost.ToString("C"));
System.Console.WriteLine("Trip total: " + tripTotal.ToString("C"));

//part 2 - The Group

string[] names = { "Ada", "Grace", "Alan", "Katherine" };
double[] hoursWorked = { 22, 15, 30, 18 };
double[] hourlyRates = { 13.50, 16.00, 11.20, 14.80 };

//math

double totalSlices = numberOfPizzas * Slices;
double slicesEach = totalSlices / names.Length;
double costPerPerson = tripTotal / names.Length;
double totalHoursWorked = hoursWorked[0] + hoursWorked[1] + hoursWorked[2] + hoursWorked[3];

//output

System.Console.WriteLine("=== Part 2: The Group ===");
System.Console.WriteLine("People going: " + names.Length);
System.Console.WriteLine("Slices each: " + slicesEach.ToString("F1"));
System.Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));

//part 3 - The Report
const double taxRate = .18;
double PerHour = 0;

for (int i = 0; i < names.Length; i++)
{
TakeHomePay(hoursWorked[i], hourlyRates[i], taxRate);
PerHour = TakeHomePay(hoursWorked[i], hourlyRates[i], taxRate) / hoursWorked[i];
HoursToCover(costPerPerson, PerHour);
}

double[] hoursToCover = {HoursToCover(costPerPerson, PerHour)};
double longestTime = hoursToCover.Max();

double totalTakeHomePay = TakeHomePay(hoursWorked[0], hourlyRates[0], taxRate) + TakeHomePay(hoursWorked[1], hourlyRates[1], taxRate) + TakeHomePay(hoursWorked[2], hourlyRates[2], taxRate) + TakeHomePay(hoursWorked[3], hourlyRates[3], taxRate);

//output
System.Console.WriteLine("=== Part 3: Who Works How Long ===");
System.Console.WriteLine("Ada: takes home " + (TakeHomePay(hoursWorked[0], hourlyRates[0], taxRate)).ToString("C") +" for " + hoursWorked[0] + " hours, " + (hourlyRates[0] * .82).ToString("C") + " per hour, " + "must work " + HoursToCover(costPerPerson, PerHour).ToString("F2") + " hours");
System.Console.WriteLine("Grace: takes home " + (TakeHomePay(hoursWorked[1], hourlyRates[1], taxRate)).ToString("C") +" for " + hoursWorked[1] + " hours, " + (hourlyRates[1] * .82).ToString("C") + " per hour, " + "must work " + HoursToCover(costPerPerson, PerHour).ToString("F2") + " hours");
System.Console.WriteLine("Alan: takes home " + (TakeHomePay(hoursWorked[2], hourlyRates[2], taxRate)).ToString("C") +" for " + hoursWorked[2] + " hours, " + (hourlyRates[2] * .82).ToString("C") + " per hour, " + "must work " + HoursToCover(costPerPerson, PerHour).ToString("F2") + " hours");
System.Console.WriteLine("Katherine: takes home " + (TakeHomePay(hoursWorked[3], hourlyRates[3], taxRate)).ToString("C") +" for " + hoursWorked[3] + " hours, " + (hourlyRates[3] * .82).ToString("C") + " per hour, " + "must work " + HoursToCover(costPerPerson, PerHour).ToString("F2") + " hours");
System.Console.WriteLine();
System.Console.WriteLine("Total Hours Worked: " + totalHoursWorked);
System.Console.WriteLine("Total Take Home Pay: " + totalTakeHomePay.ToString("C"));
System.Console.WriteLine("Longest Anyone Must Work: " + longestTime.ToString("F2"));

//methods
static double FuelCost(double tripMiles, double milesPerGallon, double gasPrice)
{
    double gallonsNeeded = tripMiles / (double)milesPerGallon;
    double fuel = gallonsNeeded * gasPrice;
    return fuel;
}
static double TakeHomePay(double hoursWorked, double hourlyRate, double taxRate)
{
    double preTax = hoursWorked * hourlyRate;
    double tax = preTax * taxRate;
    double TakeHomePay = preTax - tax;
    return TakeHomePay;
}
static double HoursToCover(double costPerPerson, double PerHour)
{
    double HoursToCover = costPerPerson / PerHour;
    return HoursToCover;
}