# 網羅率(Coverage)や分岐網羅率(Branch Coverage)が高くなってもテストの品質が向上しない例

> [!WARNING]
> 以下のケースは関係ないhtmlファイルが生成されるが，カバレッジ等は0になっていることに注意。

## 通常ケース

- Coverage: 80%
- Branch Coverage: 50%

```shell
cd /app/UnitTestStudy && dotnet test --filter "FullyQualifiedName~UnitTestStudyTests" --collect:"XPlat Code Coverage" --results-directory:"TestResults/NormalTests"
cd /app/UnitTestStudy && reportgenerator -reports:"TestResults/NormalTests/*/coverage.cobertura.xml" -targetdir:"coveragereport-normal" -reporttypes:Html
```

---

## Coverageが高くてもテストの品質が向上しない例

- Coverage: 100%
- Branch Coverage: 50%

```shell
cd /app/UnitTestStudy && dotnet test --filter "FullyQualifiedName~UnitTestStudyCoverageFixTests" --collect:"XPlat Code Coverage" --results-directory:"TestResults/CoverageFixTests"
cd /app/UnitTestStudy && reportgenerator -reports:"TestResults/CoverageFixTests/*/coverage.cobertura.xml" -targetdir:"coveragereport-fix" -reporttypes:Html
```

---

## 分岐網羅率(Branch Coverage)が高くてもテストの品質が向上しない例

- Coverage: 100%
- Branch Coverage: 100%

```shell
cd /app/UnitTestStudy && dotnet test --filter "FullyQualifiedName~StringHelperBranchCoverageFixTests" --collect:"XPlat Code Coverage" --results-directory:"TestResults/BranchCoverageTests"
cd /app/UnitTestStudy && reportgenerator -reports:"TestResults/BranchCoverageTests/*/coverage.cobertura.xml" -targetdir:"coveragereport-branch" -reporttypes:Html
```
