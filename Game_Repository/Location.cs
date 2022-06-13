namespace Game_Repository
{
    public class Location
    {
        public Location()
        {
            
        }
        
        public Location(string Name, string Description, bool FoundWeapon)
        {   
            this.Name = Name;
            this.Description = Description;
            this.FoundWeapon = FoundWeapon;
        }

        public string Name { get; set; }
        public string Description { get; set; }

        public bool FoundWeapon { get; set; }
    }
}