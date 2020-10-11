dotnet test --collect:"XPlat Code Coverage"
reportgenerator "-reports:./**/coverage.cobertura.xml" "-targetdir:./coverage" "-reporttypes:Html"
start chrome ./coverage/index.html