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
    Event GetByName(DateTime date);
    void Create(Event act);
    Task<bool> SaveChangesAsync();
    List<Event> GetAll();
    void Delete(Event act);
    void Update(Event act);
}
