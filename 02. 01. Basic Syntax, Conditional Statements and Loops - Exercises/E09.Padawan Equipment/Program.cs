double money = double.Parse(Console.ReadLine());
int students  = int.Parse(Console.ReadLine());
double lightsaberPrice = double.Parse(Console.ReadLine());
double robePrice = double.Parse(Console.ReadLine());
double beltPrice = double.Parse(Console.ReadLine());

double lightsabers = Math.Ceiling(students * 1.1);
int robes = students;
int belts = (students - students / 6); ;

double lightsabersMoney = lightsabers * lightsaberPrice;
double robesMoney = robes * robePrice;
double beltsMoney = belts * beltPrice;

double totalCost = lightsabersMoney + robesMoney + beltsMoney;

//if (money >= totalCost)
//{
//    Console.WriteLine($"The money is enough - it would cost {totalCost:f2}lv.");
//}
//else
//{
//    Console.WriteLine($"John will need {totalCost - money:f2}lv more.");
//}

bool moneyIsEnough = money >= totalCost;

string result = moneyIsEnough 
    ? $"The money is enough - it would cost {totalCost:f2}lv." 
    : $"John will need {totalCost - money:f2}lv more.";

Console.WriteLine(result);






















//Console.WriteLine(lightsabersMoney);
//Console.WriteLine(robesMoney);