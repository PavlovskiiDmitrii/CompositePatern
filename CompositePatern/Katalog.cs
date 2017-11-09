using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatern
{
    public  class Katalog : Component
    {
        ArrayList arrayList = new ArrayList();
        public int weight { get; set; }

        public Katalog(string name)
            : base(name)
        {

        }

        public override void SetWeight()
        {

            foreach (Component component in arrayList)
            {
                weight = weight + component.GetWeight();
            }
        }
        public override void Add(Component component)
        {
            arrayList.Add(component);
        }


        public override void Remove(Component component)
        {
            arrayList.Remove(component);
        }

        public override int GetWeight()
        {
            SetWeight();
            int nowWeight = weight;
            weight = 0;
            return nowWeight;

        }
    }
}
