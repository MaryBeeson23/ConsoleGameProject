namespace Game_Repository;



public class TJ : Saiyen
{
    public TJ()
    {

    }
    public TJ()
    {
        this.Name = Name;
        this.Level = Level;
        this.HP = HP;
        this.Weapon = Weapon;


    }
    public string Name (get; set; )
    
    public int Level (get; set; )

    public int HP (get; set; )

    public enum Weapon (get; set; )


}

public enum Weapon {
    PowerPole,
    BraveSword,
    SickleOfSorrow,
    KameHameHa
}