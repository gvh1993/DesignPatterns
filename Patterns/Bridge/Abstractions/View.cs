using DesignPatterns.Patterns.Bridge.Abstractions;

namespace DesignPatterns.Patterns.Bridge.Views
{
    public abstract class View
    {
        public IResource Resource { get; }

        public View(IResource resource){
            Resource = resource;
        }

        public abstract void Show();
    }
}