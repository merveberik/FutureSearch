﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CardDescription : IEntity
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public string Description { get; set; }


    }
}
