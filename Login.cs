using System;
namespace GymBokingSys
{
    public class Login
    {
        public Login()
        {
        }

        public int LoginAndReg()
        {
            var arrUsers = new Users01[]
            {
            new Users01("a","1",1234),
            new Users01("John","pass2",15),
            new Users01("Jane","pass2",32)
            };

            int run = 1;
            // Admin och anställda bör också lagras på fil
            string admn = "admin";
            string empl = "empl";

            while (run == 1)
            {
                Console.WriteLine("For login press 1 or for register 2");
                var input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Write your username:");
                    var username = Console.ReadLine();
                    Console.WriteLine("Enter your password:");
                    var password = Console.ReadLine();
                    // 1 User
                    // 2 Admin
                    // 3 Emloyee
                    foreach (Users01 user in arrUsers)
                    {
                        if (username == user._name && password == user._password)
                        {
                            if (user._password == admn)
                            {
                                return 2;
                            }
                            if (user.password == empl)
                            {
                                return 3;
                            }
                            else
                            {
                                return 1;
                            }
                                

                            Console.WriteLine("You have successfully logged in !!!");
                            Console.ReadLine();


                            
                        }
                        
                    }

                    Console.WriteLine("Your username or password is incorect, try again !!!");
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
                                       
                }

            }

            

            return 4;



        }
    }
}
