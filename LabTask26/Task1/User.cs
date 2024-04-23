using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask26.Task1
{
    internal class User
    {
        readonly ILanguage _language;

        public User(ILanguage language)
        {
            this._language = language;
        }

        public void Speak()
        {
            _language.Speak();
        }
    }
}
