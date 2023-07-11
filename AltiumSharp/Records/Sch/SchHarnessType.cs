
using OriginalCircuit.AltiumSharp.BasicTypes;
using System.Drawing;
using System.Xml;
using System.Xml.Linq;

namespace OriginalCircuit.AltiumSharp.Records {
    public class SchHarnessType : SchGraphicalObject {

        public override int Record => 217;
        public string UniqueId { get; set; }
        public bool OwnerIndexAdditionalList { get; set; }
        public int FontId { get; set; }
        public bool IsHidden { get; set; }
        public bool NotAutoPosition { get; set; }
        public string Text { get; set; }


        public SchHarnessType() : base() {
        }

        public override void ImportFromParameters(ParameterCollection p) {
            if (p == null) throw new ArgumentNullException(nameof(p));

            base.ImportFromParameters(p);
            UniqueId = p["UniqueID"].AsStringOrDefault();
            OwnerIndexAdditionalList = p["OwnerIndexAdditionalList"].AsBool();
            FontId = p["FONTID"].AsIntOrDefault();
            IsHidden = p["ISHIDDEN"].AsBool();
            Text = p["TEXT"].AsStringOrDefault();
            NotAutoPosition = p["NotAutoPosition"].AsBool();

        }

    }
}
