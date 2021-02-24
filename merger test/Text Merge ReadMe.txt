Text Merge 2.0

Text Merge 2.0 has an auto run function, which can be activated through the command line.

Normal run of the application is Text_Merge.exe
Auto Run mode is Text_Merge.exe hide

This mode will run with the interface hidden from the user.
Auto Run mode is dependant on two files.

textmerge.cfg (which is created by Text Merge if the file does not exist)
and
filelist.txt (which is created by you and contains a list of the path and file names to be merged)

Within textmerge.cfg you have the option to change the name of filelist.txt to anything you like.

Below is a copy of textmerge.cfg and the meanings of the entries.

HeaderOption=0		(0=No Header Stripping, 1=All Header Stripping, 2=All But First File Header Stripping
LinesInHeader=0		(0 is the number of lines in the header)
SpacingOption=0		(0=No Line Spacing Between Merged Files, 1=Line Spacing Between Merged Files
LinesInSpacing=0	(0 is the number of lines in the header)
MergeFile=C:\programs\text merge\merge0.txt	(Path and Name to Final Merged file)
FileList=C:\programs\text merge\filelist.txt	(Path and Name of File Which Contains List of Files to be Merged)
