using InsuranceLibrary.Models;
using InsuranceLibrary.Services;
using System;

namespace InsuranceSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PolicyService service = new PolicyService();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nInsurance Policy Management System");
                Console.WriteLine("1. Add Policy");
                Console.WriteLine("2. View All Policies");
                Console.WriteLine("3. Search Policy by ID");
                Console.WriteLine("4. Update Policy");
                Console.WriteLine("5. Delete Policy");
                Console.WriteLine("6. Exit");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        service.AddPolicy(new InsurancePolicy(0, "", "", 0, 0, false));
                        break;

                    case 2:
                        service.GetAllPolicies().ForEach(policy => Console.WriteLine(policy.ToString()));
                        break;

                    case 3:
                        Console.WriteLine("Enter Policy ID:");
                        int sid = Convert.ToInt32(Console.ReadLine());
                        var policy = service.GetPolicyById(sid);
                        Console.WriteLine(policy != null ? policy.ToString() : "Policy not found");
                        break;

                    case 4:
                        Console.WriteLine("Enter Policy ID:");
                        int uid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter New Premium:");
                        double premium = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter New Term:");
                        int term = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(
                            service.UpdatePolicy(uid, premium, term)
                            ? "Policy updated successfully"
                            : "Policy not found"
                        );
                        break;

                    case 5:
                        Console.WriteLine("Enter Policy ID:");
                        int did = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(
                            service.DeletePolicy(did)
                            ? "Policy deleted successfully"
                            : "Policy not found"
                        );
                        break;

                    case 6:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
