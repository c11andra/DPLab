using System;
using System.Collections.Generic;

namespace DPLab.FactoryMethod
{         
    public abstract class MobilePhone
    {
        private List<Feature> features = new List<Feature>();
        public MobilePhone()
        {
            this.CreateFeature();
        }

        public List<Feature> Features { get => features;  }

        protected abstract void CreateFeature();
    }
}
