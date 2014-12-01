using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InsuranceWorkflow
{
   [Serializable]
 public class InsuranceEventArgs : ExternalDataEventArgs
 {
    private string person;
    private double amount;

    public InsuranceEventArgs(Guid instanceId, string person, double amount): base(instanceId)
    {
        this.person = person;
        this.amount = amount;
    }

    public string Person
    {
        get { return person; }
        set { person = value; }
    }

    public double Amount
    {
        get { return amount; }
        set { amount = value; }
    }
}

   [ExternalDataExchange]
   public interface IInsuranceServices
   {

       event EventHandler<InsuranceEventArgs> ClaimCreated;
       event EventHandler<InsuranceEventArgs> GatherClaimInfo;
       event EventHandler<InsuranceEventArgs> EvaluateClaim;
       event EventHandler<InsuranceEventArgs> ClaimProcessingCompleted;
   }
}
