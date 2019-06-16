using DesignPatterns.Patterns.Bridge.Abstractions;
using System;

namespace DesignPatterns.Patterns.Bridge.Views
{
    public class ShortForm : View
    {
        public ShortForm(Resource resource) : base(resource)
        {
        }

        public override void Show()
        {
            Console.WriteLine("Show short form!");
        }
    }
}
