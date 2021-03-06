using Game_Repository;

namespace Game_Console
{
    public class ProgramUI
    {
        public readonly TJ _tJ = new TJ();
        public readonly Androids _androids = new Androids();
        //public readonly Bosses _bosses = new Bosses();
        // commented above line out, because i saw 'Bosses' was removed from Androids_Bosses class.
        public readonly Items _items = new Items();
        public readonly Location _location = new Location();

        public void Run(){
            string sequenceString = File.ReadAllText("./ConsoleGameProject/CSV.csv");
            string[] interactionsArray = sequenceString.Split(',');

            while (tJCurrentHP > 0)
            {
                foreach (string interaction in interactionsArray)
                {
                    // possibly move 'Seed();' function here so we can use our already built ifelse bools as well as type out switch cases when needed for interations, making bosses more unique?
                    // moving 'Seed();' does not work, may consider pulling our private voids higher so that we may use the our local varialbles in out interation arrays.
                }
            }

            Seed(); 
            RunMenu();
        }

        public void RunMenu() {
        }
        private void Seed(){
            TJ tJ = new TJ("Super Saiyan TJ", WeaponType.PowerPole);
            Androids androids0 = new Androids("Android 13", 5);
            Androids androids1 = new Androids("Android 15", 5);
            Androids androids2 = new Androids("Android 17", 5);
            /*Androids bosses0 = new Androids("Cell", 1000);
            Androids bosses1 = new Androids("Frieza", 2000);
            Androids bosses2 = new Androids("Vegeta", 3000);*/
            // commenting out boss stats for now to use switch cases instead, but also need to figure out how tj attacking bosses would be written out, possibly by adding 'attack' interaction into csv file and creating seperate switch case such as ' weaponDMG * weaponType = bossDMGtaken ' though i know thats probably not exactly right, its just a general idea worth brainstorming on. 
            }

        private void PlayerHeal(TJ _tJ){
            int maxHP = _tJ.MaxHP;

            if (_tJ.CurrentHP < 9001){
                _tJ.CurrentHP = maxHP;
            }
            }

        private void TJDamage(TJ tJ, Androids androids){
            int weaponDMG = tJ.WeaponDMG;
            int androidCurrentHP = androids.CurrentHP;
                
            if (androidCurrentHP <= weaponDMG){
            androidCurrentHP = 0;
            } 
            else {
                androidCurrentHP = androidCurrentHP - weaponDMG;
            }
            }

        private void EnemyDamage(TJ tJ, Androids androids){
            int androidAttackDMG = androids.AndroidAtkDMG;
            int tJCurrentHP = tJ.CurrentHP;
                
            if (tJCurrentHP <= androidAttackDMG){
            tJCurrentHP = 0;
            } 
            else {
                tJCurrentHP = tJCurrentHP - androidAttackDMG;
            }
            }
    }
}