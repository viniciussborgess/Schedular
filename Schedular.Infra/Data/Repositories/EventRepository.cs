using Microsoft.EntityFrameworkCore;
using Schedular.Domain.Data.Models;
using Schedular.Domain.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedular.Infrastrucrure.Data.Repositories;

public class EventRepository : IEventRepository
{
    private readonly ApplicationDataContext _context;
    protected DbSet<Event> _events;

    public EventRepository(ApplicationDataContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _events = _context.Set<Event>();
        
    }
    public async Task<bool> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }
    public void Create(Event ev)
    {
        _events.Add(ev);
    }
    public Event GetById(Guid id)
    {
        return _events.Find(id);
    }
    public List<Event> GetByDates(DateTime date)
    {
        return _events.Where(e => e.DateEvent.Date == date.Date).ToList();
    }

    public void Delete(Event ev)
    {
         _events.Remove(ev);
    }

    public List<Event> GetAll()
    {
        return _events.ToList();
    }

    public void Update(Event ev)
    {
        _events.Update(ev);
    }
}
