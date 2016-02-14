using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymrr.Boundary
{
    public struct Task
    {
        readonly public bool Active;

        public Task(bool activate)
        {
            Active = activate;
        }
    }
}
