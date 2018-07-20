# Music Book Index Search
[![Build status](https://ci.appveyor.com/api/projects/status/29f755hd7v02tx3c/branch/master?svg=true)](https://ci.appveyor.com/project/Sogolumbo/music-book-index-search/branch/master)
### A tool to quickly find songs in music book pdfs.
Imagine you 're at a jam session: Someone proposes a song (e.g. "Someone For My Lady"). Normally you would have to go through the table of contents of the first real book but wouldn't find it until you opened the second real book. Then your next challenge would be finding the right page as the pdf page numbers don't match the table of contents.

With this simple tool you just start typing the name of your song and imediately see the right entry. Then you just double click on the song and imediately the pdf viewer shows you the right page of the real book.

## How it works
The system is based on .csv index files. There are many index files for The Real Book and other common jazz music books in [book-indices](https://github.com/aspiers/book-indices).
The pdf viewer which is used to display the music books is [SumatraPDF](https://www.sumatrapdfreader.org) which is really light weight.

## Platform specifications
The program runs on Windows 32bit and 64bit systems and requires the [.NET Framework Runtime 4.6.1 or newer](https://www.microsoft.com/net/download/windows).

## Setup
0. Make sure that you have the [.NET Framework Runtime 4.6.1 or newer](https://www.microsoft.com/net/download/windows) installed (most likely it's already there).
1. [Get the binariy files](https://ci.appveyor.com/project/Sogolumbo/music-book-index-search/branch/master) (*.exe and *.dll) for Music-Book-Index-Search.
2. Get the .csv files with the indices for your music books (download from [book-indices](https://github.com/aspiers/book-indices) or create your own).
3. Download [SumatraPDF](https://www.sumatrapdfreader.org).
4. Open Music-Book-Index-Search and go to Options.
5. Select your music book pdf file and the corresponding index csv file and add them.

Finished - you can now search your music sheet library.
