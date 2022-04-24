using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriCagriUygulamasi
{
    public class Ikuyruk : kuyruk
    {
        
        public CagriOzellikleri[] kuyruk;
        public CagriOzellikleri[] TamamlananCagrilar = new CagriOzellikleri[50];

        public int front = -1;
        public int rear = -1;
        public int BitenCagrilar = 0;
        public int size = 0;
        public int ToplamCagri = 0;
        
        private int count;
        public Ikuyruk(int count)
        {
            this.count = count;
            this.kuyruk = new CagriOzellikleri[count];
        }

        public override void ChangeFront(int CagriID)
        {
            if (this.isEmpty())
            {
                throw new Exception("Kuyruk boş");
            }

            int kontrol=0,a= 0;
            
            for (int i = this.front; i <= this.rear; i++)
            {
                if (kuyruk[i].CagriID == CagriID)
                {
                    CagriOzellikleri temp = kuyruk[i];
                    kuyruk[i] = kuyruk[front];
                    kuyruk[front] = temp;
                    a = i;
                    kontrol = 1;
                }
            }

            for (int j = a; this.front + 1 < j; j--)
            {
                CagriOzellikleri temp = kuyruk[j - 1];
                kuyruk[j - 1] = kuyruk[j];
                kuyruk[j] = temp;
            }

            if (kontrol == 0)
                throw new Exception("Böyle bir çağrı bulunamadı");

        }

        public override bool isEmpty()
        {
            return size == 0 ? true : false;
        }

        public override object peek()
        {
            if (this.isEmpty())
            {
                throw new Exception("Kuyruk boş");
            }

            CagriOzellikleri temp = kuyruk[front];
            return temp;

        }
        
        public override object pop()
        {
            if (this.isEmpty())
            {
                throw new Exception("Kuyruk boş");
            }
            CagriOzellikleri temp = kuyruk[front];
                   
            kuyruk[front] = null;
            size--;
            front++;
            TamamlananCagrilar[BitenCagrilar] = temp;
            this.BitenCagrilar++;
            return temp;

        }

        public override void push(CagriOzellikleri value)
        {

            if ((count == this.size) || (rear == count - 1))
            {
                throw new Exception("Kuyruk dolu");
            }

            if (front == -1)
            {
                front = 0;
            }

            kuyruk[++rear] = value;

            this.size++;
            this.ToplamCagri++;
        }
    }
}
