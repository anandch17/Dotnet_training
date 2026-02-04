using System;
using System.Collections.Generic;
using System.Text;


namespace InsuranceLibrary.Models
{
	public class InsurancePolicy
	{
		private int PolicyId;


		public int PolicyID
		{
			get { return PolicyId; }
			set { PolicyId = value; }
		}

		private string PolicyHolderName;

		public string PolicyHolder
		{
			get { return PolicyHolderName; }
			set { PolicyHolderName = value; }

		}

		private string PolicyType;

		public string TypeOfPolicy
		{
			get { return PolicyType; }
			set { PolicyType = value; }
        }

		private double PremiumAmount;

		public double Premium
		{
			get { return PremiumAmount; }
			set { PremiumAmount = value; }
        }

		private int PolicyTerm;

		public int Term
		{
			get { return PolicyTerm; }
			set { PolicyTerm = value; }
        }

		private bool IsActive=true;

        public InsurancePolicy(int id, string name, string type, double amount, int term, bool status)
        {
			PolicyId = id;
			PolicyHolderName = name;
			PolicyType = type;
			PremiumAmount = amount;
			PolicyTerm = term;
			IsActive = status;
        }

        public bool ActiveStatus
		{
			get { return IsActive; }
			set { IsActive = value; }
        }

        public string ToString()
        {
            return $"PoliyID:{PolicyId}, PolicyHolder: {PolicyHolder}, TypeOfPolicy: {TypeOfPolicy}, Premium: {Premium}, Term: {Term}, ActiveStatus: {ActiveStatus}";
        }

    }
	
}
