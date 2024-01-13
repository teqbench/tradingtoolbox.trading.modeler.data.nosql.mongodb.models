# Trading Modeler MongoDB Models

![Build Status Badge](.badges/build-status.svg) ![Build Number Badge](.badges/build-number.svg) ![Coverage](.badges/code-coverage.svg)

## Overview

Trade Position Modeler domain models for MongoDB.

## Contents
- [Developer Environment Setup](#Developer+Environment+Setup)
- [Usage](#Usage)
- [License](#License)

## Developer Environment Setup

### General
- [Branching Strategy & Practices](https://github.com/teqbench/teqbench.docs/wiki/Branching-Strategy)

### .NET
- [General Tooling](https://github.com/teqbench/teqbench.docs/wiki/.NET-General-Tooling)
- [Configurations](https://github.com/teqbench/teqbench.docs/wiki/.NET-Configuration-Standards)
- [Coding Standards](https://github.com/teqbench/teqbench.docs/wiki/.NET-Coding-Standards)
- [Solutions](https://github.com/teqbench/teqbench.docs/wiki/.NET-Solutions)
- [Projects](https://github.com/teqbench/teqbench.docs/wiki/.NET-Projects)
- [Building](https://github.com/teqbench/teqbench.docs/wiki/.NET-Build-Process)
- [Packing & Deploying NuGet Package](#)
- [Versioning](https://github.com/teqbench/teqbench.docs/wiki/.NET-Versioning-Standards)

## Usage

### Add NuGet Package To Project

```
dotnet add package TradingToolbox.Trading.Modeler.Data.NoSql.MongoDB.Models
```

### Update Source Code

> [!NOTE]
> For complete usage, see [TradingToolbox.Trading.Modeler.Data.NoSql.MongoDB.Services](https://github.com/teqbench/tradingtoolbox.trading.modeler.data.nosql.mongodb.services)

```csharp
/// <summary>
/// Position model respository interface for position model documents.
/// </summary>
/// <seealso cref="IRepository{Models}" />
public interface IPositionModelRepository : IRepository<PositionModelDocument>
{
    // NOTE: using the generic IRepository interface from TeqBench.System.Data.NoSql.MongoDB.Repsitory
    // allows the implementing interface/class to specify a different data type for the underlying document
    // this repository to work with.
}

/// <summary>
/// Position model respository for position model documents.
/// </summary>
/// <seealso cref="TeqBench.System.Data.NoSql.MongoDB.Repsitory{PositionModelDocument}" />
/// <seealso cref="IPositionModelRepository" />
public class PositionModelRepository : Repository<PositionModelDocument>, IPositionModelRepository
{
    // NOTE: Concrete implementation of document respository for a PositionModelDocument.
}
```

## Licensing

[License](https://github.com/teqbench/teqbench.docs/wiki/License)
