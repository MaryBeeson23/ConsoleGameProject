using Game_Repository;

namespace Game_Console
{
    public class ProgramUI
    {
        public readonly TJ _tJ = new TJ();
        public readonly Androids _androids = new Androids();
        public readonly Bosses _bosses = new Bosses();
        public readonly Items _items = new Items();
        public readonly Location _location = new Location();

        public void Run(){
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
                Bosses bosses0 = new Bosses("Cell", 1000);
                Bosses bosses1 = new Bosses("Frieza", 2000);
                Bosses bosses2 = new Bosses("Vegeta", 3000);
            }

            private void PlayerHeal(TJ _tJ){
                int maxHP = _tJ.MaxHP;

                if (_tJ.CurrentHP < 9001){
                    _tJ.CurrentHP = maxHP;
                }
            }

            private void TJDamage(TJ tj, Androids androids){
                int damageToAndroid = tj.WeaponDMG;
                int androidCurrentHP = androids.CurrentHP;
                
                if (androidCurrentHP <= damageToAndroid){
                androidCurrentHP = 0;
                } 
                else {
                    androidCurrentHP = androidCurrentHP - damageToAndroid;
                }
            }
    }
}