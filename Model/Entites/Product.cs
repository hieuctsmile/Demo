﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.Shared;

namespace Model.Entites
{
    public class Product : DomainEntity<int>
    {
        public Product()
        {

        }

        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Product(string name)
        {
            Name = name;
        }

        [StringLength(255)]
        public string Name { set; get; }
    }
}
