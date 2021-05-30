using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class TarotImage : IEntity
    {
        public int Id { get; set; }
        public int CardNum { get; set; }
        public string ImagePath { get; set; }
    }
}
