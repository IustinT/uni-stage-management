using System;
using System . Xml . Serialization;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace Stage_Management_Aplication
{
    public class Stage
    {
        private int number; // holds the stage number, range 1 - 4
        private double overallStageMark; //the overall mark of the stage, range 0 - 100
        private List<Module> modules = new List<Module>(); // holds all the modules of a stage


        [XmlAttribute]
        public int Number
        {
            get { return number; }
            set
            {
                if ( value >= 1 && value <= 4 )
                    number = value;
            }
        }
        
        [XmlIgnore]
        public Double OverallStageMark
        {
            get { return overallStageMark; }
            set
            {
                if ( value >= 0 && value <= 100 )
                    overallStageMark = value;
            }
        }//

        [XmlArray]
        public List<Module> Modules
        {
            get { return modules; }
            set { modules = value; }
        }

        [XmlAttribute]
        public String ProgrameName
        {
            get;
            set;
        }
    }
}
