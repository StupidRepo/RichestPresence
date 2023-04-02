# RichestPresence
A simple C# Discord RPC changer!
## How To Use
1. Download the latest release from [here](https://github.com/StupidRepo/RichestPresence/releases) that corresponds to your operating system.
2. Extract the ZIP to a folder, e.g. StupidRPC.
3. Open the folder and run the executable.
4. Follow the instructions in the program.
5. Enjoy!

## How To Build
1. Clone the repository.
2. Download Discord Game SDK from [here](https://discordapp.com/developers/docs/game-sdk/sdk-starter-guide).
3. Put the files from the `csharp` folder in the Discord SDK into a new folder in the repository folder called `Discord`.
4. Open up a Terminal/Command Prompt.
5. Navigate to the repository's folder in the Terminal/Command Prompt.
6. Run `dotnet publish -c Release -r [os]-x64`. Replace `[os]` with `win` for Windows, `linux` for Linux distros, or `osx` for macOS.
7. The executable will be in the `bin/Release/[os]-x64/publish` folder.
8. To run the executable, make sure to put the files in the Discord SDK's `lib/x86_64` folder in the same folder as the executable.
9. Now you can actually double click on the executable file and it'll work.
10. Enjoy!

## Credits
Thank you to:
- [Discord Game SDK](https://discordapp.com/developers/docs/game-sdk/sdk-starter-guide) for the RPC libraries.
- [BepInEx](https://github.com/BepInEx/BepInEx) for allowing me to understand C# better, and for the plugin I made for a game that has Discord RPC support which this project literally is.
  - TLDR - I made a BepInEx plugin for a game that had Discord RPC and I just copied the code over to this project.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE.md) file for more information.