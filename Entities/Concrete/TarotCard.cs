using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class TarotCard : IEntity
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public int CardNum { get; set; }
        public int CardGroup { get; set; }
        public string CardName { get; set; }


    }
}
