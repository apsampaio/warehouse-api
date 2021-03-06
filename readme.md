# ๐ Notes

### ๐ Creating Project:

```shell
dotnet new webapi -n Warehouse
```

### ๐ Running Project:

```shell
dotnet run
```

### ๐งจ Fixing **_NU1100_** Error:

```shell
dotnet nuget add source https://api.nuget.org/v3/index.json
```

### ๐ช SQLite Package

```shell
dotnet add package Microsoft.Data.Sqlite
```

# ๐ฃ Steps

- [x] Create Project
- [x] Configure Debugging Settings
- [x] Create Entities
- [x] Create Repositories
- [x] Add Database
  - [x] Add Packages (EntityFrameworkCore, EntityFrameworkCore.Sqlite, Microsoft.Data.Sqlite)
  - [x] Create Context
  - [x] Add Service to Startup
- [x] Create Controllers
  - [x] CreateItem
  - [x] GetItems
  - [x] GetItem
  - [x] UpdateItem
  - [x] DeleteItem
- [ ] Create Tests
- [ ] Create Logging
- [ ] Update Routes Params โจ
- [ ] Deploy
