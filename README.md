# gRPC Service with .NET 7

In this project we build a gRPC service with 5 methods: Create, Read (single), List (multiple), Update and Delete. We then employ JSON transcoding (a new feature added in .NET 7) to allow our gRPC service to act as a REST based API. This allows web-based endpoints to consume our service, while at the same time continuing to allow native gRPC clients to consume as well.

### General picture

- general picture of grpc
<img src="/pictures/grpc.png" title="general picture of grpc"  width="900">


### Create Project
<img src="/pictures/create_project.png" title="create project"  width="900">

