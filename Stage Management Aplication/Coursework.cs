using System;
using System . Xml . Serialization;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace Stage_Management_Aplication
{
    public class Coursework :Assessment
    {
        // holds a list with all the Coursework Components of a Module
        List<Component> components = new List<Component>();

        [XmlArray]
        public List<Component> Components
        {
            get { return components; }
            set { components = value; }
        }
    }
}
