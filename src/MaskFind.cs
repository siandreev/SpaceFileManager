using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Version1
{
    interface IMaskFind
    {
        void Finder(string mask, CancellationToken tokenF, IProgress<int> progress);
    }
}
