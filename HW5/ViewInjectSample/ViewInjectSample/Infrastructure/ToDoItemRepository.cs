﻿using System.Collections.Generic;
using System.Linq;
using ViewInjectSample.Interfaces;
using ViewInjectSample.Model;

namespace ViewInjectSample.Infrastructure
{
    public class ToDoItemRepository : IToDoItemRepository
    {
        private static List<ToDoItem> _items = new List<ToDoItem>();

        static ToDoItemRepository()
        {
            for (int i = 0; i < 50; i++)
            {
                _items.Add(new ToDoItem()
                {
                    IsDone = i % 3 == 0,
                    Name = "Task " + (i + 1),
                    Priority = i % 5 + 1
                });
            }
        }
        public IEnumerable<ToDoItem> List()
        {
            return _items.AsEnumerable();
        }
    }
}