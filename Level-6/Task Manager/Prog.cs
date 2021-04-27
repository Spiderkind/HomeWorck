using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Level_6
{
    [Serializable]
    class Prog
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Prog()
        {


        }
        public Prog(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
