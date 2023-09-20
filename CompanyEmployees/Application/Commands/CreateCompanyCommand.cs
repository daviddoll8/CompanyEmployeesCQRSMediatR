using MediatR;
using Shared.DataTransferObjects;

namespace Application.Commands;

public record CreateCompanyCommand(CompanyForCreationDto Company) : IRequest<CompanyDto>;