using System;
using System.Collections.Generic;
using System.Text;

namespace EFSamurai.Domain
{
    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sword { get; set; }
        public HairStyles HairStyle { get; set; }
        public SecretIdentity SecretIdentity { get; set; }
        public virtual ICollection<Quote> Quotes { get; set; }
        public virtual ICollection<SamuraiBattles> SamuraiBattles { get; set; }

    }

    public enum HairStyles
    {
        Chonmage,
        Oicho,
        Western
    }

}
