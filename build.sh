#!/bin/bash
set -ev
dotnet restore src/IterationZero.Core.sln
dotnet build src/IterationZero.Core.sln