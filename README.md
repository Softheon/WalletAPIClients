# WalletAPIClients
A collection of libraries for the Softheon Wallet API.  Client libraries are available in the following languages:
* [C#](https://github.com/Softheon/WalletAPIClients/tree/master/CSharp)
* [Go](https://github.com/Softheon/WalletAPIClients/tree/master/Go)
* [Java](https://github.com/Softheon/WalletAPIClients/tree/master/Java)
* [Node.js](https://github.com/Softheon/WalletAPIClients/tree/master/NodeJS)
* [TypeScript](https://github.com/Softheon/WalletAPIClients/tree/master/TypeScript)
* [Python](https://github.com/Softheon/WalletAPIClients/tree/master/Python/softheon)
* [Ruby](https://github.com/Softheon/WalletAPIClients/tree/master/Ruby/generated)
* [PHP](https://github.com/Softheon/WalletAPIClients/tree/master/PHP/Softheon/Wallet/Api/Client)

To get started using the Softheon Wallet API, please visit https://hack.softheon.io.
Please also visit the [documentation site](https://hack.softheon.io/documentation/payments) for more information on how to use the
Softheon Wallet API.

## Overview
Client libraries are generated using the [AutoRest](https://github.com/Azure/autorest) open-source REST API client generation tool.  The
input to AutoRest is a spec file that describes the Softheon Wallet API using the [OpenAPI Specification](https://github.com/OAI/OpenAPI-Specification).
[Swashbuckle](https://github.com/domaindrivendev/Swashbuckle.AspNetCore) was used for spec file generation.

---
## Getting Started
The SDK for each language includes all request and response models used by the Softheon Wallet API, as well as methods covering all types
of interaction with the Softheon Wallet API.  To get started using the client libraries, create a project using your IDE of choice and import
the files under your selected languge into your project.

### C# Client Example
For an example on how to use C# generated client, please refer to the [AutoRest C# client documentation](https://github.com/Azure/autorest/tree/master/docs/client).

### Client Runtimes
Some languages requrie additional client runtimes in order to use these libraries. Information on required client runtimes can be found in the 
[AutoRest client runtime documentation](https://github.com/Azure/autorest/blob/master/docs/developer/architecture/Autorest-and-Clientruntimes.md).

---

## Acknowledgements
The Softheon Wallet API client libraries are built using the following great open source projects
* [AutoRest](https://github.com/Azure/autorest)
* [Swashbuckle](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)
