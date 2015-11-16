namespace ManualWcf.Common
{
    using System.Collections.Generic;
    using System.ServiceModel;

    [ServiceContract]
    public interface IUserManagingService
    {
        [OperationContract]
        List<UserDto> GetAllUsers();

        [OperationContract]
        void AddUser(UserDto user);
    }
}
