using Week4.models;
using Week4.repositories;

namespace Week4.services {

    public class UserProfileService {

        private readonly IUserProfileRepository _userProfileRepo;

        public UserProfileService(IUserProfileRepository userProfileRepository) {
            this._userProfileRepo = userProfileRepository;
        }

        public List<UserProfile> GetUserProfiles() {
            return this._userProfileRepo.GetUserProfiles();
        }

        public string SaveUserProfile() {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string biography = Console.ReadLine();

            return _userProfileRepo.SaveUserProfile(firstName, lastName, biography);
        }

    }

}