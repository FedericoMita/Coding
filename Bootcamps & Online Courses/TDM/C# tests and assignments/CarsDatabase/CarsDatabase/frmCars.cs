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
    public partial class frmCars : Form
    {
        public frmCars()
        {
            InitializeComponent();
        }

        private void tblCarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.tblCarBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.database1DataSet);
            }
            catch (Exception)
            {
                MessageBox.Show("Complete the textboxes properly before saving.");
            }
        }

        private void frmCars_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'database1DataSet.TblCar'. È possibile spostarla o rimuoverla se necessario.
            this.tblCarTableAdapter.Fill(this.database1DataSet.TblCar);

        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are quitting the program.");
            Application.Exit();
        }

        private void FirstBTN_Click(object sender, EventArgs e)
        {
            try
            {
                bindingNavigatorMoveFirstItem.PerformClick();
            }
            catch (Exception)
            {
                MessageBox.Show("Complete the textboxes before changing page.");
            }
        }

        private void PreviousBTN_Click(object sender, EventArgs e)
        {
            try
            {
                bindingNavigatorMovePreviousItem.PerformClick();
            }
            catch(Exception)
            {
                MessageBox.Show("Complete the textboxes before changing page.");
            }
        }

        private void NextBTN_Click(object sender, EventArgs e)
        {
           //weirdly, clicking Next doesn't throw an error even with NULL fields, so it doesn't appear to need an exception
            bindingNavigatorMoveNextItem.PerformClick();
        }

        private void LastBTN_Click(object sender, EventArgs e)
        {
            //weirdly, clicking Last doesn't throw an error even with NULL fields, so it doesn't appear to need an exception
            bindingNavigatorMoveLastItem.PerformClick();
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            try
            {
                bindingNavigatorAddNewItem.PerformClick();
            }
            catch(Exception)
            {
                MessageBox.Show("You have clicked the wrong button. Please click the button above to save.");
            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.PerformClick();
            label2.Text = "This record has been deleted.";
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            tblCarBindingNavigatorSaveItem.PerformClick();
            label2.Text = "This record has been updated.";
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            frmSearch f2 = new frmSearch();
            f2.Show();
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            idVehicleRegNoTextBox.Text = "";
            makeTextBox.Text = "";
            engineSizeTextBox.Text = "";
            rentalPerDayTextBox.Text = "";

            this.tblCarTableAdapter.Fill(this.database1DataSet.TblCar);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
