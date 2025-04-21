# C# Reverse Proxy Load Balancer

A high-performance reverse proxy and load balancer built with C# and .NET.

## 🚀 Features

- Reverse proxy functionality
- Load balancing across multiple backend servers
- Health checks for backend servers
- Configurable routing rules
- High performance and low latency
- Easy configuration through JSON settings

## 🛠️ Technologies Used

- **YARP (Yet Another Reverse Proxy)**: For reverse proxy functionality
- **Redis**: For caching and session management
- **Docker**: For containerization (optional)

## 📋 Prerequisites

- .NET 6.0 or later
- Visual Studio 2022 or Visual Studio Code
- Git

## 🔧 Installation

1. Clone the repository:
```bash
git clone https://github.com/yourusername/csharp_reverse_proxy_loadbalancer.git
```

2. Navigate to the project directory:
```bash
cd csharp_reverse_proxy_loadbalancer
```

3. Restore dependencies:
```bash
dotnet restore
```

4. Build the project:
```bash
dotnet build
```

## ⚙️ Configuration

The application can be configured through the `appsettings.json` file. Here's an example configuration:

```json
{
  "ReverseProxy": {
    "Routes": {
      "route1": {
        "ClusterId": "cluster1",
        "Match": {
          "Path": "/api/{**catch-all}"
        }
      }
    },
    "Clusters": {
      "cluster1": {
        "Destinations": {
          "destination1": {
            "Address": "http://localhost:5001"
          },
          "destination2": {
            "Address": "http://localhost:5002"
          }
        }
      }
    }
  }
}
```

## 🚀 Running the Application

To run the application:

```bash
dotnet run
```

The reverse proxy will start and listen on the configured port (default: 5000).

## 📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🤝 Contributing

Contributions are welcome! Please feel free to submit a Pull Request.