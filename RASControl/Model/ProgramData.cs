using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using RASControl.Model.RAS;

namespace RASControl.Model
{
    [XmlRoot("program")]
    public class ProgramData
    {
        public ProgramData()
        {
            Connections = new List<Connection>();
            Logs = new List<ConnectionLog>();

            OpenConnectionWidgetAutomatically = true;
        }

        [XmlElement("connection")]
        public List<Connection> Connections { get; set; }

        [XmlElement("log")]
        public List<ConnectionLog> Logs { get; set; } 

        [XmlAttribute("autostart")]
        public bool AutoStart { get; set; }

        [XmlAttribute("startminimized")]
        public bool StartMinimized { get; set; }

        [XmlAttribute("openconnectionwidget")]
        public bool OpenConnectionWidgetAutomatically { get; set; }

        public static string DefaultFileName = "program.xml";

        public static ProgramData Current { get; protected set; }
        public static ProgramData Load()
        {
            //If the file doesn't exists create a default one
            if (!File.Exists(DefaultFileName))
            {
                Current = new ProgramData() {  };
                return Current;
            }

            //If the file exists load it from file and return it
            var x = new XmlSerializer(typeof(ProgramData));
            var fs = new FileStream(DefaultFileName, FileMode.Open);
            Current = x.Deserialize(fs) as ProgramData;
            fs.Close();
            return Current;
        }

        public void Save()
        {
            var x = new XmlSerializer(typeof(ProgramData));
            var fs = new FileStream(DefaultFileName, FileMode.Create);
            x.Serialize(fs, Current);
            fs.Close();
        }
    }
}
