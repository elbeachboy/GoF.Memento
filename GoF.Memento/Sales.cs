using System;
using System.Collections.Generic;
using System.Text;

namespace GoF.Memento
{
    public class Sales
    {
        private Memento _memento;
        

        public Memento Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }
}
