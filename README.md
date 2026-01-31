# WSA GPS Bridge (WIP)

🚧 **Project Under Active Development** 🚧

**WSA GPS Bridge** is an engineering project aiming to provide a reliable hardware-to-software bridge between GNSS Serial Modems (Dell Rugged, Getac, Panasonic Toughbook) and the Windows Subsystem for Android (WSA).

## 🎯 Goals

- Enable native GPS navigation (OsmAnd, Google Maps) inside WSA containers.
- Provide a robust, failure-resistant NMEA stream via UDP.

## 🛠️ Architecture

The project is designed using **Domain-Driven Design (DDD)** and **Clean Architecture** principles:

- **Core:** Domain entities and Use Cases (Pure C#).
- **Infrastructure:** Adapters for Serial Ports and Network Sockets.
- **Tests:** TDD approach using NUnit.

## 📅 Roadmap

- [x] Project Initialization & CI Setup
- [x] Domain Logic (NMEA Parsing & Validation)
- [ ] Application Layer (Use Cases)
- [ ] Infrastructure (Serial & UDP Adapters)
- [ ] CLI Entry Point

## 🤝 Contributing

This project is currently in early stages. Contributions will be welcome once the core architecture is stabilized.

## ⚖️ License & Usage

This project is released under the **PolyForm Noncommercial License 1.0.0**.

- ✅ **Free for personal use:** You can use it on your own device for free.
- ❌ **No Commercial Use:** Companies cannot use, sell, or integrate this code without permission.
- 🤖 **No AI Training:** This code cannot be used to train AI models.

See the `LICENSE` file for full details.