namespace ManualWcf.Common
{
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class UserDto
    {
        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public DateTime CreatedDate { get; set; }

        [DataMember]
        public int Age { get; set; }
    }
}
