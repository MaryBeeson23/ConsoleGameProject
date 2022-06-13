namespace Game_Repository;

    public class Androids : LivingCreature
    {
        public Androids()
        {

        }
        public Androids(string AndroidName, int AndroidAtkDMG)
        {
            this.AndroidName = AndroidName;
            this.AndroidAtkDMG = AndroidAtkDMG;
        }
        public string AndroidName { get; set; }
        public int AndroidAtkDMG { get; set; }
    }
