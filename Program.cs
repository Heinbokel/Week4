using Week4.models;
using Week4.repositories;
using Week4.services;

// AutoPolicyInfoRetriever autoPolicyInfoRetriever = new AutoPolicyInfoRetriever();

// autoPolicyInfoRetriever.GetDrivers("24323");

// LifePolicyInfoRetriever lifePolicyInfoRetriever = new LifePolicyInfoRetriever();

// GeneralPolicyInfo life = lifePolicyInfoRetriever.GetGeneralPolicyInfo("343");
// GeneralPolicyInfo auto = autoPolicyInfoRetriever.GetGeneralPolicyInfo("244");

// Service service = new Service();

// GeneralPolicyInfoRetriever generalPolicyInfoRetriever = new GeneralPolicyInfoRetriever();

// service.DisplayPremium(generalPolicyInfoRetriever);

// service.DisplayPremium(autoPolicyInfoRetriever);

// service.DisplayPremium(lifePolicyInfoRetriever);

IUserProfileRepository userProfileRepository = new UserProfileRepositoryEFImpl();
UserProfileService userProfileService = new UserProfileService(userProfileRepository);

userProfileService.GetUserProfiles().ForEach(
    profile => Console.WriteLine(profile.UserId)
);

string newUserId = userProfileService.SaveUserProfile();

Console.WriteLine(newUserId);