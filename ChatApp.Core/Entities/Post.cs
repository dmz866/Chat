﻿using System;

namespace Chat.Core.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
