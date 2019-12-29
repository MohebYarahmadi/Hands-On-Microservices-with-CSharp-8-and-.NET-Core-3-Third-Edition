﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using ProductServiceClient;
using ProductServiceClient.Models;

namespace ProductServiceClient
{
    public static partial class ProductOperationsExtensions
    {
        /// <param name='operations'>
        /// Reference to the ProductServiceClient.IProductOperations.
        /// </param>
        public static IList<Product> Get(this IProductOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IProductOperations)s).GetAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the ProductServiceClient.IProductOperations.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<Product>> GetAsync(this IProductOperations operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<ProductServiceClient.Models.Product>> result = await operations.GetWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}