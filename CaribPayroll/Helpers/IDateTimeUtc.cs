using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Helpers
{
    public interface IDateTimeUtc
    {
        DateTimeOffset Now { get; }
    }
}
