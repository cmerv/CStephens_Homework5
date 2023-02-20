using System;

class Homework5
{
    static void Main(string[] args)
    {
    start:
        Console.WriteLine("Input your desired Method to run");
        Console.WriteLine("greaterthan-2int");
        Console.WriteLine("greaterthan-4int");
        Console.WriteLine("accountcreation");
        string selection = Console.ReadLine();
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
                int intA_2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type an integer or integer B:");
                int intB_2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type an integer or integer C:");
                int intC = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type an integer or integer D:");
                int intD = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"A = {intA_2}, B = {intB_2}, C = {intC}, D = {intD}");

                GreaterThan(intA_2, intB_2, intC, intD);
                break;

            case "accountcreation":
                Console.WriteLine("Account Creation Program...");
                createAccount();
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
                }
                break;
        }


    }
    static bool checkAge(int birthYear)
    {
        if (2023-birthYear >= 18) // if we are 18+ then we can keep going
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void createAccount()
    {
        Console.WriteLine("Please input a username:");
        string userName = Console.ReadLine();
    	passwordinput: // label to return to
        Console.WriteLine("Please input a password:");
        string userPass = Console.ReadLine();
        Console.WriteLine("Please input the password again to confirm:");
        string userPass2 = Console.ReadLine();

        Console.WriteLine("Input a birth year from 1900 to 2023:");
        int birthYear = Convert.ToInt16(Console.ReadLine());
        if (birthYear >= 1900 && birthYear <= 2023)
        {
            bool isOfAge = checkAge(birthYear);
            if (isOfAge == true){
                if (userPass == userPass2) // check to make sure our passwords are equal
                {
                Console.WriteLine("Account is created successfully.");
				}
				else {
                    Console.WriteLine("Your password confirmation did not match your password.");
                    goto passwordinput; // repeat password input process if failed.
                }
			}
            else
            {
                Console.WriteLine("Could not create an account.");
            }
        }
        else
        {
            Console.WriteLine("You have input an invalid birth year.");
			goto passwordinput; 
        }
    }
}