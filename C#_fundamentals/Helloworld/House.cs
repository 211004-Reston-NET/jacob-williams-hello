namespace HouseFunction

{
public class House  
    {
        //private will make this field belong to just this C# code and nowhere else
    private string owner;
    private string ghost;
    private int roomCount;

    public House()
    {
        owner = "Stephen";
        ghost = "Casper";
        roomCount = 1;
    }
    public string Owner { get{return owner;} set{owner = value;} }
    
    public string MiceName { get; set; }
    }
}