# Developer Notes

This section is misc developer notes.  Things that might be needed for the project or helpers

## Required Software

* Visual Studio 2022
* Microsoft Report Viewer
* Visual Studio Installer
* MS Access Drivers 32-bit
* .Net Framework 4.8.1

## Other Helpers

* [xmldoc2md](https://charlesdevandiere.github.io/xmldoc2md/)

## xmldoc2md

'''cmd
xmldoc2md BurnSoft.Applications.MLL.dll --output docs --github-pages --back-button --index-page-name README
'''

## Questionable Tables

Some of these tables where created and started in the database but nothingn in code, it will take a while after the project
is updated to see if it is still needed or not.  The Following tables in question are:

* General_Suggested_Use
* List_Bullets_Picture
* List_Bullets_SU
* List_Bullets_SupportingCaliber
* GunCollectionAmmoData