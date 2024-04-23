using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask26.Task1
{
    internal class RussianLanguage : ILanguage
    {
        public void Speak()
        {
            Console.WriteLine("Привет! Как дела?");
        }
    }
}
