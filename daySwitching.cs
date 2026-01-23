Console.Write("Enter day(1-7): ");
int day = Convert.ToInt32(Console.ReadLine());

// int day = 4;
switch (day)
{
	case 1: Console.WriteLine("Monday"); break;
	case 2: Console.WriteLine("Tueday"); break;
	case 3: Console.WriteLine("Wednesday"); break;
	case 4: Console.WriteLine("Thursday"); break;
	case 5: Console.WriteLine("Friday"); break;
	case 6: Console.WriteLine("Satday"); break;
	case 7: Console.WriteLine("Sunday"); break;
	default: Console.WriteLine("Enter a valid day between 1-7!"); break; // default case
}