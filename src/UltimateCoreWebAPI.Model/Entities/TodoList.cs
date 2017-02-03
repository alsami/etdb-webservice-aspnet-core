﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UltimateCoreWebAPI.Model.Abstractions;

namespace UltimateCoreWebAPI.Model.Entities
{
    public class TodoList : IPersistedData
    {
        public TodoList()
        {
            this.TodoItems = new List<TodoItem>();
        }

        public int Id { get; set; }

        public string Designation { get; set; }

        public virtual ICollection<TodoItem> TodoItems { get; private set; }
    }
}