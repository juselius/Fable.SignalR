# Changelog

## [1.3.2](https://gitlab.com/oceanbox/Fable.SignalR/compare/v1.3.1...v1.3.2) (2024-08-09)


### Bug Fixes

* remove leftover redis argument in saturn application builder ([2d79096](https://gitlab.com/oceanbox/Fable.SignalR/commit/2d79096f51a203005c9a2fe864a88ecddba1e096))

## [1.3.1](https://gitlab.com/oceanbox/Fable.SignalR/compare/v1.3.0...v1.3.1) (2024-08-09)


### Bug Fixes

* fix package names to avoid version conflicts ([f2c7879](https://gitlab.com/oceanbox/Fable.SignalR/commit/f2c7879fe0efb68a88f6baff90aec5345ac081a1))

# [1.3.0](https://gitlab.com/oceanbox/Fable.SignalR/compare/v1.2.3...v1.3.0) (2024-08-08)


### Features

* add support redis backplane ([06e14d5](https://gitlab.com/oceanbox/Fable.SignalR/commit/06e14d5dc1643557ed14fbba99b41daedbf3d24f))
* get rid of paket which is causing a world of pain ([e9712dc](https://gitlab.com/oceanbox/Fable.SignalR/commit/e9712dc86dddf7b4a589e60d76a4e51f34cf4391))
* get rid of paket which is causing a world of pain (take 2) ([fd67a23](https://gitlab.com/oceanbox/Fable.SignalR/commit/fd67a235c8bdd6ebc9fa24dbfefeb3526afab81a))

## [1.2.3](https://gitlab.com/oceanbox/Fable.SignalR/compare/v1.2.2...v1.2.3) (2024-04-25)


### Bug Fixes

* fix usage of newer RecyclableMemoryStream ([45fc52b](https://gitlab.com/oceanbox/Fable.SignalR/commit/45fc52b51033ef656997c784f5bd3aa01e6b6f94))
* update dependencies for Fable 4 et al. ([fdad762](https://gitlab.com/oceanbox/Fable.SignalR/commit/fdad762351ef729dbb0fbce5e2d04be5c3ed7d65))

## [1.2.2](https://gitlab.com/oceanbox/Fable.SignalR/compare/v1.2.1...v1.2.2) (2024-04-23)


### Bug Fixes

* add fs files to nuget for fable ([50dc01b](https://gitlab.com/oceanbox/Fable.SignalR/commit/50dc01bbaf89f813de277d686e4d0c558f13c56a))

## [1.2.1](https://gitlab.com/oceanbox/Fable.SignalR/compare/v1.2.0...v1.2.1) (2024-04-23)


### Bug Fixes

* add missing Fable.SingalR base package ([e4d9607](https://gitlab.com/oceanbox/Fable.SignalR/commit/e4d960716655d62daa7aa06884aa2b0bd200ae71))

# [1.2.0](https://gitlab.com/oceanbox/Fable.SignalR/compare/v1.1.0...v1.2.0) (2024-04-22)


### Features

* pack Shared and AspNetCore, and rm Oceanbox from package name ([3156ef9](https://gitlab.com/oceanbox/Fable.SignalR/commit/3156ef968a493b058cd4a92025d321e171d0fa66))

# [1.1.0](https://gitlab.com/oceanbox/Fable.SignalR/compare/v1.0.0...v1.1.0) (2024-04-22)


### Features

* pack Saturn, update deps, and add Oceanbox to package name ([2fd1305](https://gitlab.com/oceanbox/Fable.SignalR/commit/2fd130593235df132028f3b9888c9e0403a1015a))

# 1.0.0 (2024-04-16)


### Bug Fixes

* add missing semantic-release dependency ([88a2472](https://gitlab.com/oceanbox/Fable.SignalR/commit/88a2472bf7e6ce7df106d006de3a47fbb2ea5dc7))
* add paket to devcontainer ([88bc481](https://gitlab.com/oceanbox/Fable.SignalR/commit/88bc4812771a2634df405f61051a597a1bdd9417))
* disable stale paket references ([1b9eaa0](https://gitlab.com/oceanbox/Fable.SignalR/commit/1b9eaa03dbc619cc2696211bc19009f5ae2022f6))
* remove repository from package.json, interferes with semrel ([e16a34c](https://gitlab.com/oceanbox/Fable.SignalR/commit/e16a34cef79c445ac845972d43fa5c53c0c3e4ea))
* upgrade sematic release to 22 ([ef5dfd4](https://gitlab.com/oceanbox/Fable.SignalR/commit/ef5dfd48fbf604bb3ee3fcf803882edadc08a671))
* upgrade to net7 ([b63c2c2](https://gitlab.com/oceanbox/Fable.SignalR/commit/b63c2c2c47e03876bf5394f99a194dc5b45eb19e))


### Features

* add cicd packaing support ([6fb5c37](https://gitlab.com/oceanbox/Fable.SignalR/commit/6fb5c377af69e8d8f75a70949bce1f7fa224a498))
* ugrade to net8 ([edc0287](https://gitlab.com/oceanbox/Fable.SignalR/commit/edc0287f87aacc85eca6657230356f65beb914fc))

### 0.11.6 - tbd
* Add .NET 6 support

### 0.11.5 - Tuesday, June 29th, 2021
* Update client side JSON serialization to remove warnings in Fable 3

### 0.11.4 - Wednesday, April 7th, 2021
* MsgPack optimizations

### 0.11.3 - Friday, March 19th, 2021
* Fix nuget package dependency restrictions

### 0.11.2 - Friday, January 22nd, 2021
* Fix framework targeting

### 0.11.1 - Monday, December 28th, 2020
* Make ConfigBuilder Build method public

### 0.11.0 - Friday, November 20th, 2020
* Support FSharp.Core 5.0
* Add .NET 5 support

### 0.10.1 - Friday, October 23rd, 2020
* Add target netstandard for dotnet client

### 0.10.0 - Friday, October 23rd, 2020
* Fix MsgPack protocol issue
* Add support for using the ISignalRServerBuilder

### 0.9.0 - Friday, October 23rd, 2020
* Added support for the .NET client

### 0.8.3 - Tuesday, October 13th, 2020
* Fix issue with MsgPack protocol handling when messages
are batched

### 0.8.2 - Monday, October 12th, 2020
* Pin Fable.SimpleJson
* Use Fable.Remoting.MsgPack for serialization

### 0.8.1 - Sunday, September 20th, 2020
* Fix Fable compilation

### 0.8.0 - Sunday, September 20th, 2020
* Add message pack support

### 0.7.1 - Thursday, September 17th, 2020
* Fix femto configuration

### 0.7.0 - Thursday, September 17th, 2020
* Added support for getting hub context via DI

### 0.6.2 - Thursday, September 2nd, 2020
* Update dependencies

### 0.6.1 - Wednesday, August 12th, 2020
* Fix routing middleware not being applied if a config is not given

### 0.6.0 - Tuesday, August 11th, 2020
* Add support for authorizatation
* Add websocket middleware to support bearer authentication

### 0.5.0 - Tuesday, July 28th, 2020
* Expose more of the hub context for invocations

### 0.4.1 - Thursday, July 23rd, 2020
* Fix an issue with invocation caller resolution

### 0.4.0 - Friday, July 10th, 2020
* Make invoke server api asynchronous - thanks @Prunkles

### 0.3.0 - Friday, July 3rd, 2020
* Add support for dependency injection in hub functions

### 0.2.0 - Thursday, July 2nd, 2020
* Remove ISubscription infavor of System.IDisposable casting
* Add SignalR.logger to make creating an ILogger easier

### 0.1.0 - Wednesday, July 1st, 2020
* Initial release
