# API Gateway Routing

## Route Map
```mermaid
graph TD
    API_Gateway["API Gateway (RPi #1)"]
    API1["API Service 1 (RPi #2)"]
    API2["API Service 2 (RPi #3)"]
    API3["API Service 3 (Optiplex)"]

    API_Gateway -->|Route `/service1`| API1
    API_Gateway -->|Route `/service2`| API2
    API_Gateway -->|Route `/service3`| API3
