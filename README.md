

Pkcs11Admin
===========

GUI tool for administration of PKCS#11 enabled devices

## Overview

Pkcs11Admin is a comprehensive management tool for PKCS#11 enabled cryptographic devices such as smart cards and hardware security modules (HSMs). It provides a graphical interface to perform various cryptographic operations and manage digital certificates, keys, and other objects stored on PKCS#11 compliant devices.

## Features

- **Device Management**: Connect to and manage PKCS#11 devices
- **Key Management**: Generate, import, export, and manage cryptographic keys
- **Certificate Management**: View and manage X.509 certificates
- **CSR Generation**: Create Certificate Signing Requests (CSRs) for CA enrollment
- **Data Objects**: Import, export, and manage arbitrary data objects
- **Security Operations**: Change PIN, initialize tokens, and perform protected authentication
- **Vulnerability Testing**: Test for known vulnerabilities like ROCA (CVE-2017-15361)

## Requirements

- .NET Framework 4.8
- Windows operating system (or Mono for Linux/Mac)
- PKCS#11 compliant device and its library

## Building from Source

### Prerequisites

- Visual Studio 2019 or later
- .NET Framework 4.8 SDK

### Build Instructions

1. Open the solution file `src/Pkcs11Admin.sln` in Visual Studio
2. Build the solution for your target platform (x86, x64, or AnyCPU)
3. The executable will be located in the `bin/<platform>/<configuration>` directory

### Portable Build

For cross-platform execution, you can create a portable build:

1. Navigate to the `build/portable` directory
2. Run `build_portable_release.bat` (Windows) or use the shell scripts for Linux/Mac
3. The portable build will be created in `build/portable/Pkcs11Admin-Release`

## Usage

1. Launch the application
2. Load a PKCS#11 library via the Library Loading dialog
3. Connect to a slot/token
4. Perform authentication with the token's PIN
5. Browse and manage objects stored on the device

## Configuration

The application uses an XML configuration file to define PKCS#11 attributes and their behavior. The default configuration is located in the `src/Pkcs11Admin/Configuration` directory.

## Known Issues and Roadmap

Please see `src/ISSUES.txt` for a list of known issues and planned features.

## License

This project is licensed under the MIT License. See the LICENSE file for details.

## Project Website

Please visit [pkcs11admin.net](http://www.pkcs11admin.net) for more information and updates.

