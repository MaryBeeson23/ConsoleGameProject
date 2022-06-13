namespace Game_Repository;



public class TJ : LivingCreature
{
    public TJ() : base()
    {

    }
    public TJ(string Name, int Level, int HP) : base ( maxHP, currentHP)
    {
        this.Name = Name;
        this.Level = Level;
        this.Weapon = Weapon;
    }
    public string Name {get; set; }
    
    public int Level {get; set; }

    public Weapon Weapon {get; set; }
    public int WeaponDMG {get {
        switch (Weapon)
        {
            case Weapon.PowerPole:
                return 50;
                break;
            case Weapon.BraveSword:
                return 75;
                break;
            case Weapon.SickleOfSorrow:
                return 100;
                break;
            case Weapon.KameHameHa:
                return 1000;
                break;
            default:
                return 0;
                break;
        }
    } }

}

public enum Weapon {
    PowerPole,
    BraveSword,
    SickleOfSorrow,
    KameHameHa
}