namespace Game_Repository;



public class TJ : LivingCreature
{
    public TJ() : base()
    {

    }
    public TJ(string Name, Weapon Weapon) : base ( MaxHP, CurrentHP)
    {
        this.Name = Name;
        this.Weapon = Weapon;
    }
    public string Name {get; set; }
    
    public WeaponType Weapon {get; set; }
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

public enum WeaponType {
    PowerPole,
    BraveSword,
    SickleOfSorrow,
    KameHameHa
}