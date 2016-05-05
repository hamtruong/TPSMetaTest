using System.Collections.Generic;

namespace TPSMetaTest.Data
{
    class Protocol
    {
        public Protocol()
        {
            this.Name = string.Empty;
            this.ReqSegments = new List<Segment>();
            this.RepSegments = new List<Segment>();
        }

        public string Name { get; set; }
        public List<Segment> ReqSegments { get; set; }
        public List<Segment> RepSegments { get; set; }
    }
}
