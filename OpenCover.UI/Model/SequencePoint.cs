﻿//
// This source code is released under the MIT License; Please read license.md file for more details.
//

using System.Xml.Serialization;

namespace OpenCover.Framework.Model
{
    /// <summary>
    /// a sequence point
    /// </summary>
    public class SequencePoint : InstrumentationPoint
    {        
        [XmlAttribute("sl")]
        public int StartLine { get; set; }
        
        [XmlAttribute("sc")]
        public int StartColumn { get; set; }
        
        [XmlAttribute("el")]
        public int EndLine { get; set; }
        
        [XmlAttribute("ec")]
        public int EndColumn { get; set; }
    }
}
