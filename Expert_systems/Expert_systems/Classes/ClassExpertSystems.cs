using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Expert_systems
{
    public class ClassExpertSystems
    {
       

        public class Expert
        {
            public string Name;
            public string Rule;
            public string Parent;
            public double Value;
            public bool Reversibility;
            public List<Expert> Children = new List<Expert>();
        }

    }
}
