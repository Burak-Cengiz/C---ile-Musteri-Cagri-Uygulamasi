using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriCagriUygulamasi
{
    public abstract class kuyruk
    {
        public abstract bool isEmpty();
        public abstract void push(CagriOzellikleri value);
        public abstract object pop();
        public abstract void ChangeFront(int CagriID);
        public abstract object peek();
    }
}
