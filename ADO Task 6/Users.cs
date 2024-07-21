namespace ADO_Task_6;

public class Users
{
    public int Id { get; set; }
    public string Login { get; set; }
    public string Pswd { get; set; }
    public bool IsOpen { get; set; } = true;
    public bool Gender { get; set; } = true;
    public DateTime Birthday { get; set; }
    public IEnumerable<Posts> posts { get; set; } = [];
    public override string ToString()
    {
        return @$"{Login} {Pswd}";
    }
}
