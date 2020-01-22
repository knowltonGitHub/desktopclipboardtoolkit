using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopClipboardToolkit
{
    interface ISupportsEvents
    {
        CustomEvents ce
        {
            get;
            set;
        }
    }
}
