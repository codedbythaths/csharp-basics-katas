#!/usr/bin/env bash
set -euo pipefail

if [ $# -ne 2 ]; then
  echo "Usage: $0 <path> <ProjectName>"
  echo "Example: $0 part01_fundamentals/04_control_flow ControlFlow"
  exit 1
fi

path="$1"          # e.g., part01_fundamentals/04_control_flow
proj="$2"          # e.g., ControlFlow
testproj="${proj}.Tests"

mkdir -p "$path/src" "$path/tests"

dotnet new classlib -n "$proj"       -o "$path/src"
dotnet new nunit     -n "$testproj"  -o "$path/tests"

dotnet sln CSharpBasicsKatas.sln add "$path/src/$proj.csproj"
dotnet sln CSharpBasicsKatas.sln add "$path/tests/$testproj.csproj"

dotnet add "$path/tests/$testproj.csproj" reference "$path/src/$proj.csproj"

echo "✅ $proj scaffolded in $path"
