using Schedular.Domain.Data.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedular.Domain.Data.Models;
public class Event : Entity<Guid>
{
    public Event(string name, string description, DateTime dateEvent)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        DateEvent = dateEvent;
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DateEvent { get; set; }

    public void Update(string name, string description, DateTime dateEvent)
    {
        Name = name;
        Description = description;
        DateEvent = dateEvent;
    }
}
