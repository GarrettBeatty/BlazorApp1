# BlazorApp1 with .NET Aspire Integration

This project demonstrates how to integrate a Blazor Server application with .NET Aspire for enhanced observability, service discovery, and orchestration capabilities.

## Project Structure

- **BlazorApp1**: The main Blazor Server application with Aspire service defaults integrated
- **BlazorApp1.ServiceDefaults**: Shared configuration for telemetry, health checks, and service discovery
- **BlazorApp1.AppHost**: Aspire orchestration host for local development (requires full Aspire tooling)

## What's Included

### Observability
- **OpenTelemetry Integration**: Automatic metrics, tracing, and logging
- **Health Checks**: Built-in health endpoints at `/health` and `/alive`
- **Service Discovery**: Ready for microservices communication

### Service Defaults
The ServiceDefaults project provides:
- OpenTelemetry configuration with ASP.NET Core, HTTP, and Runtime instrumentation
- Health check endpoints
- OTLP exporter support for external observability platforms
- Service discovery configuration

### Configuration
- `OTEL_SERVICE_NAME`: Service name for telemetry
- `OTEL_SERVICE_VERSION`: Service version for telemetry
- `OTEL_EXPORTER_OTLP_ENDPOINT`: Optional OTLP endpoint for external systems

## Running the Application

### Option 1: Run Blazor App Directly (Recommended for this environment)
```bash
cd BlazorApp1
dotnet run
```

### Option 2: Run with Aspire Orchestration (Requires full Aspire tooling)
```bash
cd BlazorApp1.AppHost
dotnet run
```

## Endpoints

When running, the application provides:
- Main application: `http://localhost:5009` (or configured port)
- Health check: `http://localhost:5009/health`
- Alive check: `http://localhost:5009/alive`

## Benefits of Aspire Integration

1. **Enhanced Observability**: Automatic telemetry collection and export
2. **Health Monitoring**: Built-in health check endpoints
3. **Service Discovery**: Ready for microservices architecture
4. **Development Experience**: Orchestration and dependency management
5. **Production Ready**: Standardized configuration and monitoring

## Dependencies

- .NET 8.0
- Aspire.Hosting package
- OpenTelemetry packages for observability
- Microsoft.Extensions.ServiceDiscovery for service discovery

The integration is minimal and non-intrusive, adding powerful capabilities while maintaining the existing application structure.