﻿using Discount.Grpc.Protos;
using System.Runtime.CompilerServices;

namespace Basket.API.GrpcServices;

public class DiscountGrpcService
{
    private readonly DiscountProtoService.DiscountProtoServiceClient _client;

    public DiscountGrpcService(DiscountProtoService.DiscountProtoServiceClient client)
    {
        _client = client;
    }

    public async Task<CouponModel> GetDiscount(string productName)
    {
        var discountRequest = new GetDiscountRequest { ProductName = productName };

        return await _client.GetDiscountAsync(discountRequest);
    }
}
