﻿using Matcha.Sync.Model;

namespace Matcha.Sync.Mobile.Tests
{
    public class TodoItem : Synchronizable
    {
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
