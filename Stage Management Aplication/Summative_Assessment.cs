using System;
using System . Xml . Serialization;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace Stage_Management_Aplication
{
    [Serializable]
    public class Summative_Assessment
    {
        /// <summary>
        /// Holds the Summative Assessment of a Module
        /// it also helps organising the data inside the XML file
        /// </summary>


        [XmlElement]
        public Exam Exam { get; set; }

        [XmlElement]
        public Coursework Coursework { get; set; }

        public Summative_Assessment()
        {
            Coursework = new Coursework();
            Exam = new Exam();
        }
    }
}
