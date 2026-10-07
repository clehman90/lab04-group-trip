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
System.Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C"));
System.Console.WriteLine("Pizza cost: " + totalPizzaCost.ToString("C"));
System.Console.WriteLine("Trip total: " + tripTotal.ToString("C"));

//part 2 - Calculates pizza slices needed, how many slices each person gets, and the cost of the pizza.

//math

//double totalSlices = numberOfPizzas * Slices;
//double slicesPerPerson = totalSlices / numberOfPeople;

//output
//System.Console.WriteLine("Slices needed: " + totalSlices.ToString("F1"));
//System.Console.WriteLine("Slices per person: " + slicesPerPerson.ToString("F1"));
//System.Console.WriteLine("Pizza cost: " + totalPizzaCost.ToString("C"));

//part 3 - Calculates gross pay, tax withheld, and how much money you get after taxes.


//const double taxRate = .18;

//math

//double grossPay = hoursWorked * (double)hourlyRate;
//double taxWithheld = grossPay * (double)taxRate;
//double takeHomePay = grossPay - (double)taxWithheld;

//output
//System.Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
//System.Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
//System.Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));

//part 4 - Puts it all together and tells you the total trip cost, how much each person has to pay, your hourly rate after taxes, and how many hours you need to work to cover your share.
//double costPerPerson = tripTotal / numberOfPeople;
//double takeHomePayPerHour = takeHomePay / hoursWorked;
//double hoursNeeded = costPerPerson / takeHomePayPerHour;

//no math

//output
//System.Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
//System.Console.WriteLine("Take home pay per hour: " + takeHomePayPerHour.ToString("C"));
//System.Console.WriteLine("Hours you gotta work to cover your share: " + hoursNeeded.ToString("F2"));

//methods
static double FuelCost(double tripMiles, double milesPerGallon, double gasPrice)
{
    double gallonsNeeded = tripMiles / (double)milesPerGallon;
    double fuel = gallonsNeeded * gasPrice;
    return gallonsNeeded * gasPrice;
}
//static double TakeHomePay(double hours, double hourlyRate, double taxRate);
//static double HoursToCover(double amountOwed, double takeHomePerHour);