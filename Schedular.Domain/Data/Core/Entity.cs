using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedular.Domain.Data.Core;

public class Entity<TKey>
{
    public TKey Id { get; set; }
}
