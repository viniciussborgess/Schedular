using Schedular.Domain.Data.Core;
using Schedular.Domain.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedular.Domain.Data.Repositories;

public interface IEventRepository 
{
    Event GetById(Guid id);
    List<Event> GetByDates(DateTime date);
    void Create(Event ev);
    Task<bool> SaveChangesAsync();
    List<Event> GetAll();
    void Delete(Event ev);
    void Update(Event ev);
}
