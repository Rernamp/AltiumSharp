using OriginalCircuit.AltiumSharp.BasicTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OriginalCircuit.AltiumSharp.Records {
    public class SchSheetEntry : SchPrimitive {
        public int DistanceFromTop { get; set; }

        public override void ImportFromParameters(ParameterCollection p) {
            this.ImportFromParameters(p);
            DistanceFromTop = p["DistanceFromTop"].AsIntOrDefault();

        }
    }
}
