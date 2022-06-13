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
    }
}