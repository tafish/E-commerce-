﻿using Ecommerce.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Repository
{
    public interface IReviewRepository : IRepository<Review>
    {
        Task<List<Review>> GetReviewswithReplyByProductId(int productId);
    }
}
