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
    public partial class MachineTuring : Form
    {

        private int amountValues;
        private int amountStates;
        private String[] arrayStates;
        private String[] arrayValues = null;
        private char[] entry;
        private Rule[][] matrixRules;
        private String aux;

        public MachineTuring()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (captureValues())
            {

                dataGridStates.Columns.Add("states", "Estados");
                for (int i = 0; i < amountStates; i++)
                {
                    dataGridStates.Rows.Add(i.ToString());
                }

                for (int i = 0; i < arrayValues.Length; i++)
                {
                    dataGridValues.Columns.Add(i.ToString(), arrayValues[i]);
                }

                btnConfirm.Enabled = false;
            }
            else
            {
                btnConfirm.Enabled = true;
            }

            
            if (captureRules())
            {
                
                //TODO: hanilitar botao iniciar 
                //listarTabela(estados, valores);
            }

            /*
            for (int i=0; i< amountStates; i++)
            {
                dataGridStates.Rows.Add(i.ToString());
            }

            */
        }

        private bool validateFields(TextBox field)
        {
            if (string.IsNullOrEmpty(field.Text) || !isNumber(field.Text))
            {                 
                return false;
            }

            try
            {
                int.Parse(field.Text);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        private bool captureValues()
        {
            if (!validateFields(txtStates))
            {
                MessageBox.Show("Quantidade de estados inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                amountStates = int.Parse(txtStates.Text);
                if (amountStates < 2)
                {
                    MessageBox.Show("Devem existir ao menos 2 estados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (!validateFields(txtValues))
            {
                MessageBox.Show("Quantidade de valores inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }else
            {
                amountValues = int.Parse(txtValues.Text);
                if (amountValues < 1)
                {
                    MessageBox.Show("Devem existir ao menos 1 valor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            arrayValues = new String[amountValues];
            for (int i = 0; i < amountValues; i++)
            {
                aux = Interaction.InputBox("Valor de " + i + ":", "Valores de ");
                while (true)
                {
                    if (string.IsNullOrEmpty(aux) || aux.Length > 1)
                    {
                        MessageBox.Show("Digite um valor válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        aux = Interaction.InputBox("VALOR  " + i + ":");
                    }
                    else if (validateValues(aux)) {
                        MessageBox.Show("Valor informado já existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        aux = Interaction.InputBox("Valor de " + i + ":");
                    } else
                    {
                        break;
                    }
                }
                arrayValues[i] = aux;
            }


            return true;
        }

        private bool captureRules()
        {


            
            

            return true;
        }

        private bool validateValues(string x)
        {
            for (int i = 0; i < arrayValues.Length; i++)
            {
                if (arrayValues.Length == 0)
                {
                    return false;
                }
                if (x.Equals(arrayValues[i]))
                {
                    return true;
                }
            }
            return false;
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
