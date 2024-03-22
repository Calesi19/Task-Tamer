# Task Tamer

A simple to do list api to practice creating a .NET Web API.

# How to run the project

## Setup the database.

1. Install Docker
2. Create a Docker account.
3. Run the following command to start a Postgres container.
```bash
docker run --name tasktamer -p 5432:5432 -e POSTGRES_PASSWORD=task123 -e POSTGRES_USER=tamer -e POSTGRES_DB=task_tamer -d postgres
```

## Setup the API
1. Clone the project
```bash
git clone https://github.com/Calesi19/FaveFinder.git
```

2. Install the dependencies
```bash
dotnet restore
```

3. Run the project
```bash
dotnet run
```

4. Open your browser and go to `http://localhost:5000`

# Create and Run a Docker Image

1. Create the image with the code by running the following command:
```bash
docker build -t tasktamer .
```
2. Run the docker image by running the command:
```bash
docker run -p 8080:8080 -p 8081:8081 tasktamer
```



# Packages

* Microsoft.EntityFrameworkCore
* Npgsql.EntityFrameworkCore.PostgreSQL

# Managing Packages

You can install/remove a package by running the following commands:
```bash
# To install a package
dotnet add package <package-name>

# To update a package
dotnet add package <package-name> --version <new-version>

# To remove a package
dotnet remove package <package-name>

```

# Run Migrations

Once a model has been created and added to the DataAccess class, run the following migration commands on the terminal to create the tables in the database.

```bash
dotnet ef migrations add <Nameofthemigration>
dotnet ef database update
```
Replace <Nameofthemigration> with a name you'd like to give your migration. Don't use spaces.


# Helpful Resources

* [Postgres Setup with .NET Entity Framework](https://www.youtube.com/watch?v=z7G6HV7WWz0)