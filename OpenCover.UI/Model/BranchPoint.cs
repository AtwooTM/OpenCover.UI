//
// This source code is released under the MIT License; Please read license.md file for more details.
//
using System.Xml.Serialization;

namespace OpenCover.Framework.Model
{
    /// <summary>
    /// a branch point
    /// </summary>
    public class BranchPoint : InstrumentationPoint
    {
        /// <summary>
        /// A path that can be taken
        /// </summary>
        [XmlAttribute("path")]
        public int Path { get; set; }
    }
}