﻿using ShoppingCart.Data.Infrastructure.Interfaces;
using ShoppingCart.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Data.Infrastructure.Repository
{
    public class CardRepository : Repository<CardDetail>, ICardRepository
    {
        public CardRepository(ShoppingCartContext context) : base(context) { }
    }
}
