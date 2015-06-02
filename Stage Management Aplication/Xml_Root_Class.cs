using System;
using System . Xml . Serialization;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace Stage_Management_Aplication
{
    [XmlRoot]
    public class Xml_Root_Class
    {
        /// <summary>
        /// The class is used to create the XML root node and it encloses all the stages with their nodes
        /// </summary>


        private List<Stage> stages = new List<Stage>(); //a list that holds all the stages

        [XmlArray]
        public List<Stage> Stages
        {
            get { return stages; }
            set { stages = value; }
        }
    }
}
