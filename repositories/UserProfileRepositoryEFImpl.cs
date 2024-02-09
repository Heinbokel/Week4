using Week4.models;

namespace Week4.repositories
{

    public class UserProfileRepositoryEFImpl : IUserProfileRepository
    {
        public List<UserProfile> GetUserProfiles()
        {
            return [
                new UserProfile {
                     FirstName = "Eliana",
                     LastName = "Heinbokel",
                     Biography = "I was born in Petoskey in 2016.",
                     UserId = "4"
                    },
                new UserProfile {
                     FirstName = "Frank",
                     LastName = "Smith",
                     Biography = "I was born in Mexico.",
                     UserId = "5"
                    }
            ];
        }

        public string SaveUserProfile(string firstName, string lastName, string biography)
        {
            //pretend to save something to the database
            return "777";
        }
    }

}