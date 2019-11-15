using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class Members
    {
        public static string[] MemberType =  new string[] {"Student","Full","Junior"};

        public string _Name { get; set; }

        public DateTime DateJoined { get; set; }




        public override string ToString()
        {
            return $"{_Name} {MemberType} {DateJoined.ToShortDateString()}";
        }
    }
}
