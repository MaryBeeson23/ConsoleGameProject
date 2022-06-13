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

    public class Bosses : LivingCreature 
    {
        public Bosses() : base()
        {

        }
        public Bosses(string BossName, int BossAtkDMG) : base (MaxHP, CurrentHP)
        {
            this.BossName = BossName;
            this.BossAtkDMG = BossAtkDMG;
        }
        public string BossName { get; set; }
        public int BossAtkDMG { get; set; }
    }
