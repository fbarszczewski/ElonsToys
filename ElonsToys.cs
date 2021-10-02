using System;

class RemoteControlCar
{
    private static int _id =0;

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public int Battery { get; set; }

    public int Distance { get; set; }

    public RemoteControlCar()
    {
        Id= System.Threading.Interlocked.Increment(ref _id);
        Battery = 100;
        Distance = 0;
    }


    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {Distance} meters";
    }

    public string BatteryDisplay()
    {
        if (Battery > 0)
            return $"Battery at {Battery}%";
        else
            return $"Battery empty";
    }

    public void Drive()
    {
        if (Battery <= 0) return;
        Distance += 20;
        Battery -= 1;
    }
}
