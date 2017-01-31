# Rhythm.Parsing.Core

<table>
<tbody>
<tr>
<td><a href="#emailparsing">EmailParsing</a></td>
<td><a href="#filenameparsing">FilenameParsing</a></td>
</tr>
<tr>
<td><a href="#numberparsing">NumberParsing</a></td>
<td><a href="#urlparsing">UrlParsing</a></td>
</tr>
</tbody>
</table>


## EmailParsing

Assists with email parsing tasks.

### IsEmailInValidFormat(email)

Indicates whether or not the specified email address is in a valid format.

| Name | Description |
| ---- | ----------- |
| email | *System.String*<br>The email address. |

#### Returns

True, if the email address is in a valid format; otherwise, false.

#### Remarks

This code is based on this Stack Overflow answer: http://stackoverflow.com/a/1374644/2052963


## FilenameParsing

Assists with filename parsing tasks.

### #cctor

Static constructor.

### InvalidFilenameChars

The characters to exclude when sanitizing filenames.

### SanitizeFilename(source, replaceChar)

Sanitizes a source string for use as a filename.

| Name | Description |
| ---- | ----------- |
| source | *System.String*<br>The source string to sanitize. |
| replaceChar | *System.String*<br>Optional. The character to use to replace invalid characters. If unspecified, invalid characters will be removed entirely. |

#### Returns

The sanitized string.

#### Remarks

For extra safety, this will exclude some characters that are not strictly prohibited from being part of filenames (e.g., the period character).


## NumberParsing

Assists with number parsing tasks.

### AttemptParseInt(value)

Attempts to parse an integer.

| Name | Description |
| ---- | ----------- |
| value | *System.String*<br>The string version of the integer. |

#### Returns

The integer, if it could be parsed; otherwise, null.


## UrlParsing

Assists with URL parsing tasks.

### #cctor

Static constructor.

### FirstSegmentRegex

The regex used to match the first segment of a path.

### GetPathAndQueryFromUrl(url)

Safely extracts the path and query string portion from a URL, regardless of whether or not that URL has a domain.

| Name | Description |
| ---- | ----------- |
| url | *System.String*<br>The URL (e.g., "http://www.rhythmagency.com/some-path?some=query"). |

#### Returns

The path (e.g., "/some-path?some=query").

### GetPathFromUrl(url)

Safely extracts the path portion from a URL, regardless of whether or not that URL has a domain.

| Name | Description |
| ---- | ----------- |
| url | *System.String*<br>The URL (e.g., "http://www.rhythmagency.com/some-path?some=query"). |

#### Returns

The path (e.g., "/some-path").

#### Remarks

Will not include the query string.

### RemoveFirstSegmentFromPath(path)

Removes the first segment from a URL path.

| Name | Description |
| ---- | ----------- |
| path | *System.String*<br>The path (e.g., "/unwanted-segment/about/company"). |

#### Returns

The path without the first segment (e.g., "/about/company").
