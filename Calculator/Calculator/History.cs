using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Calculator
{
    public class History
    {
        public string Text { get; set; }

        public History(string Text)
        {
            this.Text = Text;
        }

        public override string ToString() => Text;
    }
}
