# Transpargo – Full Stack Logistics & Compliance Platform

## About Transpargo

Transpargo is a full-stack digital logistics and compliance platform designed to simplify international shipping, customs processes, and shipment tracking. It brings together shipment management, regulatory guidance, tariff estimation, and role-based workflows into a single, unified system.

The platform addresses key challenges in global trade such as regulatory complexity, document uncertainty, cost unpredictability, and lack of shipment visibility. By centralizing frontend user interactions and backend business logic within one integrated solution, Transpargo improves transparency, reduces delays, and enables informed decision-making across the entire shipment lifecycle.

This repository contains both the frontend and backend applications, developed to work seamlessly together as a scalable, modular, and secure system.

---

## Project Overview

Transpargo is a comprehensive logistics platform that simplifies international shipping, customs compliance, and shipment lifecycle management. The system is built with a clear separation of concerns between frontend and backend while being maintained in a single repository for easier development, deployment, and collaboration.

The platform serves:
- Exporters
- Shipping agencies
- Administrators

by providing a structured, reliable, and intuitive digital interface backed by secure and scalable APIs.

---

## Key Capabilities

### Shipment Management
- End-to-end shipment creation and tracking  
- Clear sender and receiver timelines  
- Real-time status updates across shipment stages  

### Compliance & Documentation
- Guided customs documentation workflows  
- Document upload and verification support  
- Risk awareness to reduce customs delays and holds  

### Tariff & Cost Intelligence
- Duty and tariff estimation before shipment  
- Cost visibility for better planning and decision-making  

### AI-Assisted Support
- Intelligent assistance for operational queries  
- Guidance on compliance, shipment steps, and risk factors  

### Dangerous Goods Compliance & Visualization
- Interactive 3D dangerous goods packing visualizer that demonstrates UN-compliant packaging layers and handling requirements for hazardous cargo.
- Automated generation of hazard labels and handling labels in accordance with UN/IATA dangerous goods guidelines, reducing manual errors and improving regulatory compliance.
---

## Role-Based Access & Security

Transpargo is built with role-based access control (RBAC) to ensure users see only what is relevant to their responsibilities.

### Supported Roles
- Customers (exporters/importers)
- Shipping agencies
- Administrators

### Security Features
- Token-based authentication (JWT)
- Secure protected routes
- Role-aware navigation and API access
- Session persistence

---

## System Architecture

### Frontend
- Acts as the primary user interface
- Provides dashboards, shipment tracking, and document workflows
- Communicates securely with backend APIs
- Designed for clarity, usability, and scalability

### Backend
- Serves as the core business logic layer
- Handles authentication, authorization, and data integrity
- Manages shipment lifecycle, logs, and documents
- Provides secure REST APIs consumed by the frontend
- Designed to be modular and extensible for future integrations

---

## Repository Structure

```text
Transpargo/
│
├── Frontend/               
│   ├── src/
│   ├── public/
│   ├── eslint.config.js
│   ├── index.html
│   ├── package.json
│   ├── vite.config.js
│   └── README.md
│
├── Backend/                
│   ├── Transpargo/          
│   │   ├── Controllers/
│   │   ├── Services/
│   │   ├── Models/
│   │   ├── Interfaces/
│   │   ├── Helpers/
│   │   ├── Config/
│   │   ├── Program.cs
│   │   └── Transpargo.csproj
│   │
│   └── Transpargo.sln       
│
├── .gitignore               # Git ignore rules
├── README.md                # Project documentation
```
## Integration & Communication

The frontend and backend communicate via well-defined REST APIs supporting:

- Authentication and authorization  
- Shipment creation and updates  
- Document upload and verification  
- Notifications and status communication  
- Payment and billing interactions  

The modular design allows independent scaling of frontend and backend components while maintaining a cohesive system.

---

## Deployment

### Frontend Deployment (AWS S3)

The frontend is deployed as a static web application using **AWS S3**.

**Live Application:**  
🔗 http://transpargo-frontend.s3-website.ap-south-1.amazonaws.com

### Backend Deployment

The backend powers all business logic and securely serves the frontend through APIs.  
It is designed for deployment on cloud infrastructure such as **AWS EC2**, supporting secure configuration, scalability, and future integrations.

---

## Purpose & Vision

Transpargo aims to transform complex logistics and compliance workflows into a streamlined digital experience. By combining shipment operations, regulatory intelligence, and real-time visibility into a single platform, it helps users ship with confidence, clarity, and operational efficiency.

The system is designed with future growth in mind, allowing easy expansion into:

- Advanced compliance automation  
- Deeper analytics and reporting  
- Third-party logistics and customs integrations  
