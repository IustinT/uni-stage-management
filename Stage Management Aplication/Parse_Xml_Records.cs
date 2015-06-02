using System;
using System . Xml;
using System . Xml . Serialization;
using System . Xml . Linq;
using System . IO;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;
using System . Windows . Forms;

namespace Stage_Management_Aplication
{
    /// <summary>
    /// Handles the XML files
    /// </summary>
    class Parse_Xml_Records
    {
        /// <summary>
        /// Verifies if a file exists and if it is a valid XML file
        /// </summary>
        /// <param name="fileName">The file's name</param>
        /// <returns>Returns True if the file is valid</returns>
        public Boolean CheckFile( string fileName )
        {
            XDocument recordsFile;

            if ( File . Exists( fileName ) )
            {
                try
                {
                    recordsFile = XDocument . Load( fileName );

                    if ( ( recordsFile . Root . Name . ToString() . ToLower() == "xml_root_class" ) )
                        return true;
                }
                catch ( XmlException e )
                {
                    MessageBox . Show( "The XML file is not valid" );
                }
            }
            return false;

        }// End CheckFile()


        /// <summary>
        /// Parses the XML file and returns the root element
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        /// 
        public Xml_Root_Class DeserialiseXmlRoot( string filename )
        {
            Xml_Root_Class xmlRoot = null;
            try
            {
                // Construct an instance of the XmlSerializer with the type
                // of Stage.
                XmlSerializer xmlSerializer = new XmlSerializer( typeof( Xml_Root_Class ) );

                using ( FileStream fileStream = new FileStream( filename, FileMode . Open ) )

                    // Call the Deserialize method and cast to the object type Stage.
                    xmlRoot = (Xml_Root_Class) xmlSerializer . Deserialize( fileStream );
            }
            catch ( XmlException e )
            {
                MessageBox . Show( "An error occurred when reading the XML file" );
            }

            if ( xmlRoot == null )
                return null;

            return xmlRoot;
        }


        /// <summary>
        /// Writes the record to the XML file
        /// </summary>
        /// <param name="xmlRoot">The root element to be written to the XML file</param>
        /// <param name="filename">The file where to write the records</param>
        /// 
        public void SerializeXmlRoot( Xml_Root_Class xmlRoot, string filename )
        {
            try
            {
                XmlSerializer serializer =  new XmlSerializer( typeof( Xml_Root_Class ) );

                using ( TextWriter writer = new StreamWriter( filename ) )

                    // Serialize the object, and close the TextWriter.
                    serializer . Serialize( writer, xmlRoot );
            }
            catch ( XmlException e )
            {
                MessageBox . Show( "An error occurred when writing the XML file" );
            }
        }
    }
}
