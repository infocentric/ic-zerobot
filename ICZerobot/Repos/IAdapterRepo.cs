using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICZerobot.Models;

namespace ICZerobot.Repos
{
    public interface IAdapterRepo<T>
    {
        T CreateTask(Task task);
    }
}
