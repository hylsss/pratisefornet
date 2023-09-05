namespace ProjectIna;

public class UserInfoDoto
{
    public string Name { get; set; }
    public int Age { get; set; }
    public bool Sex { get; set; }

    public override string ToString()
    {
        return string.Join(",", this.GetType().GetProperties().Select(p => p.Name).ToArray());
    }
}