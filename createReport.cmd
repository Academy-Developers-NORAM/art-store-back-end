rmdir /q /s ArtStoreBackendTests\TestResults
dotnet test --no-build --collect:"XPlat Code Coverage"
reportgenerator "-reports:ArtStoreBackendTests\TestResults\*\*.xml" "-targetdir:reports\badges" "-reporttypes:badges"
move reports\badges\badge_combined.svg reports
rmdir /q /s reports\badges