# AMS.Profile.2
## Description
Same thing as AMS.Profile, but with the ability to change entry and section names inside an .ini file.

## Added Features
Here are the features that don't exist on the original that I added:
  - `Ini.ChangeSectionName(string, string)`
    - You give the original name and the new name, and the old is replaced by the new.
  - `Ini.ChangeEntryName(string, string, string)`
    - You give the specific section, the original entry name, and the new entry name, and the old is replaced by the new.
  - `Ini.AddSection(string)`
    - Adds a new section to the current INI file without having to remove temporary entries for later use.
  - `IniReader.ReadConfig(string)`
    - Reads an ini-config file into a structurized dictionary. (format: <string, <string, string>>)

## How It Works
### Ini.ChangeSectionName(string, string)
1. Uses the [`StreamReader`](https://docs.microsoft.com/en-us/dotnet/api/system.io.streamreader?view=net-6.0) class to get the original file contents.
2. Replaces the section name found in the file string with the new name.
3. Uses the [`File`](https://docs.microsoft.com/en-us/dotnet/api/system.io.file?view=net-6.0) class to delete the original file and create a new blank one.
4. Uses the [`StreamWriter`](https://docs.microsoft.com/en-us/dotnet/api/system.io.streamwriter?view=net-6.0) class to re-write the file with the new section name.

### Ini.ChangeEntryName(string, string, string)
This is an iteration loop by the way.
1. Gets the value of the entry in the current iteration.
2. Uses `Ini.RemoveEntry(string, string)` in the original dll to remove the entry in the current iteration.
3. Re-creates the entry with its original value in the current iteration, and uses the new name specified if it matches the original name given.

### IniReader.ReadConfig(string)
There is a nested loop in this by the way.
1. Uses `Ini.GetSectionNames()` to get every section.
2. Creates a dictionary for storing all entries of the current section.
3. Uses `Ini.GetEntryNames(string)` to get every entry in the current section iteration.
4. Stores each entry and its value in the current section dictionary.
5. Stores the entry dictionary for the current section and the current section name in the config info.

## Code Has Been Tested
I have tested both methods with an ini file containing several sections, and several entries for each section. I made everything was in order every time there was a change in the file without something be added.

## Download
[AMS.Profile.2.dll](https://github.com/Lexz-08/AMS.Profile.2/releases/download/ams.profile.2/AMS.Profile.2.dll)

## Original DLL
[AMS.Profile](https://www.nuget.org/packages/Ams.Profile/)
