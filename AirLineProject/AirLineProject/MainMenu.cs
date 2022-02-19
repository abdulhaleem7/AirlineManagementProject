using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLineProject
{
    public class MainMenu
    {


        public void MainMen()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("        WELCOME TO PATIENCE AIRLINE ");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            bool exit = false;
            while (!exit)
            {

                Console.WriteLine("1.BOOK FLIGHT:\n2.COMPANY DETAILS:\n0.To exit");
                Console.Write("ENTER NUM: ");
                int Num = int.Parse(Console.ReadLine());
                if (Num == 1)
                {
                    Booking();
                }
                else if (Num == 2)
                {
                    Company();
                }
                else if (Num == 0)
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
               
                    
               
                
            }           
        }
        public void Company()
        {
            AirLineContext airLineContext = new();
            AdministratorRepository administratorRepository = new AdministratorRepository(airLineContext);
            var count = airLineContext.Administrators.Count();



            bool correct = false;
            while (!correct)
            {
                Console.Write("Admin Passwod: ");
                string password = Console.ReadLine();
                var verifypassword = airLineContext.Administrators.FirstOrDefault(x => x.Password == password);

                if (verifypassword != null)
                {
                    correct = true;
                    bool exit = false;

                    while (!exit)
                    {
                        Console.WriteLine("1.FLIGHTS:\n2.AIRCRAFT:\n3.ADMIN OFFICE:\n4.Passenger details\n0.To LogOut:");

                        Console.Write("Enter num: ");
                        int num = int.Parse(Console.ReadLine());
                        if (num == 1)
                        {
                            FlightRoom();
                        }
                        else if (num == 2)
                        {
                            AircraftEntry();
                        }
                        else if (num == 3)
                        {
                            AddminOffice();
                        }
                        else if (num == 4)
                        {
                            PassengerDetails();
                        }
                        else if (num == 0)
                        {
                            exit = true;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect input");
                        }


                    }

                }
                else
                {
                    Console.WriteLine("invalid password!!!\nTry Again");

                }

            }
            
        }

        public void AddminOffice()
        {
            AirLineContext context = new AirLineContext();
            AdministratorRepository administratorRepository = new AdministratorRepository(context);



            Console.WriteLine("WELCOME TO ADMINISTRATOR OFFICE!!!");
            bool exit = false;
            while (!exit)
            {
                
                Console.WriteLine("1.Register ADMIN\n2.Get admin with ID\n3.Get all admin\n4.Update Admin\n5.Delete Admin\tNB:there must be atleast one admin before deleting any admin\n0.Previous Menu");
                Console.Write("eNTER A NUM:");
                int num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    administratorRepository.Create();
                }
                else if (num == 2)
                {
                    administratorRepository.GetAdminWithId();
                }
                else if (num == 3)
                {
                    administratorRepository.GetAllAdmin();
                }
                else if (num == 4)
                {
                    administratorRepository.UpdateAdminWithId();
                }
                else if (num == 5)
                {
                    administratorRepository.DeleteManager();
                }
                else if (num == 0)
                {
                exit = true;
                }
                else
                {
                    Console.WriteLine("invalid input!!");
                }
                   
                
                
            }
           

        }
        public void FlightRoom()
        {
        
            AirLineContext context = new AirLineContext();
            AircraftRepository aircraftRepository = new AircraftRepository(context);
            FlightRepository flightRepository = new FlightRepository(context, aircraftRepository);

            Console.WriteLine("FLIGHT DEPT");
            bool exit = false;
            while (!exit)
            {
               
                Console.WriteLine("1.create flight\n2.Get flight with ID\n3.Get all flight\n4.Update flight with ID\n5.Delete flight\n0...To previous menu");
                Console.Write("ENter num: ");
                int num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    flightRepository.CreateFlight();
                }
                else if (num == 2)
                {
                    flightRepository.GetFligfhtWithID();
                }
                else if (num == 3)
                {
                    flightRepository.GetAllFlight();
                }
                else if (num == 4)
                {
                    flightRepository.UpdateFlightWithId();
                }
                else if (num == 5)
                {
                    flightRepository.Deleteflight();
                }
                else if(num==0)
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Incorrect Input");
                }
                    
                
               
                
            }
           
        }
        public void AircraftEntry()
        {
            AirLineContext context = new AirLineContext();
            AircraftRepository aircraftRepository = new AircraftRepository(context);
            bool exit = false;
            while (!exit)
            {
                
                Console.WriteLine("1.Create Aircraft\n2.Get Aircrat With ID\n3.Get All Aircraft\n4.Update Aircraft\n5.Delete Aircraft\n0.to previous menu");
                Console.Write("Enter number:");
                int num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    aircraftRepository.CreateAirCraft();
                }
                else if (num == 2)
                {
                    aircraftRepository.GetAirCraftWithId();
                }
                else if (num == 3)
                {
                    aircraftRepository.GetAllAircraft();
                }
                else if (num == 4)
                {
                    aircraftRepository.UpdateAircraftWithId();
                }
                else if (num == 5)
                {
                    aircraftRepository.DeleteAircraft();
                }
                else if(num==0)
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("incorrect input!!");
                }
                   
                
                
            }
           
        }
        public void PassengerDetails()
        {
            AirLineContext context = new AirLineContext();
            AircraftRepository aircraftRepository = new AircraftRepository(context);

            FlightRepository flightRepository = new FlightRepository(context, aircraftRepository);
            PassengerRepository passengerRepository = new PassengerRepository(context, flightRepository);
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("1.Get Customer With ID\n2.Get All Customer\n0.To previous Menu");
                Console.WriteLine("Enter Number: ");
                int num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    passengerRepository.GetCustomerWithID();
                }
                else if (num == 2)
                {
                    passengerRepository.GetAllCustomer();
                }
                else if(num==0)
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input!!");
                }
                
                
            }
            
        }
        public void Booking()
        {
            AirLineContext context = new AirLineContext();
            AircraftRepository aircraftRepository = new AircraftRepository(context);
            FlightRepository flightRepository = new FlightRepository(context, aircraftRepository);
            PassengerRepository passengerRepository = new PassengerRepository(context, flightRepository);
            bool exit = false;
            while (!exit)
            {
                
                Console.WriteLine("1.Book\n0.To previous menu");
                Console.WriteLine("Enter Number: ");
                int num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    passengerRepository.BookFlight1();
                }
                else if (num == 0)
                {
                    exit = true; 
                }
                
            }
        }

    }
}
