using System;
using System.Collections.Generic;
using System.Text;
using Exercicio9.Entities.Enums;

namespace Exercicio9.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return ($"ID: {Id} , {Moment} , {Status}");
        }
    }
}
