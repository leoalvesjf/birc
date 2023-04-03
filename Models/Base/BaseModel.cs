using System.Runtime.Serialization;

namespace BIRC.Models.Repositories
{
    [DataContract]
    public abstract class BaseModel
    {
        [DataMember]
        public int Id { get; set; }
    }
}
