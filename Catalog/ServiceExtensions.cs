﻿using System;

using Catalog.Services;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Http;

using MudBlazor.Services;

namespace Catalog;

public static class ServiceExtensions
{
    public static IServiceCollection AddApp(this IServiceCollection services)
    {
        services.AddMudServices();

        services.AddScoped<INotificationService, NotificationService>();

        services.AddSingleton<IFilePickerService, FilePickerService>();

        services.AddHttpClient(nameof(Catalog.Client.IClient), (sp, http) =>
        {
            http.BaseAddress = new Uri(Constants.ApiUriString);
        })
        .AddTypedClient<Catalog.Client.IClient>((http, sp) => new Catalog.Client.Client(http));

        services.AddHttpClient(nameof(Catalog.Client.IItemsClient), (sp, http) =>
        {
            http.BaseAddress = new Uri(Constants.ApiUriString);
        })
        .AddTypedClient<Catalog.Client.IItemsClient>((http, sp) => new Catalog.Client.ItemsClient(http));

        return services;
    }
}

