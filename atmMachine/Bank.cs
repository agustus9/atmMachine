using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmMachine
{
    class Bank
    {

        public string ID { get; set; }
        public string id { get; private set; }
        public string name { get; private set; }
        public string balance { get; private set; }

        Account[] accounts;
        public void createAccount() {

        }

        public bool deposit(double amount) { // bool deposit(amount)

            return true;
        }
        public bool withdraw(double amount) {  //+ bool withdraw(amount)

            return true;
        }

        public void showAccountInfo(string name, double balance) {
            string message = "The account ID: " + this.id;
            this.message(message);

            message = "Name: " + this.name;
            this.message(message);

            message = "Balance: " + this.balance;
            this.message(message);
        }
        void message(string msg) {
            System.Console.WriteLine(msg);
        }
    }
}
