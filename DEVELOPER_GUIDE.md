

# Pkcs11Admin Developer Guide

## Introduction

This guide provides information for developers who want to contribute to Pkcs11Admin or build it from source.

## Project Structure

The project is organized as follows:

```
Pkcs11Admin/
├── build/                # Build scripts and portable build configuration
│   ├── portable/         # Portable build scripts for cross-platform execution
├── src/                  # Source code
│   ├── Pkcs11Admin/      # Core library (PKCS#11 functionality)
│   ├── Pkcs11Admin.WinForms/  # WinForms GUI application
│   ├── lib/              # External dependencies (native libraries)
├── .gitignore            # Git ignore file
├── LICENSE               # Project license
├── README.md             # Project overview
└── DEVELOPER_GUIDE.md    # Developer documentation
```

## Building the Project

### Prerequisites

- Visual Studio 2019 or later
- .NET Framework 4.8 SDK

### Building with Visual Studio

1. Open the solution file: `src/Pkcs11Admin.sln`
2. Select your target platform (x86, x64, or AnyCPU)
3. Build the solution (F6 or Build > Build Solution)

### Building from Command Line

```bash
cd src
msbuild Pkcs11Admin.sln /p:Configuration=Release /p:Platform=x64
```

## Creating a Portable Build

Portable builds allow the application to run on different platforms (Windows, Linux, Mac) using Mono.

1. Navigate to the portable build directory:
   ```bash
   cd build/portable
   ```

2. Run the build script (Windows):
   ```bash
   build_portable_release.bat
   ```

3. The portable build will be created in `build/portable/Pkcs11Admin-Release`

## Code Structure

### Core Library (Pkcs11Admin)

The core library contains the main PKCS#11 functionality:

- **Configuration**: XML-based configuration for PKCS#11 attributes
- **Data Structures**: Classes representing PKCS#11 objects (slots, tokens, keys, certificates)
- **Operations**: Methods for performing PKCS#11 operations (key generation, certificate management, etc.)

### WinForms Application (Pkcs11Admin.WinForms)

The GUI application provides a user interface for managing PKCS#11 devices:

- **MainForm.cs**: Main application window
- **Dialogs/**: Various dialogs for different operations (key generation, certificate viewing, etc.)
- **Controls/**: Custom UI controls

## Configuration System

The application uses an XML-based configuration system to define PKCS#11 attributes and their behavior. The default configuration is located in `src/Pkcs11Admin/Configuration/`.

## Contributing

### Code Style

- Follow C# coding conventions
- Use meaningful variable and method names
- Add XML documentation for public methods

### Testing

Currently, the project lacks automated tests. Contributors are encouraged to add unit tests and integration tests.

### Adding New Features

1. Implement the feature in the core library
2. Add corresponding UI elements in the WinForms application
3. Update configuration files as needed
4. Add tests to verify the functionality

## Dependencies

The project uses several external libraries:

- **Pkcs11Interop**: PKCS#11 library for .NET
- **Portable.BouncyCastle**: Cryptography library
- **Asn1Net.Forms.TreeView**: ASN.1 viewer control
- **Be.Windows.Forms.HexBox**: Hex editor control

These are managed via NuGet PackageReference in the project files.

## Troubleshooting

### Common Issues

- **Missing dependencies**: Ensure all NuGet packages are restored
- **Platform targeting**: Make sure you're building for the correct platform (x86, x64, AnyCPU)
- **Mono compatibility**: Test with Mono if targeting non-Windows platforms

### Debugging

Use Visual Studio's debugging tools to diagnose issues. Set breakpoints and use the immediate window to inspect variables.

## License

This project is licensed under the MIT License. See the LICENSE file for details.

