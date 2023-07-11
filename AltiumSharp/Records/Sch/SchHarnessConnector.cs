
using OriginalCircuit.AltiumSharp.BasicTypes;
using System.Drawing;
using System.Xml;

namespace OriginalCircuit.AltiumSharp.Records {
    public enum Rotation : byte {
        degrees0 = 0,
        degrees90,
        degrees180,
        degrees270
    }
    public class SchHarnessConnector : SchGraphicalObject {
        
        public override int Record => 215;
        public string UniqueId { get; set; }
        public Size Size { get; set; }
        public int PrimaryConnectionPosition { get; set; }
        public LineWidth LineWidth { get; set; }
        public Rotation Rotation { get; set; }


        public SchHarnessConnector() : base() {
        }

        public override void ImportFromParameters(ParameterCollection p) {
            if (p == null) throw new ArgumentNullException(nameof(p));

            base.ImportFromParameters(p);
            UniqueId = p["UniqueID"].AsStringOrDefault();
            Size = new Size(p["XSize"].AsIntOrDefault(), p["YSize"].AsIntOrDefault());
            LineWidth = p["LINEWIDTH"].AsEnumOrDefault<LineWidth>();
            PrimaryConnectionPosition = p["PrimaryConnectionPosition"].AsIntOrDefault();
            Rotation = p["HarnessConnectorSide"].AsEnumOrDefault<Rotation>();
        }

    }
}
