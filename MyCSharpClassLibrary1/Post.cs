using System;
using System.Collections.Generic;

namespace MyCSharpClassLibrary1
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public List<string> Tags { get; set; }
        public Post(Guid id, string title, string description, string image, string createdBy, DateTime createdAt, string modifiedBy, DateTime modifiedAt, List<string> tags)
        {
            Id = id;
            Title = title;
            Description = description;
            Image = image;
            CreatedBy = createdBy;
            CreatedAt = createdAt;
            ModifiedBy = modifiedBy;
            ModifiedAt = modifiedAt;
            Tags = tags;
        }
        public Post(string title, string description, string image, string createdBy, DateTime createdAt, string modifiedBy, DateTime modifiedAt, List<string> tags)
        {
            Id = Guid.NewGuid();
            Title = title;
            Description = description;
            Image = image;
            CreatedBy = createdBy;
            CreatedAt = createdAt;
            ModifiedBy = modifiedBy;
            ModifiedAt = modifiedAt;
            Tags = tags;
        }
    }
}
