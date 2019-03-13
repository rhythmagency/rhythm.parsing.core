# Introduction

Provides tools to assist with parsing, extraction, and validation (e.g., email, filenames, numbers, URL's).

Refer to the [generated documentation](docs/generated.md) for more details.

# Installation

Install with NuGet. Search for "Rhythm.Parsing.Core".

# Overview

## EmailParsing

* **IsEmailInValidFormat** Validates that a string is formatted as a valid email address.

## FilenameParsing

* **SanitizeFilename** Removes all characters from a string that are unsafe to use in filenames.

## NumberParsing

* **AttemptParseInt** Attempts to parse a string as an integer.
* **AttemptParseLong** Attempts to parse a string as a long.
* **AttemptParseDouble** Attempts to parse a string as a double.
* **AttemptParseDecimal** Attempts to parse a string as a decimal.

## UrlParsing

* **GetPathAndQueryFromUrl** Extracts the path and query string from a URL.
* **GetPathFromUrl** Extracts the path from a URL.
* **RemoveFirstSegmentFromPath** Removes the first segment from the path of a URL.

# Maintainers

To create a new release to NuGet, see the [NuGet documentation](docs/nuget.md).