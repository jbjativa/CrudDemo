using System;
namespace CrudDemo.Models
{
    public abstract class BaseObject
    {
        public String Id { get; set; }
        public virtual string Name { get; set; }

        public BaseObject()
        {
            this.Id = Guid.NewGuid().ToString();
        }

    }


}