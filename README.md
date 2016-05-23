### Introduction

This is an [ASP.NET Core 1.0 RC2](http://www.dot.net) application written as an example of how to do a few basic things with it. Included are instructions to create a postgres docker container which is populated with the [Microsoft Adventure Works 2016 database](https://www.microsoft.com/en-us/download/details.aspx?id=49502).

Inside the app are detailed comments explaining the various pieces of ASP.NET Core, like [tag helpers](https://docs.asp.net/en/latest/mvc/views/tag-helpers/index.html) and [routing](https://docs.asp.net/en/latest/fundamentals/routing.html).

### Getting Started

#### Adventure Works Postgres (docker container)

To start, you'll need to create the docker container for the Adventure Works postgres database. This only contains a subset of the actual Adventure Works database, specifically the HumanResources schema. To do this, you'll first need to [install docker](https://docs.docker.com/engine/installation). Once docker is installed, go to the `dockerfiles/adventureworks` directory and perform the following commands:

```
$ cd dockerfiles/adventureworks
$ docker build -t adventure-works-postgres .
$ docker run -d --name adventure-works adventure-works-postgres
```

The Adventure Works database should now be running.

#### AW_CONNSTRING Environment Variable

The application uses an environment variable to get the connection string. First, you'll need to find the postgres container's IP address. This can be done by:

`$ docker inspect adventure-works | grep -i ipaddr`

Once you have the IP address, you can set the `AW_CONNSTRING` environment variable with the `export` command:

`$ export AW_CONNSTRING="Server=IP_ADDRESS;Username=awuser;Password=redhat;Database=adventureworks"`

#### Running the application

Now it's time to run the application. Once you've installed dotnet and ASP.NET Core 1.0 RC2, run the following commands:

```
$ dotnet restore
$ dotnet run
```

You can then browse to the application in your browser at http://localhost:5000.
