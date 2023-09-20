using Shared.DataTransferObjects;
using MediatR;

namespace Application.Queries;

public sealed record GetCompanyQuery(Guid Id, bool TrackChanges) : IRequest<CompanyDto>;