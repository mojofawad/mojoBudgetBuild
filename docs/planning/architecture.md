# System Architecture

This document describes the high-level architecture of the self-hosted system.

## Overall Architecture
```mermaid
graph TD
    subgraph "Infrastructure"
        P1["Raspberry Pi #1 (API Gateway)"]
        P2["Raspberry Pi #2 (API Service 1)"]
        P3["Raspberry Pi #3 (API Service 2)"]
        O1["Optiplex (API Service 3)"]
    end

    subgraph "GitHub"
        GH["GitHub Repository"]
    end

    subgraph "Deployment Pipeline"
        WH["GitHub Webhook"]
        CD["CI/CD Deployment"]
    end

    GH -->|Push Event| WH
    WH -->|Triggers| CD
    CD -->|Deploys| P1
    CD -->|Deploys| P2
    CD -->|Deploys| P3
    CD -->|Deploys| O1

    subgraph "Network Flow"
        API["Clients (Users)"]
        API -->|Requests| P1
        P1 -->|Routes to| P2
        P1 -->|Routes to| P3
        P1 -->|Routes to| O1
    end
