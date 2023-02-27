namespace ObjectOrientedProgramming;

public class InheritanceExample
{
    public void Test()
    {
        LaserGun laser = new LaserGun();
        laser.Damage = 9000;
        laser.LaserColor = "Red";
        
        
        Weapon weapon = new LaserGun();
        weapon.Damage = 9000;
        // weapon.LaserColor = "Red";

        
        // LaserGun laser = new LaserGun();
        // laser.Damage = 9000;
        // laser.LaserColor = "Red";
        //
        // Weapon laserCasted = laser;
        // laserCasted.Damage = 9001;
        // laserCasted.LaserColor = "GREEN";
    }

    public class LaserGun : Weapon
    {
        public string LaserColor { get; set; }
    }

    public class MachineGun : Weapon
    {
        public int RoundsPerMinute { get; set; }
    }
    
    public class Weapon
    {
        public int Damage { get; set; }
    }
}
