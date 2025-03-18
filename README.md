# DopamineDetox.Domain

## Description
DopamineDetox.Domain is a .NET 8.0 library that provides domain models and data transfer objects (DTOs) for the Social Media Detox Project. This package is designed to facilitate the management and transfer of data within the application.

## Features
- Domain models for representing core entities.
- Data Transfer Objects (DTOs) for efficient data exchange.
- JSON serialization attributes for seamless integration with web APIs.

## Installation
To install DopamineDetox.Domain, run the following command in the Package Manager Console:


## Usage
### Domain Models
The package includes several domain models such as:
- `Note`: Represents a note with properties like `Id`, `Title`, `Message`, `UserId`, `SearchResultId`, etc.
- `Topic`: Represents a topic used for organizing in a folder-type structure with properties like `Id`, `IsActive`, `Term`, `UserId`, etc.

### Data Transfer Objects (DTOs)
The package also includes DTOs for data transfer:
- `LearnMoreDetailDto`: Contains properties like `Introduction`, `Items`, `QuoteDateFetched`.
- `ContentTypeDto`: Inherits from `BaseDto` and includes properties like `Id`, `Title`, `Description`.
- `HistorySearchResultDto`: Inherits from `BaseDto` and includes properties like `Id`, `Title`, `Description`, `UserName`, `Url`, `EmbedUrl`, `VideoId`, `ThumbnailUrl`, `PublishedAt`, `SubTopicTerm`, `ChannelName`, `ContentTypeName`.
- `SearchResultDto`: Contains properties like `Id`, `Title`, `Description`, `UserName`, `Url`, `EmbedUrl`, `VideoId`, `ThumbnailUrl`, `PublishedAt`, `Term`, `ChannelName`, `ContentTypeId`, `IsHomePage`, `IsChannelResult`, `TopSearchResult`, `EmbeddedHtml`, `DateAdded`, `IsChannel`, `Notes`, `TopSearchResults`.

## Contributing
Contributions are welcome! Please open an issue or submit a pull request on GitHub.

## License
This project is licensed under the MIT License. See the LICENSE file for more details.

## Authors
- Ryan Roethle


