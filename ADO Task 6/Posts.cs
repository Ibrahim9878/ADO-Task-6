namespace ADO_Task_6;

public class Posts
{
    /*
     - Id int
		- Date datetime2 NOT NULL	default SYSDATETIME()
		- Text nvarcahar NULL
		- ImagePath nvarchar NOT NULL
	
     */
    public int Id{ get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public string? Text { get; set; }
    public string? ImagePath { get; set; }

    public IEnumerable<Tags> tags { get; set; } = [];

    public override string ToString()
    {
        return $@"{Text}";
    }
}