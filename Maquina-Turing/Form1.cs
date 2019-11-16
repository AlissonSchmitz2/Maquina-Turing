using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Maquina_Turing
{
    public partial class Form1 : Form
    {

        private int amountValues;
        private int amountStates;
        private String[] arrayStates;
        private String[] arrayValues = null;
        private char[] entry;
        private Rule[][] matrixRules;
        private String x;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (captureValues())
            {
                btnConfirm.Enabled = false;
            }
            else
            {
                btnConfirm.Enabled = true;
            }

            /*
            if (capturarRegras())
            {
                JButtonIniciar.setEnabled(true);
                listarTabela(estados, valores);
            }*/
        }

        private bool captureValues()
        {
            if (string.IsNullOrEmpty(txtStates.Text) || !isNumber(txtStates.Text))
            {
                MessageBox.Show("Quantidade de estados inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } 

            try
            {
                amountValues = int.Parse(txtValues.Text);
            } catch (Exception e)
            {
                MessageBox.Show("Quantidade de valores inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            arrayValues = new String[amountValues];
            for (int i = 0; i < amountValues; i++)
            {
                x = Interaction.InputBox("Valor de " + i + ":", "Valores de ");
                /*while (x == null || x.isEmpty() || x.length() > 1 || verificarValor(x))
                {
                    if (x == null || x.isEmpty() || x.length() > 1)
                    {
                        JOptionPane.showMessageDialog(null, "Digite um valor vÃ¡lido", "Erro", JOptionPane.ERROR_MESSAGE);
                        x = JOptionPane.showInputDialog("VALOR  " + i + ":");
                    }
                    else
                    {
                        JOptionPane.showMessageDialog(null, "Valor jÃ¡ existente", "Erro", JOptionPane.ERROR_MESSAGE);
                        x = JOptionPane.showInputDialog("VALOR " + i + ":");
                    }
                }*/
                arrayValues[i] = x;
            }


            return true;
        }

        private bool isNumber(string value)
        {
            char[] datachars = value.ToCharArray();

            foreach (var datachar in datachars)
            {
                if (char.IsDigit(datachar))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
