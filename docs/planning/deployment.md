# Deployment Overview

Each API service is deployed to a different node.

## Deployment Workflow
```mermaid
sequenceDiagram
    participant Developer
    participant GitHub
    participant Webhook
    participant CI/CD
    participant API_Gateway
    participant API_Service1
    participant API_Service2
    participant API_Service3

    Developer->>GitHub: Push new code
    GitHub->>Webhook: Trigger webhook
    Webhook->>CI/CD: Starts deployment pipeline
    CI/CD->>API_Gateway: Deploy new API Gateway version
    CI/CD->>API_Service1: Deploy API Service 1
    CI/CD->>API_Service2: Deploy API Service 2
    CI/CD->>API_Service3: Deploy API Service 3
    API_Gateway->>Developer: API Gateway deployed
    API_Service1->>Developer: API Service 1 deployed
    API_Service2->>Developer: API Service 2 deployed
    API_Service3->>Developer: API Service 3 deployed
