using System;
using System . Xml . Serialization;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace Stage_Management_Aplication
{
   public class Assessment
    {
        private decimal mark; //the exam's mark, range 0 - 100
        private decimal weighting; //the exam's weighting, range 0.0 - 1.0

        [XmlAttribute]
        public decimal Mark
        {
            get { return mark; }
            set
            {
                if ( value >= 0 && value <= 100 )
                    mark = value;
            }
        }//

        [XmlAttribute]
        public decimal Weighting
        {
            get { return weighting; }
            set
            {
                if ( value > 0 && value <= 100 )
                    weighting = value;
            }
        }//
    }
}
