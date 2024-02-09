using Week4.models;

namespace Week4.services {

    public class GeneralPolicyInfoRetriever {

        public virtual GeneralPolicyInfo GetGeneralPolicyInfo(string policyNumber) {
            // Pretend we query the database
            // We call out to experian
            // We call out to 7 other teams
            return new GeneralPolicyInfo {
                PolicyHolder = "Mr Policy Man",
                PolicyNumber = policyNumber,
                TermLengthInMonths = 12
             };
        }

        public decimal GetPolicyPremium(string policyNumber) {
            return 4243.55m;
        }

    }

}