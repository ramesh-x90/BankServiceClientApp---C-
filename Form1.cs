using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;



using BankServiceClientApp.Context;

namespace BankServiceClientApp
{
    public partial class Form1 : Form
    {

        public BindingSource bs = new BindingSource();

        BankAppContext context;
        public Form1()
        {
            InitializeComponent();

            //initialize the context
            try
            {
                context = BankAppContext.Instance;
                this.listBox1.DataSource = context.accountsList;
                this.listBox1.DisplayMember = "firstName";

                this.userAccIDTextBox.DataBindings.Add(new Binding("Text", context, "currentAccountID", true, DataSourceUpdateMode.OnPropertyChanged));
                this.userAccPassCode.DataBindings.Add(new Binding("Text", context, "currentAccountPasscode", true, DataSourceUpdateMode.OnPropertyChanged));
                this.userCurrentBalanceText.DataBindings.Add("Text", context, "currentAccountBalance", true, DataSourceUpdateMode.OnPropertyChanged);

                this.trasnferAccid.DataBindings.Add("Text", context, "currentSelectedRefaccId", true, DataSourceUpdateMode.OnPropertyChanged);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                this.Close();
            }








        }





        private void btnRefreshBalance_Click(object sender, EventArgs e)
        {
            context.updateBalance();

        }

        private void createAccBtn_Click(object sender, EventArgs e)
        {
            string res = context.createBankAccount(createAccFirstName.Text, createAccLastName.Text, createAccPh.Text, createAccAdd.Text,createAccNic.Text);
            this.createAccResBox.Text = combineResults(this.createAccResBox.Text , res);


            //clearCreatAccountTab();
        }


        private void clearCreatAccountTab()
        {
            createAccFirstName.Text = "";
            createAccLastName.Text = "";
            createAccPh.Text = "";
            createAccAdd.Text = "";
            createAccNic.Text = "";
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            string res = context.deposit(depositeAmountText.Text);
            depositresBox.Text = combineResults(this.depositresBox.Text, res);
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            string res = context.withdraw(withdrawText.Text);
            withdrawresBox.Text = combineResults(this.withdrawresBox.Text, res);
        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            string res = context.transfer(trasnferAccid.Text , transferAmount.Text);
            transerResBox.Text = combineResults(this.transerResBox.Text, res);   
        }

        private string combineResults(string s1 , string s2)
        {
            return s1+"\n************\n"+s2;
        }



        private void accsListRefreshBtn_Click(object sender, EventArgs e)
        {

            backListDataUpdate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backListDataUpdate();
        }

        private void backListDataUpdate()
        {
            Action action = () => {

                string text = this.Text;
                this.Text = text + " | loading....";
                context.updateAccountList();
                this.Text = text;

            };

            this.Invoke(action);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            context.changeRefaccount(listBox1.SelectedIndex);
        }


    }
}
