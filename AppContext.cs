using BankServiceClientApp.BankService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Principal;
using System.Windows.Forms;

/*
 
 abstract the service layer to the application, if service interface change we only have to change here. i hope soo....
 
 */


namespace BankServiceClientApp.Context
{
    class BankAppContext : INotifyPropertyChanged
    {
        private static BankAppContext instance;
        private string _accId;
        private string _accPassCode;
        private string _selectedRefAcc = "";
        private BindingList<account> _accounts = new BindingList<account>();
        private BankServiceClient _client ;
        private double _currentAccBal = 0.0;


        public bool logedin = false;

        public event PropertyChangedEventHandler PropertyChanged;


        protected bool setValue<T>(ref T field, T value, string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                if (!EqualityComparer<T>.Default.Equals(field, value))
                {
                    field = value;
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                    return true;
                }
                //PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

            }
            return false;
        }


        //geters and setters

        public static BankAppContext Instance
        {
            set { }
            get
            {
                if (instance == null) instance = new BankAppContext();
                return instance;
            }
        }


        public string currentAccountID
        {
            set
            {
                setValue(ref _accId, value, "currentAccountID");

            }
            get
            {
                if (_accId == null) _accId = "";
                return _accId;
            }
        }
        public string currentAccountPasscode
        {
            set
            {
                setValue(ref _accPassCode, value, "currentAccountPasscode");
            }
            get
            {
                if (_accPassCode == null) _accPassCode = "";
                return _accPassCode;
            }
        }

        public double currentAccountBalance
        {
            set
            {
                setValue(ref _currentAccBal, value, "currentAccountBalance");

            }
            get
            {
                return _currentAccBal;
            }
        }

        public string currentSelectedRefaccId
        {
            get { return _selectedRefAcc; }
            set
            {
                setValue(ref _selectedRefAcc, value, "currentSelectedRefaccId");
            }
        }

        public BindingList<account> accountsList
        {
            set
            {
                setValue(ref _accounts, value, "accountsList");
            }
            get
            {
                return _accounts;
            }
        }

        //geters and setters

        private BankAppContext() {
            try
            {
                _client = new BankServiceClient();

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void updateAccountList()
        {
            baseAccount[] accs = _client.getAccounts();
            if (accs == null)
            {
                this.accountsList.Clear();
                return;
            }
            List<account> list = accs.ToList().Cast<account>().ToList();
            this.accountsList.Clear();
            list.ForEach(account => { this.accountsList.Add(account); });
        }


        public string createBankAccount(string firstName, string lastName, string phoneNo, string address, string NIC)
        {

            try
            {
                createAccountRes res = _client.createAccount(firstName, lastName, phoneNo, address, NIC);
                this.currentAccountID = res.acc.id;
                this.currentAccountPasscode = res.passCode;

                account account = (account)res.acc;

                updateAccountList();

                this.updateBalance();


                return String.Format("Account is created\nName: {0} {1}\nAddress: {2}\nPhone Number: {3}\nNic: {4}\nBalance: {5}",
                    account.firstName, account.lastName, account.address, account.phoneNo, account.NIC, account.balance);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return e.Message;
            }




        }

        public double updateBalance()
        {
            try {
                double balance = _client.checkAccountBalance(this._accId, this._accPassCode);
                this.currentAccountBalance = balance;

            }
            catch (Exception e) {
                MessageBox.Show(e.Message);
            }

            return this.currentAccountBalance;
        }


        public string withdraw(string amount)
        {
            try {
                double res = _client.withdrawMoney(_accId, _accPassCode, Double.Parse(amount));
                if (res < 0) return "error...\nfailed to perform the operation";
                this.updateBalance();
                return String.Format("{0} of money has been withdrawn by account id: {1}", res , this._accId);
            } catch (Exception e) {
                MessageBox.Show(e.Message);

                return e.Message;
            }

        }

        public string deposit(string amount)
        {
            try
            {
                double res = _client.depositMoney(_accId, _accPassCode, Double.Parse(amount));
                if (res < 0) return "error...\nfailed to perform the operation";
                this.updateBalance();
                return String.Format("{0} of money has been deposited on account id: {1}", res, this._accId);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

                return e.Message;
            }

        }

        public string transfer(string transferAccId , string amount)
        {
            try
            {
                double res = _client.transferMoney(_accId, transferAccId , _accPassCode, Double.Parse(amount));
                if (res < 0) return "error...\nfailed to perform the operation";
                this.updateBalance();
                return String.Format("{0} of money has been transfered from\naccount id {1} to account id: {2}", res, this._accId , transferAccId);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

                return e.Message;
            }
        }

        public void changeRefaccount(int a)
        {
            try
            {
                account acc = _accounts.ElementAt(a);
                if(acc == null)
                {
                    this.currentSelectedRefaccId = "";
                    return;
                }

                this.currentSelectedRefaccId = acc.id;

                Console.WriteLine(this.currentSelectedRefaccId);

            }
            catch (Exception)
            {
                
            }

        }


    }
}
