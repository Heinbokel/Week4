using Week4.models;

namespace Week4.repositories {

    public interface IUserProfileRepository {

        /// <summary>
        /// Saves a user profile to the database.
        /// </summary>
        /// <param name="firstName">The first name of the user</param>
        /// <param name="lastName">The last name of the user</param>
        /// <param name="biography">The biography of the user</param>
        /// <returns>The generated user profile ID</returns>
        public string SaveUserProfile(string firstName,
            string lastName, string biography);

        /// <summary>
        /// Retrieves all user profiles.
        /// </summary>
        /// <returns>The list of user profiles</returns>
        public List<UserProfile> GetUserProfiles();

    }

}