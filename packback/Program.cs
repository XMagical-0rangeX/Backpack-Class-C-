// TASK 2
Backpack backpack1 = new Backpack("blue", "small");
Backpack backpack2 = new Backpack("red", "medium");
Backpack backpack3 = new Backpack("green", "large");


// TASK 3
backpack1.openBag();
backpack1.putin("lunch");
backpack1.putin("jacket");
backpack1.closeBag();
backpack1.openBag();
backpack1.takeout("jacket");
backpack1.closeBag();


// TASK 1
class Backpack
{
    // Declare Properties (State)
    public string Color { get; set; }
    public string Size { get; set; }
    public string[] Items { get; set; }
    public bool Open { get; set; }


    // Constructor
    public Backpack(string color, string size)
    {
        this.Color = color;
        this.Size = size;
        this.Items = new string[3];
        for (int i = 0; i < 3; i++)
        {
            Items[i] = "";
        }
        this.Open = false;
    }


    // Methods (Behaviour)
    public void openBag()
    {
        this.Open = true;
        Console.WriteLine("Backpack opened");
    }
    public void closeBag()
    {
        this.Open = false;
        Console.WriteLine("Backpack closed");
    }


    public void putin(string item)
    {
        if (this.Open == true)
        {
            for (int i = 0; i < Items.Length; i++)
            {
                if (Items[i] == "")
                {
                    this.Items[i] = (item);
                    Console.WriteLine($"Put in {item} into backpack");
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Failed");
        }

    }


    public void takeout(string item)
    {
        if (this.Open == true)
        {
            for (int i = 0; i < Items.Length; i++)
            {
                if (item == Items[i])
                {
                    Items[i] = "";
                    Console.WriteLine($"Removed {item} from backpack");
                }
            }
        }
        else
        {
            Console.WriteLine("Failed");
        }
    }


}
