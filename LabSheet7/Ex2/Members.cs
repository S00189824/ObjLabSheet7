using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class Members
    {
        public static Random rng = new Random();

        public static string[] MemberType =  new string[] {"Student","Full","Junior"};

        public static string _Name { get; set; }

        public DateTime DateJoined { get; set; }

        public string membertype { get; set; }

        public static int numberofmembers;

        public Members(string name,string membertype,DateTime datejoined)
        {
            _Name = name;
            this.membertype = membertype;
            DateJoined = datejoined;

            numberofmembers++;
        }

       


        public override string ToString()
        {
            return $"{_Name} {membertype} {DateJoined.ToShortDateString()}";
        }
    }
}
