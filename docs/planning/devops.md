# DevOps Pipeline

This document outlines how the CI/CD pipeline automates deployments.

## CI/CD Workflow
```mermaid
flowchart LR
    A[GitHub Push] --> B[Webhook Trigger]
    B --> C[CI/CD Pipeline]
    C -->|Builds & Tests| D[Docker Image]
    D -->|Deploys| E[API Gateway]
    D -->|Deploys| F[API Service 1]
    D -->|Deploys| G[API Service 2]
    D -->|Deploys| H[API Service 3]
    E -->|Running on| P1
    F -->|Running on| P2
    G -->|Running on| P3
    H -->|Running on| O1
