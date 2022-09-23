using System;
using System.ComponentModel.DataAnnotations;

namespace MegaWeb.Shared.Models
{
    public abstract class BaseModel
    {
        [Key]
        public int Id { get; set; }

        public DateTime Inserted { get; set; }

        public DateTime? UpdateAt { get; set; }
        public bool IsDelete { get; set; }

        public BaseModel()
        {
            Inserted = DateTime.Now;
            IsDelete = false;
        }
    }
}