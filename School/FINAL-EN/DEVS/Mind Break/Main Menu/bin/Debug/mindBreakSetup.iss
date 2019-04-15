; MindBreak project
; Demonstrates copying 3 files and creating an icon.

; SEE THE DOCUMENTATION FOR DETAILS ON CREATING .ISS SCRIPT FILES!

[Setup]
AppName=MindBreak
AppVersion=1.0
DefaultDirName={pf}\MindBreak
DefaultGroupName=MindBreak
UninstallDisplayIcon={app}\MindBreak.exe
Compression=lzma2
SolidCompression=yes
OutputDir=e:/Setup

[Dirs]
Name: "{app}\Pictures"
Name: "{app}\TEXT"

[Files]
Source: "MindBreak.exe"; DestDir: "{app}"   
Source: "MindBreak.exe.config"; DestDir: "{app}"
Source: "MindBreak.pdb"; DestDir: "{app}"
Source: "words.txt"; DestDir: "{app}";
Source: "Pictures\*"; DestDir: "{app}\Pictures"
Source: "TEXT\*"; DestDir: "{app}\TEXT"

[Icons]
Name: "{group}\MindBreak"; Filename: "{app}\MindBreak.exe"
Name: "{commondesktop}\MindBreak"; Filename: "{app}\MindBreak.exe"