using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RASControl.Model.RAS
{
    public class ConnectionLog
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("phone")]
        public string Phone { get; set; }

        [XmlAttribute("start")]
        public DateTime Start { get; set; }

        [XmlAttribute("end")]
        public DateTime End { get; set; }
    }
}
