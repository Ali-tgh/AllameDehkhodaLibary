using System;
using System.Collections.Generic;
using System.Text;

namespace AllameDehkhoda.Domain.Entites
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
