using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanh2
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
            CashForm.POS FO = new CashForm.POS();
            addFormOrder(FO);
            
        }     
        public void addFormOrder(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e)
        {
            Adminform.AddProduct ap = new Adminform.AddProduct();
            addFormOrder(ap);
        }

        private void ButtonTransactionHistory_Click(object sender, EventArgs e)
        {
            ViewForm.Transactionhistory th = new ViewForm.Transactionhistory();
            addFormOrder(th);
        }
    }
    
}
