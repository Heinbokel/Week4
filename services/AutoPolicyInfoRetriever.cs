namespace Week4.services {

    public class AutoPolicyInfoRetriever: GeneralPolicyInfoRetriever {

        public List<string> GetDrivers(string policyNumber) {
            return ["Bob Heinbokel", "Doug Heinbokel"];
        }

    }

}