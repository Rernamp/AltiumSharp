
using OriginalCircuit.AltiumSharp.BasicTypes;
using System.Drawing;
using System.Xml;
using System.Xml.Linq;

namespace OriginalCircuit.AltiumSharp.Records {
    public class SchSignalHarness : SchBus {

        public override int Record => 218;

        public SchSignalHarness() : base() {
        }

        public override void ImportFromParameters(ParameterCollection p) {
            if (p == null) throw new ArgumentNullException(nameof(p));

            base.ImportFromParameters(p);
            UniqueId = p["UniqueID"].AsStringOrDefault();
        }

    }
}
