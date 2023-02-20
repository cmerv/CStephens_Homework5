namespace CStephens_Homework5;
class Homework5
{
    static void Main(string[] args)
    {
    start:
        Console.WriteLine("Input your desired Method to run");
        Console.WriteLine("greaterthan-2int");
        Console.WriteLine("greaterthan-4int");
        Console.WriteLine("accountcreation");
        string? selection = Console.ReadLine();
        //
        switch (selection?.ToLower())
        {

            default:
                Console.WriteLine("Wrong method name entered. Restarting program.");
                goto start;

            case "greaterthan-2int":
                Console.WriteLine("2 Number Greater Than Program...");
                Console.WriteLine("Type an integer for integer A:");
                int intA = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Type an integer or integer B:");
                int intB = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine($"A = {intA}, B = {intB}");
                GreaterThan(intA, intB);
                break;

            case "greaterthan-4int":
                Console.WriteLine("4 Number Greater Than Program...");
                Console.WriteLine("Type an integer for integer A:");
                int intA = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Type an integer or integer B:");
                int intB = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Type an integer or integer C:");
                int intC = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Type an integer or integer D:");
                int intD = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine($"A = {intA}, B = {intB}, C = {intC}, D= {intD}");
        
                GreaterThan(intA, intB, intC, intD);
                break;

            case "accountcreation":
                break;
        }

    }
    static void GreaterThan(int gtIntA, int gtIntB)
    {
        bool gtResult = gtIntA > gtIntB;
        switch (gtResult)
        {
            case true:
                Console.WriteLine($"The greater number is {gtIntA}");
                break;

            case false:
                Console.Write($"The greater number is {gtIntB}");
                break;
        }
        static void GreaterThan(int gtIntA, int gtIntB, int gtIntC, int gtIntD)
        {
            bool gtResultAB = gtIntA > gtIntB;
            bool gtResultAC = gtIntA > gtIntC;
            bool gtResultAD = gtIntA > gtIntD;
            bool gtResultBC = gtIntB > gtIntC;
            bool gtResultBD = gtIntB > gtIntD;
            bool gtResultCD = gtIntC > gtIntD;
            switch (gtResultAB)
            { // Tier 1
                case true: // A > B 
                    switch (gtResultAC)
                    { // Tier 2
                        case true: // A > C
                            switch (gtResultAD)
                            { // Tier 3
                                case true: // A is the largest number
                                    Console.WriteLine($"The greater number is {gtIntA}");
                                    break;
                                case false: // D is the largest number
                                    Console.WriteLine($"The greater number is {gtIntD}");
                                    break;
                            }
						break;
                        case false: // C > A
                            switch (gtResultCD)
                            { // Tier 3
                                case true: // C is the largest number
                                    Console.WriteLine($"The greater number is {gtIntC}");
                                    break;
                                case false: // D is the largest number
                                    Console.WriteLine($"The greater number is {gtIntD}");
                                    break;

                            }
						break;
                    }
				break;
                case false: // B > A
                    switch (gtResultBC)
                    { // Tier 2
                        case true: // B > C
                            switch (gtResultBD)
                            { // Tier 3
                                case true: // B is the largest number
                                    Console.WriteLine($"The greater number is {gtIntB}");
                                    break;

                                case false: // D is the largest number
                                    Console.WriteLine($"The greater number is {gtIntD}");
                                    break;


						
                            }
						break;
					case false: // C > B
                   		 switch (gtResultCD)
                            { // Tier 3
                                case true: // C is the largest number
                                    Console.WriteLine($"The greater number is {gtIntC}");
                                    break;

                                case false: // D is the largest number
                                    Console.WriteLine($"The greater number is {gtIntD}");
                                    break;



                            } 
					break;
                    } break;
            }


     }
	}
}