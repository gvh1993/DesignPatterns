using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Patterns.Bridge.Abstractions;
using DesignPatterns.Patterns.Bridge.Views;

namespace DesignPatterns.Patterns.Bridge
{
    public class LongForm : View
    {
        public LongForm(IResource resource) : base(resource)
        {
        }

        public override void Show()
        {
            Console.WriteLine("show the long form!");
        }
    }
}
