using System;
using System.Collections.Generic;
using System.Text;

namespace EFSamurai.Domain
{
    public class Quote
    {
        private int length = 0;
        public int Id { get; set; }
        public string Text { get; set; }
        public int QuateLength { get => Text.Length; set => length = value; }
        public QuoteTypes QuoteType { get; set; }
        public int SamuraiId { get; set; }
        public virtual Samurai Samurai { get; set; }
    }

    public enum QuoteTypes
    {
        Lame,
        Cheesy,
        Awesome
    }
}
