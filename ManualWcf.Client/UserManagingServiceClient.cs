namespace ManualWcf.Client
{
    using System.Collections.Generic;
    using System.ServiceModel;
    using ManualWcf.Common;

    public class UserManagingServiceClient : ClientBase<IUserManagingService>, IUserManagingService
    {
        public List<UserDto> GetAllUsers()
        {
            return Channel.GetAllUsers();
        }

        public void AddUser(UserDto user)
        {
            Channel.AddUser(user);
        }
    }
}
