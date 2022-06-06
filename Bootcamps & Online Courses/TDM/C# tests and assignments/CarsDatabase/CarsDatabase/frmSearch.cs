using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsDatabase
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void tblCarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblCarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'database1DataSet.TblCar'. È possibile spostarla o rimuoverla se necessario.
            this.tblCarTableAdapter.Fill(this.database1DataSet.TblCar);

        }

        private void fieldComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            operatorComboBox.Items.Clear();
            string answer = fieldComboBox.SelectedItem.ToString();

            string[] stringitem = { "=" };
            string[] intitem = { "=", "<", ">", "<=", ">=" };

            if (answer.Equals("RentalPerDay") || answer.Equals("DateRegistered"))
            {
                operatorComboBox.Items.AddRange(intitem);
            }
            else
            {
                operatorComboBox.Items.AddRange(stringitem);
            }
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RunBTN_Click(object sender, EventArgs e)
        {
            try
            {
                string value = textBox1.Text.Trim();
                string op = operatorComboBox.Text.ToString();
                string field = fieldComboBox.Text.ToString();
                string query;

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("No Value in the Value field");
                }

                else if (operatorComboBox.Items.Count == 1)
                {
                    query = string.Format("{0} Like '%{1}%'", field, value);
                    tblCarBindingSource.Filter = query;
                }

                else
                {
                    if (op.Equals("="))
                    {
                        query = string.Format("{0} = {1}", field, value);
                        tblCarBindingSource.Filter = query;
                    }

                    else if (op.Equals(">"))
                    {
                        query = string.Format("{0} > {1}", field, value);
                        tblCarBindingSource.Filter = query;
                    }

                    else if (op.Equals("<"))
                    {
                        query = string.Format("{0} < {1}", field, value);
                        tblCarBindingSource.Filter = query;

                    }

                    else if (op.Equals("<="))
                    {
                        query = string.Format("{0} <= {1}", field, value);
                        tblCarBindingSource.Filter = query;
                    }

                    else if (op.Equals(">="))
                    {
                        query = string.Format("{0} >= {1}", field, value);
                        tblCarBindingSource.Filter = query;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was an error with the search");
            }
        }

        private void fieldComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
