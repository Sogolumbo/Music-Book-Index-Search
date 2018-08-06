# Music Book Index Search
[![Build status](https://ci.appveyor.com/api/projects/status/29f755hd7v02tx3c/branch/master?svg=true)](https://ci.appveyor.com/project/Sogolumbo/music-book-index-search/branch/master)
### A tool to quickly find songs in music book pdfs.
Imagine you 're at a jam session: Someone proposes a song (e.g. "Someone For My Lady"). Normally you would have to go through the table of contents of the first real book but wouldn't find it until you opened the second real book. Then your next challenge would be finding the right page as the pdf page numbers don't match the table of contents.

With this simple tool you just start typing the name of your song and imediately see the right entry. Then you just double click on the song and imediately the pdf viewer shows you the right page of the real book.

## Platform specifications
The program runs on Windows 32bit and 64bit systems.
### Requirements
* [.NET Framework Runtime 4.6.1 or newer](https://www.microsoft.com/net/download/windows).
* [SumatraPDF](https://www.sumatrapdfreader.org)
* Indeces of your pdf files in the CSV-Format like this:
	`<Song title>, <first page>, <last page (optional)>`	e.g.: `"Raven, The", 89, 90` [(more details)](https://github.com/aspiers/book-indices/blob/master/README.md#file-format)


## Setup
0. Make sure that you have the [.NET Framework Runtime 4.6.1 or newer](https://www.microsoft.com/net/download/windows) installed (most likely it's already there).
1. [Download the binary files](https://ci.appveyor.com/project/Sogolumbo/music-book-index-search/branch/master) (*.exe and *.dll) for Music-Book-Index-Search.
2. Get the .csv files with the indices for your music books (download from [book-indices](https://github.com/aspiers/book-indices) or create your own).
3. Download [SumatraPDF](https://www.sumatrapdfreader.org).
4. Open Music-Book-Index-Search and go to Options.
5. Select your music book pdf file and the corresponding index csv file and add them.

Finished - you can now search your music sheet library.


## Screenshots
Desktop view:

![music book search screenshot](https://user-images.githubusercontent.com/33571916/43721557-60d40e32-9993-11e8-9566-90f5e30e6646.PNG)

Tablet view with bigger font and bigger spacing between search results:

![music book search tablet view](https://user-images.githubusercontent.com/33571916/42966429-69b5ca12-8b9d-11e8-819d-f73a3fec3350.PNG)


## Contribution
The project is a standard visual studio solution. Feel free to fork, improve, create pull requests and share this project.
