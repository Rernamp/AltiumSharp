
using OriginalCircuit.AltiumSharp.BasicTypes;
using System.Drawing;
using System.Xml;
using System.Xml.Linq;

namespace OriginalCircuit.AltiumSharp.Records {
    public class SchBlanket : SchRectangle {

        public override int Record => 225;
        public List<CoordPoint> Vertices { get; set; } = new List<CoordPoint>();
        public string UniqueId { get; set; }
        public int LineStyleExt { get; set; }
        public LineStyle LineStyle { get; internal set; }

        public SchBlanket() : base() {
        }

        public override void ImportFromParameters(ParameterCollection p) {
            if (p == null) throw new ArgumentNullException(nameof(p));

            base.ImportFromParameters(p);
            UniqueId = p["UniqueID"].AsStringOrDefault();
            Vertices = Enumerable.Range(1, p["LOCATIONCOUNT"].AsInt())
            .Select(i => new CoordPoint(
                Utils.DxpFracToCoord(p[$"X{i}"].AsIntOrDefault(), p[$"X{i}_FRAC"].AsIntOrDefault()),
                Utils.DxpFracToCoord(p[$"Y{i}"].AsIntOrDefault(), p[$"Y{i}_FRAC"].AsIntOrDefault())))
            .ToList();

            LineStyleExt = p["LineStyleExt"].AsIntOrDefault();
            LineStyle = p["LINESTYLE"].AsEnumOrDefault<LineStyle>();
        }

    }
}
