using MediatR;
using Shared.DataTransferObjects;

namespace Application.Commands;

public record UpdateCompanyCommand(Guid Id, CompanyForUpdateDto Company, bool TrackChanges) : IRequest<Unit>;