using System;

namespace Entities
{
    public class Log : IEntity
    {
        public int Id { get; set; }
        public string Error { get; set; }
        public DateTime? CreateDate { get; set; }
        public string HataBilgi { get; set; }
    }
}
