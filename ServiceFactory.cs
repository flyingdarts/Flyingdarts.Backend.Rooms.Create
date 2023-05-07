
using System;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using FluentValidation;

public static class ServiceFactory
{
    public static ServiceProvider GetServiceProvider()
    {
        var services = new ServiceCollection();
        services.AddValidatorsFromAssemblyContaining<CreateRoomCommandValidator>();
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CreateRoomCommand).Assembly));
        return services.BuildServiceProvider();
    }
}