# Testing

Simple ASP.NET Core Web API built with .NET 8.

## Endpoints

- `GET /` — basic info
- `GET /health` — health check
- `GET /api/greetings/{name}` — greeting endpoint

## Run locally

```bash
dotnet restore HelloTesting.sln
dotnet run --project src/HelloTesting/HelloTesting.csproj
```

## Publish

```bash
dotnet publish src/HelloTesting/HelloTesting.csproj -c Release -o publish
```

flowchart LR
    subgraph Developer
        A[Edit code locally]
        B[Create branch]
        C[Commit changes]
        D[Push branch]
        E[Open or update PR]
    end

    subgraph GitHub_Repository
        F[Pull Request event]
    end

    subgraph AI_PR_Review_Workflow
        G[Collect changed files and diff]
        H[Send diff to AI reviewer]
        I[AI returns summary, confidence, severity, findings]
        J[Normalize findings with workflow policy]
        K{Final verdict}
    end

    subgraph PR_Result
        L[Comment on PR]
        M[Add automerge label]
        N[Fail workflow]
        O[Mark as manual review]
    end

    subgraph Automerge_Workflow
        P[Check required status checks]
        Q[Merge PR automatically]
    end

    subgraph Telegram_Notify
        R[Send PR review update]
        S[Send merge update]
    end

    A --> B --> C --> D --> E --> F --> G --> H --> I --> J --> K

    K -->|PASS| L
    K -->|PASS| M
    K -->|REQUEST_CHANGES| L
    K -->|REQUEST_CHANGES| N
    K -->|MANUAL_REVIEW| L
    K -->|MANUAL_REVIEW| O

    M --> P --> Q --> S
    L --> R
    N --> R
    O --> R

