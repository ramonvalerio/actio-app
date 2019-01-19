using System;

namespace Actio.Common.Events
{
    public class ActivityCreated : IAuthenticatedEvent
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public string Category { get; set; }
        
        public string Name { get; set; }

        public string Description { get; set; }

        public string CreateAt { get; set; }
        
        public ActivityCreated()
        {
            
        }

        public ActivityCreated(Guid id, Guid userId, string category)
        {
            Id = id;
            UserId = userId;
        }
    }
}