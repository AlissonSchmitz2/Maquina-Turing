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
    public partial class RunMachineTuring : Form
    {
        private char[] entry;
        private Rule[,] matrixRules;
        private string[] arrayValues;
        private int amountStates;
        private int amountValues;
        private int currentState = 0;
        private int currentPosition = 0;
        private int j = 0;
        private char currentValue;
        private string labelHead;
        private string labelState;

        public RunMachineTuring(string entry, object matrixRules, string[] arrayValues, int amountStates)
        {
            InitializeComponent();
            this.entry = entry.ToCharArray();
            this.matrixRules = (Rule[,])matrixRules;
            this.arrayValues = arrayValues;
            this.amountStates = amountStates - 1;
            amountValues = arrayValues.Length;

            lblEntry.Text = entry;

            timerRun.Start();
        }

        private void TimerRun(object sender, EventArgs e)
        {
            Rule rule;
            try
            {
                currentValue = entry[currentPosition];
            }
            catch (IndexOutOfRangeException)
            {
                timerRun.Stop();
                MessageBox.Show("Entrada inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            j = Array.IndexOf(arrayValues, currentValue.ToString());
            rule = matrixRules[currentState, j];
            if (j != -1 && rule != null)
            {
                currentState = rule.State;
                
                entry[currentPosition] = char.Parse(rule.Valuee);
                switch (rule.Direction)
                {
                    case "Direita":
                        currentPosition++;
                        break;
                    case "Esquerda":
                        currentPosition--;
                        break;
                    case "Para":
                        timerRun.Stop();
                        MessageBox.Show("Finalizado, resultado: " + new String(entry), "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                }

                for (int i=0; i<entry.Length; i++)
                {
                    if (i != currentPosition)
                    {
                        
                        labelState += "  ";
                        labelHead += "  ";
                    }
                    else
                    {
                        labelState += currentState.ToString();
                        labelHead += "|";
                    }
                }
                lblState.Text = labelState;
                lblHead.Text = labelHead;
                lblIncrement.Text += currentState.ToString();
                lblEntry.Text = new String(entry);
                labelHead = "";
                labelState = "";
            }
            else
            {
                timerRun.Stop();
                MessageBox.Show("Entrada inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
