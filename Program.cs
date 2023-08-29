// See https://aka.ms/new-console-template for more information

namespace TicketSystemApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Ticket");
                Console.WriteLine("2. Quit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    AddTicket();
                }
                else if (choice == "2")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                }
            }
        }

        static void AddTicket()
        {
            Console.Write("Enter TicketID: ");
            string ticketID = Console.ReadLine();
            Console.Write("Enter Summary: ");
            string summary = Console.ReadLine();
            Console.Write("Enter Status: ");
            string status = Console.ReadLine();
            Console.Write("Enter Priority: ");
            string priority = Console.ReadLine();
            Console.Write("Enter Submitter: ");
            string submitter = Console.ReadLine();
            Console.Write("Enter Assigned: ");
            string assigned = Console.ReadLine();
            Console.Write("Enter who are you Watching: ");
            string watching = Console.ReadLine();

            string newRecord = $"{ticketID},{summary},{status},{priority},{submitter},{assigned},{watching}";

            // new record to the CSV file
            string csvFilePath = "Tickets.csv";
            using (StreamWriter writer = File.AppendText(csvFilePath))
            {
                writer.WriteLine(newRecord);
            }

            Console.WriteLine("Ticket added successfully!");
        }
    }
}
