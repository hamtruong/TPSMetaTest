using System;
using TPSMetaTest.Components;

namespace TPSMetaTest.Data
{
    class Segment
    {
        public String Name { get; set; }
        public UInt16 Length { get; set; }
        public DataDefinition.SegType Type { get; set; }

        public Segment()
        {
            this.Name = "Data segment";
            this.Length = 1;
            this.Type = DataDefinition.SegType.ASCII;
        }

        /// <summary>
        /// Generate new label 
        /// </summary>
        /// <returns></returns>
        public SegmentLabel GetLabel()
        {
            SegmentLabel lbl = new SegmentLabel(this);
            return lbl;
        }
    }
}
