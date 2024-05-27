// See https://aka.ms/new-console-template for more information
using CapacitacionDdd.Core.Aplication.Features.Command.AddAuthor;
using CapacitacionDdd.Core.Aplication.Features.Command.UpdateAuthor;
using CapacitacionDdd.Core.Aplication.Features.Queries.GetAuthorByCode;
using CapacitacionDdd.Core.Aplication.Features.Queries.GetAuthorById;
using CapacitacionDdd.Core.Infraestructure;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Hello, World!");
var services = new ServiceCollection();
var configuration = new ConfigurationBuilder().Build();
InfraestructureServiceContainer.ConfigureServices(services, configuration);

services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());

var servicesProvider = services.BuildServiceProvider();
var mediatr = servicesProvider.GetRequiredService<IMediator>();

GetAuthorByIdQuery getAuthorByIdQuery = new GetAuthorByIdQuery(1);
var result = await mediatr.Send(getAuthorByIdQuery);
Console.WriteLine("El Author encontrado por Id es: " + result.Name);

AddAuthorCommand addAuthorCommand = new AddAuthorCommand();
addAuthorCommand.Id = 3;
addAuthorCommand.Name = "Juan Leon Mera";
addAuthorCommand.Code = "A3";
addAuthorCommand.Country = "Ecuador";

var resultAdd = await mediatr.Send(addAuthorCommand);
Console.WriteLine("El Id de Author creado es: " + resultAdd);

UpdateAuthorCommand updateAuthorCommand = new UpdateAuthorCommand();
updateAuthorCommand.Id = 2;
updateAuthorCommand.Name = "Eugenio Espejo";
updateAuthorCommand.Code = "A2";
updateAuthorCommand.Country = "Ecuador";
await mediatr.Send(updateAuthorCommand);

GetAuthorByIdQuery getAuthorByIdQueryUpdate = new GetAuthorByIdQuery(2);
var resultUpdate = await mediatr.Send(getAuthorByIdQueryUpdate);
Console.WriteLine("El Author actualizado es: " + resultUpdate.Name);

GetAuthorByCodeQuery getAuthorByCodeQuery = new GetAuthorByCodeQuery("A2");
var resultCode = await mediatr.Send(getAuthorByCodeQuery);
Console.WriteLine("El Author encontrado por Codigo es: " + resultCode.Name);