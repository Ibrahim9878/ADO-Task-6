namespace ADO_Task_6;

public class Tags
{
    public int Id { get; set; }
    public string Tag { get; set; }
    public IEnumerable<Posts> posts { get; set; } = [];

}