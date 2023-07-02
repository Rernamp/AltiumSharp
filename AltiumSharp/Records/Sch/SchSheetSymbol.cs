
using OriginalCircuit.AltiumSharp.BasicTypes;
using System.Drawing;
using System.Xml;

namespace OriginalCircuit.AltiumSharp.Records { 
    public class SchSheetSymbol : SchGraphicalObject {
        public override int Record => 15;
        public bool IsSolid { get; set; }
        public Size Size { get; set; }
        public string UniqueId { get; set; }

        public override void ImportFromParameters(ParameterCollection p) {
            if (p == null) throw new ArgumentNullException(nameof(p));

            base.ImportFromParameters(p);
            Size = new Size(p["XSize"].AsIntOrDefault(), p["YSize"].AsIntOrDefault());
            IsSolid = p["ISSOLID"].AsBool();
            UniqueId = p["UNIQUEID"].AsStringOrDefault();
        }

    } 
}
