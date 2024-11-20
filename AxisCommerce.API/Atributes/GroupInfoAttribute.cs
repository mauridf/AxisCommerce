namespace AxisCommerce.API.Atributes;

public class GroupInfoAttribute : Attribute
{ 
    public string Title { get; set; }
    public string Version { get; set; }
    public string Description { get; set; }
}
