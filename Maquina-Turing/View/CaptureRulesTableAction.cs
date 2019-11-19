using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maquina_Turing.View
{
    
    public partial class CaptureRulesTableAction : Form
    {
        private Rule rule;

        public CaptureRulesTableAction(int state, string value)
        {
            InitializeComponent();
            label1.Text = "Estado " + state + ", " + value;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            rule = new Rule(int.Parse(cbxStates.Text), cbxValue.Text, cbxDirection.Text);
        }

        public Rule GetRule
        {
            get
            {
                return rule;
            }
            set
            {
                rule = value;
            }
        }

    }
}
