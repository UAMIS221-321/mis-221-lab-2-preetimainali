
const double SANDWICH_COST = 4.75;
const double TOPPING_COST = 0.55;
const double DISCOUNT = 0.1;

int numOfSandwiches = 0;
int numOfToppings = 0;
double tipAmount = 0;

Console.WriteLine("Enter number of sandwiches");
numOfSandwiches = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number of toppings");
numOfToppings = int.Parse(Console.ReadLine());

Console.WriteLine("Enter tip amount");
tipAmount = double.Parse(Console.ReadLine());

double sandwichCost = 0;
sandwichCost = SANDWICH_COST * numOfSandwiches;

double toppingCost = 0;
toppingCost = TOPPING_COST * numOfToppings;

double baseCost=0;
baseCost= sandwichCost + toppingCost;

double orderCost=0;
orderCost= tipAmount + baseCost*(1 - DISCOUNT);

System.Console.WriteLine($"Your order cost is {orderCost}");









