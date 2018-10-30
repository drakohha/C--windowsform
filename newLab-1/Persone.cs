using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drakohha_01
{
    [Serializable]
    public class Persone
    {
        public Persone()
        { }

        public Persone(string name,string type, int age)
        {
            Name_persone = name;
            WorkeType_persone = type;
            Age_persone = age;
        }

        public string Name_persone { get; set; }
        public string WorkeType_persone { get; set; }

        public int Age_persone { get; set; }


    }
}
