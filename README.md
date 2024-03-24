
### Code Coverage

```
dotnet test --collect:"XPlat Code Coverage"
```

```
reportgenerator \
-reports:"${pwd}/tests/RLee.UnitTests/TestResults/eca9c526-bcfd-424e-a819-4a4b60fc130d/coverage.cobertura.xml" \
-targetdir:"coveragereport" \
-reporttypes:Html
```