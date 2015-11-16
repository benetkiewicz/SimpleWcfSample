namespace ManualWcf.Service
{
    using System;
    using System.Collections.Generic;
    using ManualWcf.Common;

    public class UserManagingService : IUserManagingService
    {
        public List<UserDto> GetAllUsers()
        {
            return new List<UserDto> { new UserDto { Age = 21, CreatedDate = DateTime.Now, Email = "pbenetkiewicz@gmail.com", IsActive = true}};
        }

        public void AddUser(UserDto user)
        {
        }
    }
}
