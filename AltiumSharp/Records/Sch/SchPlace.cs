
using OriginalCircuit.AltiumSharp.BasicTypes;
using System.Drawing;
using System.Xml;

namespace OriginalCircuit.AltiumSharp.Records {
    public class SchPlace : SchPrimitive {
        public override int Record => 43;
        public string Name { get; set; }
        public string UniqueId { get; set; }

        public CoordPoint Location { get; set; }
        public Color Color { get; set; }
        public TextOrientations Orientation { get; set; }

        public SchPlace() {
        }


        public override void ImportFromParameters(ParameterCollection p) {
            if (p == null) throw new ArgumentNullException(nameof(p));

            if (p == null) throw new ArgumentNullException(nameof(p));

            base.ImportFromParameters(p);
            Location = new CoordPoint(
                Utils.DxpFracToCoord(p["LOCATION.X"].AsIntOrDefault(), p["LOCATION.X_FRAC"].AsIntOrDefault()),
                Utils.DxpFracToCoord(p["LOCATION.Y"].AsIntOrDefault(), p["LOCATION.Y_FRAC"].AsIntOrDefault()));
            Color = p["COLOR"].AsColorOrDefault();
            UniqueId = p["UNIQUEID"].AsStringOrDefault();
            Name = p["TEXT"].AsStringOrDefault();
            Orientation = p["ORIENTATION"].AsEnumOrDefault<TextOrientations>();
        }

    }
}
