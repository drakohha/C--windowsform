using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace WF_GDI_lab01
{
    public abstract class HistoryItem
    {
        public abstract void Undo(XDocument document);
        public abstract void Redo(XDocument document);
    }
}
