using System;


namespace GymBokingSys
{
    class LogReg
    {
        
        public void Login()
        {
            var arrUsers = new Users01[]
            {
            new Users01("a","1",1234),
            new Users01("John","pass2",15),
            new Users01("Jane","pass2",32)
            };
            //Skall skrivas till fil

        Start:
            Console.WriteLine("For login press 1 or for register 2");
            var input = Console.ReadLine();



            bool successfull = false;
            //return True
            while (!successfull)
            {

                if (input == "1")
                {
                    Console.WriteLine("Write your username:");
                    var username = Console.ReadLine();
                    Console.WriteLine("Enter your password:");
                    var password = Console.ReadLine();


                    foreach (Users01 user in arrUsers)
                    {
                        if (username == user._name && password == user._password)
                        {
                            Console.WriteLine("You have successfully logged in !!!");
                            Console.ReadLine();
                            successfull = true;
                            
                            break;
                        }
                    }

                    if (!successfull)
                    {
                        Console.WriteLine("Your username or password is incorect, try again !!!");
                    }

                }

                else if (input == "2")
                {

                    Console.WriteLine("Enter your username:");
                    var username = Console.ReadLine();

                    Console.WriteLine("Enter your password:");
                    var password = Console.ReadLine();

                    Console.WriteLine("Enter your PhoneNumber:");
                    int phoneNumber = int.Parse(Console.ReadLine());


                    Array.Resize(ref arrUsers, arrUsers.Length + 1);
                    arrUsers[arrUsers.Length - 1] = new Users01(username, password, phoneNumber);
                    successfull = true;
                    goto Start;

                }
                else
                {
                    Console.WriteLine("Try again !!!");
                    break;


                }

            }

        }
    }

}
