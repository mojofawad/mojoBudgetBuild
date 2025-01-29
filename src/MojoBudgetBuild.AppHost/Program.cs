var builder = DistributedApplication.CreateBuilder(args);

var serviceOne = builder.AddProject<Projects.MojoBudgetBuild_Service1>("service1");
var serviceTwo = builder.AddProject<Projects.MojoBudgetBuild_Service2>("service2");
var serviceThree = builder.AddProject<Projects.MojoBudgetBuild_Service3>("service3");

var gateway = builder.AddProject<Projects.MojoBudgetBuild_Gateway>("gateway")
    .WithExternalHttpEndpoints()
    .WithReference(serviceOne)
    .WithReference(serviceTwo)
    .WithReference(serviceThree);

builder.AddProject<Projects.MojoBudgetBuild_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(gateway)
    .WaitFor(gateway);

builder.Build().Run();
