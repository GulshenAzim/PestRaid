﻿namespace Core.Entities.Abstract
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
