# Softheon Wallet API
> see https://aka.ms/autorest

## Getting Started 
To build the SDKs for My API, simply install AutoRest via `npm` (`npm install -g autorest`) and then run:
> `autorest readme.md`

To see additional help and options, run:
> `autorest --help`

For other options on installation see [Installing AutoRest](https://aka.ms/autorest/install) on the AutoRest github page.
---
## Configuration
```yaml
input-file: 
  - wallet_api_v2.json

csharp:
  - output-folder: CSharp
    add-credentials: true
    namespace: Softheon.Wallet.Api.Client
    use-datetimeoffset: true
    
ruby:
  - output-folder: Ruby
 
go:
  - output-folder: Go
  
java:
  - output-folder: Java
  
nodejs:
  - output-folder: NodeJS
  
typescript:
  - output-folder: TypeScript
    package-name: Softheon.Wallet.Api.Client
    package-version: 2
  
python:
  - output-folder: Python
    namespace: Softheon.Wallet.Api.Client
    package-name: Softheon.Wallet.Api.Client
    add-credentials: true
  
php:
  - output-folder: PHP
```