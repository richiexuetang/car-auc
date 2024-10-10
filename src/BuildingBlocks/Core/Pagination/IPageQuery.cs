﻿namespace CarAuc.BuildingBlocks.Core.Pagination;

using MediatR;

public interface IPageQuery<out TResponse> : IPageRequest, IRequest<TResponse>
    where TResponse : class
{ }
