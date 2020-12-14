using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlaskPyBox.Score
{
    class ScoreClass
    {
        public string name { get; set; }
        public int score { get; set; }
        public ScoreClass(string Name, int Score)
        {
            this.name = Name;
            this.score = Score;
        }
        public ScoreClass()
        {
            this.name = "Unknow";
            this.score = 0;
        }
    }
}
