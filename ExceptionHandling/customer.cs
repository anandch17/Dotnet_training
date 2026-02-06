using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
	public class customer
	{
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private int _balance;

		public int Balance
		{
			get { return _balance; }
			set { _balance = value; }
		}

		private int _accno;
		public int AccNo
		{
			get { return _accno; }
			set { _accno = value; }
		}



		public customer()
		{

		}


		public customer(string name,int acc,int bal)
		{
			_name = name;
			_accno = acc;
			_balance = bal;
		}
		 public void withdraw(int amount)
		{
			if (_balance - amount <= 100)
			{
				throw new bankexception(_accno,_balance);
			}
			_balance -= amount;
		}

		public int getbalance() { return _balance; }

        public override string ToString()
        {
			return $"Account Holders is {_name}" + $" Account no is {_accno} "+ $"Balance:{_balance}";
        }

	}
}
