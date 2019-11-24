using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maquina_Turing.View;
using Microsoft.VisualBasic;

namespace Maquina_Turing
{
    public partial class MachineTuring : Form
    {

        private int amountValues;
        private int amountStates;
        private string[] arrayStates;
        private string[] arrayValues;
        private Rule[,] matrixRules;
        private Rule rule;
        private string aux;

        public MachineTuring()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (captureValues())
            {
                createColumnTables();
                btnConfirm.Enabled = false;

                if (captureRules())
                {
                    insertValuesTable();
                }
                else
                {
                    btnConfirm.Enabled = true;
                }

            }
            else
            {
                btnConfirm.Enabled = true;
            }
        }

        private void insertValuesTable()
        {
            for (int i = 0; i < amountStates; i++)
            {
                // cria uma linha
                DataGridViewRow item = new DataGridViewRow();
                item.CreateCells(dataGridValues);

                for (int j = 0; j < amountValues; j++)
                {
                    rule = matrixRules[i, j];
                    item.Cells[j].Value = rule != null ? rule.formatRule() : "-";
                }

                // adiciona na grid
                dataGridValues.Rows.Add(item);
            }
        }

        private void createColumnTables()
        {
            // Inserts state values ​​and columns
            dataGridStates.Columns.Add("states", "Estados");
            for (int i = 0; i < amountStates; i++)
            {
                dataGridStates.Rows.Add(i.ToString());
            }

            // Inserts the columns with the values ​​given in the table.
            for (int i = 0; i < amountValues; i++)
            {
                dataGridValues.Columns.Add(i.ToString(), arrayValues[i]);
            }
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
            // Validate values of states
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

            // Validate values of values table
            if (!validateFields(txtValues))
            {
                MessageBox.Show("Quantidade de valores inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                amountValues = int.Parse(txtValues.Text);
                if (amountValues < 1)
                {
                    MessageBox.Show("Devem existir ao menos 1 valor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            // captures the amount of values ​​entered
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
                    else if (validateValues(aux))
                    {
                        MessageBox.Show("Valor informado já existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        aux = Interaction.InputBox("Valor de " + i + ":");
                    }
                    else
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
            // insert state values ​​into array
            arrayStates = new String[amountStates];
            for (int i = 0; i < amountStates; i++)
            {
                arrayStates[i] = i.ToString();
            }

            matrixRules = new Rule[amountStates, amountValues];
            for (int x = 0; x < arrayStates.Length; x++)
            {
                for (int y = 0; y < arrayValues.Length; y++)
                {
                    // go through each position to get the selected values
                    CaptureRulesTableAction cap = new CaptureRulesTableAction(x, arrayValues[y], arrayStates, arrayValues);
                    cap.ShowDialog();

                    matrixRules[x, y] = ((Rule)cap.getRule());
                    if (cap.Exit())
                    {
                        return false;
                    }
                }
            }

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

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            new RunMachineTuring(txtEntry.Text, matrixRules, arrayValues, amountStates).ShowDialog();
        }
    }
}
