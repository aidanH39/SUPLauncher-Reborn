![](https://superiorservers.co/static/images/site-logo_reduced.png)
# SUPLauncher | Reborn (UNOFFICIAL)
### V3.1.0

**ONLY COMPATIBLE WITH WINDOWS 10 / 11 ATM**

SUPLauncher is a application built for using while playing [Superior Servers](https://superiorservers.co) it includes many features for regular users, and staff members. I built this for my self mainly, to develop skills, and keep practising what i already know, but it is fun to develop these applications.

# Install guide
V3.0.0 is kinda easier to install than previous versions, but at the same time not? The certificate is the hard part. Let me show you.
They are two ways you can go about installing this.

## Windows

**Install using powershell script (Included)**
This will install the certificate for you and then install the package. Quick and easy, but no GUI.

1. Download the .zip file from the releases tab, then once downloaded extract to a folder.
2. In the folder, they will be a powershell script called Install.ps1, Right click and click Run with powershell
   ![GIF to show what to click](https://i.imgur.com/yMQn5Po.gif)
3. If install completes the app will be available in the start menu, or just by searching for it.

**Install the certificate manually**
1. Download the .zip file from the releases tab, then once downloaded extract to a folder.
2. Click on the .cer file should be called something like `SUPLauncher Package_3.x.x.x_x86_x64.cer`
3. Click `Install Certificate`
4. Click Local Machine then Next (Admin privileges may be needed)
5. Click 'Place all Certificates in the following store'
6. Search for and click 'Trusted People' then click OK
7. Click Next, and then Finish. If all done correctly should get a popup saying Import successful or something like that
   
![](https://i.imgur.com/KYe9LZD.gif)

9. Once that is all done, just open the .appxbundle and you will get a install GUI like your installing something from the store, Just click install.

# Features:
* **Dupe Manager** - Import & delete dupes easily, with the dupe manager. In the latest version (V3.0.0) they is also a quick share feature, that creates a tiny url, directly to download the shared dupe, with this link you can download locally, or import to the SUPLauncher if it is installed what will place the dupe automaticlly in the correct place.
* **Overlay** - Overlay is a very useful feature, it will go over Garrys Mod and you can easily interact with windows, and other features, works great with staff tools.
* **Staff tool** - Easily lookup player's PO's and other infomation quick and easy, all you have to do is enable it in settings, once doing so it will show a profile in the top left when you copy a steamid, keybinds are available to hide and show PO's.
* **AFK Mode** - A classic feature from the old sup launcher, you can set your garrys mod to be running in the background and stay connected to the server, this will use less resources as they will be no visuals and will stay in the background. You can also enable this to automatically start when GMOD is closed, works great with the "Windows Startup" option as well, will launch Garrys Mod as soon as your computer is logged on.
* **Automatic game content downloading** - When launching into a server, they will be checks to make sure you have the required content, only CSS (Counter Strike Source) textures are downloaded at the moment. Hoping to improve on this more in the future, but i need to know what files to download.
* **Launch easily into any SUP server** - When launching the application you can select any servers to connect to.
* **Easy dupe sharing** - Create a quick link for another person to download a dupe easily. **TODO** Allow users to set a expire time on the link. DEFAULT is 12 hours.
* **In-Game Browser** - Call this over the top, but its pretty cool, instead of using the steam browser and having no control over GMOD while your viewing the browser, use this and you can pin it whereever on the screen, and interact with it.

## SOME TIPS FOR THE OVERLAY
* They is a pin button in the top right on windows, click that to pin the window, and that window will display even if you close the overlay.
* If you are trying to interact with a pinned window while in-game, hit F3 to unlock your cursor and then you are free to interact with any window.



## Planned features for after v3.0.0
* More file checks when launching into a server. I would like to download all the sup content required. But i am not sure on what files in the garrys mod directory i need. So if anyone has a list, please msg me them on the forums and i can sort it out.
* While downloading file content, allow them to play the server, while downloading, and when the download is finished give them a option to restart with game content installed.
* Allow users to set expire time on quick share dupe links
* Add SteamID friend checker back.

