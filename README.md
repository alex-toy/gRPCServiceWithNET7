# gRPC Service with .NET 7

In this project we build a gRPC service with 5 methods: Create, Read (single), List (multiple), Update and Delete. We then employ JSON transcoding (a new feature added in .NET 7) to allow our gRPC service to act as a REST based API. This allows web-based endpoints to consume our service, while at the same time continuing to allow native gRPC clients to consume as well.

### General picture

- general picture of grpc
<img src="/pictures/grpc.png" title="general picture of grpc"  width="900">


### Initial settings

- create Project
<img src="/pictures/create_project.png" title="create project"  width="900">

- install packages
```
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.design
Grpc.Tools
```

CAUTION : anytime you modify the protobuf files, yo need to rebuild the project.

- in **Postman**, choose **grpc**
<img src="/pictures/postman.png" title="postman"  width="900">

- enable TLS
<img src="/pictures/postman2.png" title="postman"  width="900">

- import a proto file
<img src="/pictures/postman3.png" title="postman"  width="900">

- create a new service definition
<img src="/pictures/postman4.png" title="postman"  width="900">
<img src="/pictures/postman5.png" title="postman"  width="900">

- choose method
<img src="/pictures/postman6.png" title="postman"  width="900">

- finally use the service
<img src="/pictures/postman7.png" title="postman"  width="900">
