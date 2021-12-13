# 📝 Notes

### 🎉 Creating Project:

```shell
dotnet new webapi -n Warehouse
```

### 🚀 Running Project:

```shell
dotnet run
```

### 🧨 Fixing **_NU1100_** Error:

```shell
dotnet nuget add source https://api.nuget.org/v3/index.json
```

### 🪑 SQLite Package

```shell
dotnet add package Microsoft.Data.Sqlite
```

# 👣 Steps

- [x] Create Project
- [x] Configure Debugging Settings
- [x] Create Entities
- [x] Create Repositories
- [x] Add Database
  - [x] Add Packages (EntityFrameworkCore, EntityFrameworkCore.Sqlite, Microsoft.Data.Sqlite)
  - [x] Create Context
  - [x] Add Service to Startup
- [ ] Create Controllers
  - [x] CreateItem
  - [x] GetItems
  - [x] GetItem
  - [ ] UpdateItem
  - [ ] DeleteItem
- [ ] Create Tests
- [ ] Create Logging
- [ ] Deploy
