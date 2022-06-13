namespace Game_Repository;



public class TJ : LivingCreature
{
    public TJ() : base()
    {

    }
    public TJ(string Name, WeaponType Weapon) : base ( MaxHP, CurrentHP)
    {
        this.Name = Name;
        this.Weapon = Weapon;
    }
    public string Name {get; set; }
    
    public WeaponType Weapon {get; set; }
    public int WeaponDMG {get {
        switch (Weapon)
        {
            case WeaponType.PowerPole:
                return 50;
                break;
            case WeaponType.BraveSword:
                return 75;
                break;
            case WeaponType.SickleOfSorrow:
                return 100;
                break;
            case WeaponType.KameHameHa:
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