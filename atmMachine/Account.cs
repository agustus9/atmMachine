using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmMachine
{
    class Account
    {
        string name; //-name(string)
        string id;   //-id(String)
        double balance;  //-balance(double)


        static int count;  //-static int count;

        public Account() {
            // empty contructor
        }
        public Account( string name, double initBalance)  //+idcontructor/generator (name,initial balance)
        {
            this.name = name;
            this.balance = initBalance;
            this.id = this.generateID();
        }
        public string getName() { //+get name()
            return this.name;
        }
        public string generateID() { //+str create id()

            return "dummy";
        }
        public double getBalance() //+get balance
        {
            return this.balance;
        }
        public string getID() //+get id
        {
            return this.id;
        }
        public bool deposit( double amount) { //+total bool deposit(amount)

            return true;
        }
        public bool withdraw(double amount)  //+total bool withdraw(amount)
        {

            return true;
        }
    }
}
