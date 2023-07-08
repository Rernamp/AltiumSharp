
using OriginalCircuit.AltiumSharp.BasicTypes;
using System.Drawing;
using System.Xml;

namespace OriginalCircuit.AltiumSharp.Records {
    public class SchBusEntry : SchLine {
        public override int Record => 37;
        public string UniqueId { get; set; }


        public SchBusEntry() : base() {
        }
        
        public override void ImportFromParameters(ParameterCollection p) {
            if (p == null) throw new ArgumentNullException(nameof(p));

            base.ImportFromParameters(p);
            UniqueId = p["UniqueID"].AsStringOrDefault();
        }

    }
}
