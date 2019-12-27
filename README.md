# IbanNet.Extensions.Bban

IbanNet.Extensions.Bban is an https://github.com/skwasjer/IbanNet extension library providing functionality to validate a [Basic Bank Account Number](https://en.wikipedia.org/wiki/International_Bank_Account_Number#Basic_Bank_Account_Number) also known as BBAN.

## Installation

Install IbanNet.Extensions.Bban via the Nuget package manager or `dotnet` cli.

```powershell
Install-Package IbanNet.Extensions.Bban
```
---

[![Build status](https://ci.appveyor.com/api/projects/status/TODO/branch/master?svg=true)](https://ci.appveyor.com/project/skwasjer/ibannet-extensions-bban)
[![Tests](https://img.shields.io/appveyor/tests/skwasjer/IbanNet.Extensions.Bban/master.svg)](https://ci.appveyor.com/project/skwasjer/ibannet-extensions-bban/build/tests)
[![codecov](https://codecov.io/gh/skwasjer/IbanNet.Extensions.Bban/branch/master/graph/badge.svg)](https://codecov.io/gh/skwasjer/IbanNet.Extensions.Bban)
[![NuGet](https://img.shields.io/nuget/v/IbanNet.Extensions.Bban.svg)](https://www.nuget.org/packages/IbanNet.Extensions.Bban/) [![NuGet](https://img.shields.io/nuget/dt/IbanNet.Extensions.Bban.svg)](https://www.nuget.org/packages/IbanNet.Extensions.Bban/)

## Supported countries

Country                | Code | Support                     | Documentation 
---------------------- | ---- | --------------------------- | -------------
Norway                 |  NO  | :heavy_check_mark: YES      | [Oracle Cash Management User Guide - Norway](https://docs.oracle.com/cd/E18727_01/doc.121/e13483/T359831T498954.htm#T498969)
Portugal               |  PT  | :heavy_check_mark: YES      | [Número de Identificação Bancária](https://pt.wikipedia.org/wiki/N%C3%BAmero_de_Identifica%C3%A7%C3%A3o_Banc%C3%A1ria)
France                 |  FR  | :heavy_check_mark: YES      | [Clé RIB](https://fr.wikipedia.org/wiki/Cl%C3%A9_RIB)
Monaco                 |  MC  | :heavy_check_mark: YES      | [Clé RIB](https://fr.wikipedia.org/wiki/Cl%C3%A9_RIB)
Mauritania             |  MR  | :heavy_check_mark: YES      | [Clé RIB](https://fr.wikipedia.org/wiki/Cl%C3%A9_RIB)
Italy                 |  IT  | :heavy_check_mark: YES       | [Oracle Cash Management User Guide - Italy](https://docs.oracle.com/cd/E18727_01/doc.121/e13483/T359831T498954.htm#T498993)
San Marino             |  SM  | :heavy_check_mark: YES      | [Oracle Cash Management User Guide - Italy](https://docs.oracle.com/cd/E18727_01/doc.121/e13483/T359831T498954.htm#T498993)
Germany                |  DE  | :heavy_exclamation_mark: NO | [Prüfzifferberechnungsmethoden zur Prüfung von Kontonummern auf ihre Richtigkeit](https://www.bundesbank.de/resource/blob/603320/16a80c739bbbae592ca575905975c2d0/mL/pruefzifferberechnungsmethoden-data.pdf)
Bosnia and Herzegovina |  BA  | :heavy_check_mark: YES      | [CBBH - Instruction on payment account structure](https://www.cbbh.ba/Content/Read/53?lang=en)