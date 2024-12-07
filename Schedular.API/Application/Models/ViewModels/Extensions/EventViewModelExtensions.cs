using Schedular.Infrastrucrure.DTOs;

namespace Schedular.API.Application.Models.ViewModels.Extensions;

public static class EventViewModelExtensions
{
    public static EventViewModel ToViewModel(this EventDTO dto)
    {
        return new EventViewModel
        {
            Id = dto.Id,
            Name = dto.Name,
            Description = dto.Description,
            DateEvent = dto.DateEvent
        };
    }
}
