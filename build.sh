#!/bin/bash
set -ev
dotnet restore
dotnet build src/IterationZero.Core.sln