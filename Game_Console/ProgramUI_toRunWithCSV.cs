public class ProgramUI
    {
        public void Run()
        {
            string sequenceString = File.ReadAllText("./ConsoleGameProject/CSV.csv");
            string[] interactionsArray = sequenceString.Split(',');

            int tJCurrentHP = 9001;
            int weaponDMG = 50;

            int healingChamberValue = 3000;

            int androidHP = 50;
            int androidDamage = 50;

            //add something for dragonball?
            //add something for weapon type? or just use multiplier to adjust weapon damage and only reference weapon type in writeline?

            while (tJCurrentHP > 0)
            {
                foreach (string interaction in interactionsArray)
                {
                    switch (interaction)
                    {
                        case "android0":
                        System.Console.WriteLine("Prepare to meet your DOOOOOOM!");
                        tJCurrentHP - androidDamage;
                        
                    }
                }
            }
            

        }
    }
