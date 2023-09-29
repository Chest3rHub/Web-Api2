namespace REST_API.Models;

public class Study
{
    string Type;
    string Mode;

    public Study(string Type, string Mode)
    {
        this.Type = Type;
        this.Mode = Mode;
    }

    public string type
    {
        get
        {
            return this.Type;
        }

    }

    public string mode
    {
        get
        {
            return this.Mode;
        }

    }
}