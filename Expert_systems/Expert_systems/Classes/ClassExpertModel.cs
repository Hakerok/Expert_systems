using System.Collections.Generic;


namespace Expert_systems
{
    public class ClassExpertModel
    {
        public string Name;
        public string Rule;
        public string Parent;
        public double Weight;
        public double Value;
        public bool Obratimost;
        public List<ClassExpertModel> children = new List<ClassExpertModel>();
    }
}
