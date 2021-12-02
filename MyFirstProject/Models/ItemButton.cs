using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Models
{
    public class ItemButton
    {
        public string Name { get; set; }

        public ItemButton(string n)
        {
            Name = n;
        }

        public static List<ItemButton> GetName()
        {
            return new List<ItemButton>
            {
                new ItemButton("Gaurdians of The Galaxy"),
                new ItemButton("The Hulk"),
                new ItemButton("Iron Man")
            };
        }
    }
}
