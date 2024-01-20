﻿using WebAppGrapQL.Abstractions;
using WebAppGrapQL.Models.Dto;

namespace WebAppGrapQL.Mutation
{
    public class MySimpleMutation
    {
        public int AddProduct(ProductDto product, [Service] IProductService service)
        {
            var id = service.AddProduct(product);
            return id;
        }
    }
}
