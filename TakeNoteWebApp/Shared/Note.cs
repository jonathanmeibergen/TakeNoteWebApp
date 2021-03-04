using System;

namespace TakeNote.Models
{
    /// <summary>
    /// Most basic form of a study unit
    /// </summary>
    public class Note
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public Item Message { get; set; }
    }
}
