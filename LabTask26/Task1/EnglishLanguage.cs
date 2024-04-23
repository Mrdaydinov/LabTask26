using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask26.Task1
{
    internal class EnglishLanguage : ILanguage
    {
        public void Speak()
        {
            Console.WriteLine("Hello! How are you?");
        }
    }
}
