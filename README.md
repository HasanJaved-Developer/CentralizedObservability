# 🛰️ Centralized Observability Platform

[![Build](https://github.com/hasanjaved-developer/CentralizedObservability/actions/workflows/dotnet-tests.yml/badge.svg?branch=master)](https://github.com/hasanjaved-developer/CentralizedObservability/actions/workflows/dotnet-tests.yml)
[![codecov](https://codecov.io/gh/hasanjaved-developer/CentralizedObservability/branch/master/graph/badge.svg)](https://codecov.io/gh/hasanjaved-developer/CentralizedObservability)
[![Docker Compose CI](https://github.com/hasanjaved-developer/CentralizedObservability/actions/workflows/docker-compose-ci.yml/badge.svg)](https://github.com/<OWNER>/<REPO>/actions/workflows/docker-compose-ci.yml)
[![License](https://img.shields.io/github/license/hasanjaved-developer/CentralizedObservability)](LICENSE.txt)
[![Release](https://img.shields.io/github/v/tag/hasanjaved-developer/CentralizedObservability?label=release&sort=semver)](https://github.com/hasanjaved-developer/CentralizedObservability/tags)
[![GHCR api](https://img.shields.io/badge/ghcr.io-centralized--logging%2Fapi-blue?logo=github)](https://ghcr.io/hasanjaved-developer/centralized-observability/api)
[![GHCR userapi](https://img.shields.io/badge/ghcr.io-centralized--logging%2Fuserapi-blue?logo=github)](https://ghcr.io/hasanjaved-developer/centralized-observability/userapi)
[![GHCR web](https://img.shields.io/badge/ghcr.io-centralized--logging%2Fweb-blue?logo=github)](https://ghcr.io/hasanjaved-developer/centralized-observability/web)

### 🐳 Docker Hub Images

| Service | Pulls | Size | Version |
|----------|-------|------|----------|
| **API** | [![Pulls](https://img.shields.io/docker/pulls/hasanjaveddeveloper/centralized-observability-api)](https://hub.docker.com/r/hasanjaveddeveloper/centralized-observability-api) | [![Size](https://img.shields.io/docker/image-size/hasanjaveddeveloper/centralized-observability-api/latest)](https://hub.docker.com/r/hasanjaveddeveloper/centralized-observability-api/tags) | [![Version](https://img.shields.io/docker/v/hasanjaveddeveloper/centralized-observability-api?sort=semver)](https://hub.docker.com/r/hasanjaveddeveloper/centralized-observability-api/tags) |
| **User API** | [![Pulls](https://img.shields.io/docker/pulls/hasanjaveddeveloper/centralized-observability-userapi)](https://hub.docker.com/r/hasanjaveddeveloper/centralized-observability-userapi) | [![Size](https://img.shields.io/docker/image-size/hasanjaveddeveloper/centralized-observability-userapi/latest)](https://hub.docker.com/r/hasanjaveddeveloper/centralized-observability-userapi/tags) | [![Version](https://img.shields.io/docker/v/hasanjaveddeveloper/centralized-observability-userapi?sort=semver)](https://hub.docker.com/r/hasanjaveddeveloper/centralized-observability-userapi/tags) |
| **Web (Portal)** | [![Pulls](https://img.shields.io/docker/pulls/hasanjaveddeveloper/centralized-observability-web)](https://hub.docker.com/r/hasanjaveddeveloper/centralized-observability-web) | [![Size](https://img.shields.io/docker/image-size/hasanjaveddeveloper/centralized-observability-web/latest)](https://hub.docker.com/r/hasanjaveddeveloper/centralized-observability-web/tags) | [![Version](https://img.shields.io/docker/v/hasanjaveddeveloper/centralized-observability-web?sort=semver)](https://hub.docker.com/r/hasanjaveddeveloper/centralized-observability-web/tags) |

The Centralized Observability Platform is a proof-of-concept built with .NET 9, designed to demonstrate unified observability practices — combining structured logging (Serilog), distributed tracing (Jaeger via OpenTelemetry), and future support for metrics.

The project extends the earlier Centralized Logging & Monitoring API to include full-fledged trace visualization and request correlation across microservices, enabling end-to-end visibility into system behavior and performance.

CI/CD pipelines with GitHub Actions, multi-arch Docker images, and environment-ready compose stacks make this project a production-grade observability showcase for modern .NET solutions.

---

## 🧭 Overview

The **Centralized Observability Platform** is a modern observability showcase built with **.NET 9**, combining structured logging, distributed tracing, and visualization into one cohesive stack.

It extends the earlier **Centralized Logging & Monitoring API** project with:
- ✅ **Serilog** for structured logging  
- 🟣 **Jaeger (via OpenTelemetry)** for distributed tracing  
- 🧩 **Docker Compose stack** for local observability setup  
- 🚀 **GitHub Actions CI/CD** for multi-arch image builds and releases  
- 📊 **Codecov** integration for coverage insights  

---

## 🧱 Tech Stack

| Category | Technology | Description |
|-----------|-------------|-------------|
| **Framework** | [.NET 9](https://dotnet.microsoft.com/) | Latest LTS runtime |
| **Logging** | [Serilog](https://serilog.net/) | Structured logs with enrichment and sinks |
| **Tracing** | [Jaeger](https://www.jaegertracing.io/) + [OpenTelemetry](https://opentelemetry.io/) | Distributed trace instrumentation |
| **Containerization** | [Docker Compose](https://docs.docker.com/compose/) | Multi-service orchestration |
| **CI/CD** | [GitHub Actions](https://github.com/features/actions) | Automated build, test, and publish pipelines |
| **Code Coverage** | [Codecov](https://about.codecov.io/) | Visual test coverage tracking |
| **Package Registry** | [GHCR](https://ghcr.io) + [Docker Hub](https://hub.docker.com/) | Public image hosting |

---

## 🧩 Architecture Snapshot
*(To be added later — include a Mermaid diagram showing Serilog → OpenTelemetry → Jaeger → UI)*

---

## 🔍 Quick Start (Preview)

```bash
# Clone the repository
git clone https://github.com/hasanjaved-developer/centralized-observability.git
cd centralized-observability

# Start the observability stack
docker compose -f docker-compose.yml up -d
```
---

## 📜 License

This project is licensed under the MIT License.

---
