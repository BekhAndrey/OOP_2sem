using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    interface ICalculator
    {
        void ClickNumber(object sender, EventArgs e);
        void TrigonometryOperation(object sender, EventArgs e);
        void SqrtOperation(object sender, EventArgs e);
        void Exponentiating(object sender, EventArgs e);
        void CleanBox(object sender, EventArgs e);
        void CleanEntryBox(object sender, EventArgs e);
        void GetResult(object sender, EventArgs e);
        void MemorySaveClick(object sender, EventArgs e);
        void MemoryReadClick(object sender, EventArgs e);
    }
}
