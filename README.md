# CodeMQ

A simple example showing how to integrate RabbitMQ with an ASP.NET Web API.
Assuming that you've got docker installed and you've started the docker container for RabbitMQ as shown below
```
docker run -d --hostname my-rabbit --name my-rabbit -p 15672:15672 -p 5672:5672 rabbitmq:3-management
```

All we need to run this example is to run:

```
dotnet restore
dotnet run
```

