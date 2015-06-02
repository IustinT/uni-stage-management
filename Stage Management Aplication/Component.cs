using System;
using System . Xml . Serialization;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace Stage_Management_Aplication
{
    [Serializable]
    public class Component : Assessment
    {
        private string type;

        [XmlAttribute]
        public string Type
        {
            get { return type; }
            set
            {
                value = value . ToLower();
                if ( Validate_Type( value ) )
                    type = value;
            }
        }//


        [XmlAttribute]
        public String Name
        {
            get;
            set;
        }

        private Boolean Validate_Type( string value )
        {
            string[] types = { "presentation", "in-class test", "exercise", "essay", "software development" };

            foreach ( string item in types )
            {
                if ( value == item )
                    return true;
            }

            return false;
        } //End Validate_Type()

    }
}
