using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotesApi
{
    public class Release
    {
        public string Name { get; set; }

        public /*List<string>*/ string News { get; set; }

        public /*List<string>*/ string Bugs { get; set; }
    }
}