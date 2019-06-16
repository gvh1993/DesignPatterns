using DesignPatterns.Patterns.Bridge.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Bridge.Resources
{
    public class Artist : IResource
    {
        public string Snippet { get; set; }
        public byte[] image { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
