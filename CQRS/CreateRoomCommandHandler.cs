using Amazon.Lambda.APIGatewayEvents;
using System.Threading;
using System.Threading.Tasks;
using Flyingdarts.Persistence;
using MediatR;

public class CreateRoomCommandHandler : IRequestHandler<CreateRoomCommand, APIGatewayProxyResponse>
{
    public CreateRoomCommandHandler()
    {
    }
    public async Task<APIGatewayProxyResponse> Handle(CreateRoomCommand request, CancellationToken cancellationToken)
    {
        return new APIGatewayProxyResponse { StatusCode = 200 };
    }
}