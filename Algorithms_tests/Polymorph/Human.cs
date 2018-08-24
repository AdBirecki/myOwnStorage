using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using static System.Console;

namespace Polymorph
{
    public class Human : Mamal
    {
        public Human(CultureInfo cultureInfo, int age, string name) : this(age, name) {
            Language = cultureInfo;
        }

        public Human(int age, string name) : base(age, name)
        {
        }

        public virtual CultureInfo Language
        { get; set; }

        public override void Introduce()
        {
            WriteLine($"This is Human ");    
        }

        public virtual void HumanSpeaks() {
            WriteLine($"Human Speaks");
        }
    }
}
