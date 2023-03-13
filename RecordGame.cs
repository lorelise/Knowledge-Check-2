using System.Runtime.CompilerServices;

namespace Knowledge_Check_2
{
    internal class RecordGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is used for adding records of types of MMORPG games.");
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<MMORPG>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                
                // In this loop, populate the object's properties using Console.ReadLine()
                var massiveMulti = new MMORPG();

                Console.WriteLine("Enter the name of the MMORPG:");
                massiveMulti.Name = Console.ReadLine();

                Console.WriteLine("Enter the price of purchase:");
                massiveMulti.Price = Decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter the systems this MMORPG is available on:");
                massiveMulti.Systems = Console.ReadLine();

                Console.WriteLine("Enter a brief description of the game:");
                massiveMulti.Description = Console.ReadLine();

                Console.WriteLine("Does this MMORPG have character creation? (true or false)");
                massiveMulti.CharacterCreation = bool.Parse(Console.ReadLine());

                Console.WriteLine("Does this MMORPG have open-world exploration? (true or false?)");
                massiveMulti.OpenWorld = bool.Parse(Console.ReadLine());
             
                Console.WriteLine("Does this MMORPG require a paid subscription service? (true or false)");
                massiveMulti.PaidSubscription = bool.Parse(Console.ReadLine());

                Console.WriteLine("What is the subscription cost? (0 if none)");
                massiveMulti.SubscriptionCost = Decimal.Parse(Console.ReadLine());
                Console.ReadLine();

                recordList.Add(massiveMulti);
            }

            // Print out the list of records using Console.WriteLine()
            foreach (var record in recordList)
            {
                Console.WriteLine($"MMORPG Details: \nName: {record.Name} \nPrice: ${record.Price} \nSystem(s) available: {record.Systems} \nDescription: {record.Description} ");
                Console.WriteLine($"Character creation: {record.CharacterCreation} \nOpen-world Exploration: {record.OpenWorld} \nPaid subscription: {record.PaidSubscription} \nSubscription cost (per month): ${record.SubscriptionCost}\n");
            }
            
        }
    }
}