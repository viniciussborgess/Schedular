namespace Schedular.API.Application.Models.ViewModels;

public class EventViewModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DateEvent { get; set; }
}
