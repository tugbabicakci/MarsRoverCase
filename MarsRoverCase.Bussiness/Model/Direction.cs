using MarsRoverCase.Bussiness.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverCase.Bussiness
{
    public class Direction 
    {
        public string[] Str_dir = { "N", "E", "S", "W" };
        public string Location { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string Dir { get; set; }
        public int RowMax { get; set; }
        public int ColMax { get; set; }
    }
}
