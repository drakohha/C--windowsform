using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace WF_GDI_lab01
{
    public class History
    {
        public Form1 fm;
        public List<Form1> items = new List<Form1>();
        public int Count = 0;
        public History(Form1 fm)
        {
            this.fm = fm;
        }

        public int currentIndex = 0;
        public bool CanUndo { get { return currentIndex >= 0; } }
        public bool CanRedo { get { return items.Count > 0 && currentIndex < items.Count - 1; } }

        public void Undo(Form1 fm)
        {
           // if (!CanUndo)
            //    return;
            //items[currentIndex].Undo(fm);
            this.currentIndex--;
            //Count++;
        }

        public void Redo(Form1 fm)
        {
            if (!CanRedo)
                return;
            this.currentIndex++;
            items[currentIndex].Redo(fm);
            Count++;
        }

        public void Add(Form1 item)
        {
            CutOffHistory();
            items.Add(item);
            this.currentIndex++;
        }

        void CutOffHistory()
        {
            int index = currentIndex + 1;
            if (index < Count)
                items.RemoveRange(index, Count - index);
        }

    }
}
