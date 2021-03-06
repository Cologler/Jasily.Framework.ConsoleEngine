using System;

namespace Jasily.Framework.ConsoleEngine.Attributes
{
    public abstract class NameAttribute : Attribute
    {
        public string Name { get; set; }

        protected NameAttribute(string name)
        {
            this.Name = name;
        }

        public bool IgnoreCase { get; set; } = true;
    }
}