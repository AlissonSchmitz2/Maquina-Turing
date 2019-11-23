using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maquina_Turing
{
    class Rule
    {
        private int state;
        private string valuee;
        private string direction;

        public Rule(int state, string valuee, string direction)
        {
            this.state = state;
            this.valuee = valuee;
            this.direction = direction;
        }

        public int State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        public string Valuee
        {
            get
            {
                return valuee;
            }
            set
            {
                valuee = value;
            }
        }

        public string Direction
        {
            get
            {
                return direction;
            }
            set
            {
                direction = value;
            }
        }

        public string formatRule() => state + ";" + valuee + ";" + direction;

    }
}
