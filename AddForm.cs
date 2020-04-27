using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace TicketPrice
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            
        }
        
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.testDataSet.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount;
                nRow[0] = rc;
                nRow[1] = tbName.Text;
                nRow[2] = tbMail.Text;
                nRow[3] = tbBirthday.Text;
                if (rdClient.Checked == true) { nRow[4] = rdClient.Text; }
                else { rdClient.Text = ""; }
                if (rdStudent.Checked == true) { nRow[4] = rdStudent.Text; }
                else { rdStudent.Text = ""; }
                if (rdPens.Checked == true) { nRow[4] = rdPens.Text; }
                else { rdPens.Text = ""; }
                nRow[5] = tbPrice.Text;
                main.testDataSet.Tables[0].Rows.Add(nRow);
                main.clientsTableAdapter.Update(main.testDataSet.clients);
                main.testDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                tbName.Text = "";
                tbMail.Text = "";
                tbBirthday.Text = "";
                tbPrice.Text = "";
            }
        }

        private void PriceBtn_Click(object sender, EventArgs e)
        {
           if(rdClient.Checked == true)
            {
                Client c1 = new Client(tbBirthday.Text);
                tbPrice.Text = Convert.ToString(c1.priceCalculation());
            }
           if (rdStudent.Checked == true)
            {
                Student s1 = new Student(tbBirthday.Text, comboBox1.Text);
                tbPrice.Text = Convert.ToString(s1.priceCalculation());
            }
           if(rdPens.Checked == true)
            {
                Pensioner p1 = new Pensioner(tbBirthday.Text, comboBox2.Text);
                tbPrice.Text = Convert.ToString(p1.priceCalculation());
            }
            

        }

       
    }
}
