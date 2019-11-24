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
        public object rule;
        private bool exit = false;

        public CaptureRulesTableAction(int stateCurrent, string valueCurrent, string[] states, string[] values)
        {
            InitializeComponent();
            label1.Text = "Estado " + stateCurrent + ", " + valueCurrent;

            cbxStates.Items.AddRange(states);
            cbxValue.Items.AddRange(values);
            cbxStates.SelectedIndex = 0;
            cbxValue.SelectedIndex = 0;
            cbxDirection.SelectedIndex = 0;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            rule = new Rule(int.Parse(cbxStates.Text), cbxValue.Text, cbxDirection.Text);
            Dispose();
        }

        public object getRule() => rule;

        public bool Exit() => exit;

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
            exit = true;
        }
    }
}
