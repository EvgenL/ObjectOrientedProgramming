namespace ObjectOrientedProgramming;

public class UpCastEncapsulationExample
{
    public static void Test()
    {
        LaserGun laser = new LaserGun();
        laser.LaserColor = "White";

        MachineGun machineGun = new MachineGun();
        machineGun.RoundsPerMinute = 900;

        Weapon currentWeapon = laser;
        currentWeapon.Shoot();

        currentWeapon = machineGun;
        currentWeapon.Shoot();
    }

    public class LaserGun : Weapon
    {
        public string LaserColor { get; set; }

        public override void Shoot()
        {
            Console.WriteLine($"Laser Pew Pew! Color: {LaserColor}, Damage: {Damage}");
        }
    }

    public class MachineGun : Weapon
    {
        public int RoundsPerMinute { get; set; }

        public override void Shoot()
        {
            Console.WriteLine($"Machine gun Trrrrrrr! RoundsPerMinute: {RoundsPerMinute}, Damage: {Damage}");
        }
    }

    public abstract class Weapon
    {
        public int Damage { get; set; }

        public abstract void Shoot();
    }
    

}

