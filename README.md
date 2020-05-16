# PDFMerge
[Merge pdfs in the browser](https://hhmagnus.github.io/PDFMerge/)

# Description
This project aims to provide a free browser application to merge pdfs. It strives to provide privacy and ease-of-use to the end user. It uses [Github Pages](https://pages.github.com/) to provide a completely free platform for hosting, which allows the application to be completely free for both the developer and the end user.

## Technical details
The project uses [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor) to build a [Webassembly](https://webassembly.org/) application. Essentially the application is written in a mix of [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) and [HTML](https://developer.mozilla.org/en-US/docs/Web/HTML)/[Javascript](https://developer.mozilla.org/en-US/docs/Web/JavaScript). Using [Github Actions](https://github.com/features/actions) the source code is automatically build and deployed to [Github Pages](https://pages.github.com/). It uses a library called [PdfSharp](http://www.pdfsharp.net/) to handle pdf merging.
### Dependencies
[InputFile](https://blog.stevensanderson.com/2019/09/13/blazor-inputfile/)  
[PdfSharp](http://www.pdfsharp.net/)