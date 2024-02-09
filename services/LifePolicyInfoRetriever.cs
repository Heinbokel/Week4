using Week4.models;

namespace Week4.services {

    public class LifePolicyInfoRetriever: GeneralPolicyInfoRetriever {

        public override GeneralPolicyInfo GetGeneralPolicyInfo(string policyNumber)
        {
            // Pretend to call an external company's API
            // For life general policy info
            return new GeneralPolicyInfo { 
                PolicyHolder = "Mrs. Policy Woman",
                TermLengthInMonths = 6,
                PolicyNumber = policyNumber
            };
        }

    }

}