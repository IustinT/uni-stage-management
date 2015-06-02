using System;
using System . Xml . Serialization;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace Stage_Management_Aplication
{
    [Serializable]
    public class Module
    {
        private int credits; //the credits of  a module, 0 or 10 or 20
        private string term; //holds the module term, AY, T1 or T2
        private double overallModuleMark; //the module's overall Mark, range 0 - 100

        private Summative_Assessment assessment = new Summative_Assessment();

        [XmlAttribute]
        public String Code
        {
            get;
            set;
        }
        
        [XmlAttribute]
        public String Name
        {
            get;
            set;
        }

        [XmlAttribute]
        public int Credits
        {
            get { return credits; }
            set
            {
                if ( value == 0 || value == 10 || value == 20 )
                    credits = value;
            }
        }//

        [XmlAttribute]
        public String Term
        {
            get { return term; }
            set
            {
                if ( value == "T1" || value == "T2" || value == "AY" )
                    term = value;
            }
        }//

        [XmlAttribute]
        public Double OverallModuleMark
        {
            get { return overallModuleMark; }
            set
            {
                if ( value >= 0 && value <= 100 )
                    overallModuleMark = value;
            }
        }//

        [XmlElement]
        public Summative_Assessment Assessment
        {
            get { return assessment; }
            set { assessment = value; }
        }

    }
}
