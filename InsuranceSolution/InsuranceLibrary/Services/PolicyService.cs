using InsuranceLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace InsuranceLibrary.Services
{
    public class PolicyService
    {
        List<InsurancePolicy> policies = new List<InsurancePolicy>
            {
                new InsurancePolicy(101, "Alice Johnson", "Health", 1200.50, 12, true),
                new InsurancePolicy(102, "Bob Smith", "Auto", 800.75, 6, true),
                new InsurancePolicy(103, "Charlie Brown", "Home", 1500.00, 24, false),
                new InsurancePolicy(104, "Diana Prince", "Life", 2000.00, 36, true),
                new InsurancePolicy(105, "Ethan Hunt", "Travel", 500.25, 3, false)
            };

        public void AddPolicy(InsurancePolicy policy)
        {
            Console.WriteLine("Enter PolicyId");
            policy.PolicyID= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter PolicyHolderName");
            policy.PolicyHolder= Console.ReadLine();
            Console.WriteLine("Enter PolicyType(Health/Life/Vehicle)");
            policy.TypeOfPolicy= Console.ReadLine();
            Console.WriteLine("Enter PremiumAmount");
            policy.Premium= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter PolicyTerm");
            policy.Term= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter IsActive status (true/false)");
            policy.ActiveStatus= Convert.ToBoolean(Console.ReadLine());

            policies.Add(policy);
            Console.WriteLine("Policy added successfully.");
        }

        public List<InsurancePolicy> GetAllPolicies()
        {
            return policies;
        }


        public InsurancePolicy GetPolicyById(int id)
        {
            return policies.FirstOrDefault(p => p.PolicyID == id);
        }
       

        public bool UpdatePolicy(int id,double newPremium,int newTerm)
        {
            InsurancePolicy p= GetPolicyById(id);
            if(p== null)
            {
                return false;
            }
            p.Premium= Convert.ToDouble(newPremium);
            p.Term= newTerm;
            return true;
        }

        public List<InsurancePolicy> SearchPolicyById(int policy_id)
        {
            return policies.Where(p => p.PolicyID==policy_id).ToList();
        }

        public bool DeletePolicy(int id)
        {
            InsurancePolicy p= GetPolicyById(id);
            if(p== null)
            {
                return false;
            }
            policies.Remove(p);
            return true;
        }
    }
}
