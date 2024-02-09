namespace Week4.services {

    public class Service {

        public void DisplayPremium(GeneralPolicyInfoRetriever retriever) {
            Console.WriteLine(retriever.GetPolicyPremium("244"));
        }

    }

}