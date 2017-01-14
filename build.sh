#!/bin/bash
set -ev
dotnet restore src/IterationZero.Core.sln
dotnet build src/IterationZero.Core.sln
dotnet test src/tests/IterationZero.Core.Tests.Unit/IterationZero.Core.Tests.Unit.csproj