using Week4.models;

namespace Week4.repositories
{

    public class UserProfileRepositoryDapperImpl : IUserProfileRepository
    {
        public List<UserProfile> GetUserProfiles()
        {
            return [
                new UserProfile {
                     FirstName = "Bob",
                     LastName = "Heinbokel",
                     Biography = "I was born in Petoskey.",
                     UserId = "5343532"
                    },
                new UserProfile {
                     FirstName = "Doug",
                     LastName = "Heinbokel",
                     Biography = "I was born in Petoskey.",
                     UserId = "5343442"
                    }
            ];
        }

        public string SaveUserProfile(string firstName, string lastName, string biography)
        {
            //pretend to save something to the database
            return "243234";
        }
    }

}