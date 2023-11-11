using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTest
{
    public class UserData
    {
        public string Name_of_client { get; set; }
        public string Number_of_min { get; set; }
        public string Number_of_sec { get; set; }
        public double Number_of_words { get; set; }
        public string ENG_or_RUS_texts { get; set; }
    }
}
