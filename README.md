# BackpackOculus_Opti-tracking
A project that replaces the default Oculus Rift tracking sensors with OptiTrack rigid-bodies for large-scale room tracking.

# Setting up the project
**(Optional) Disable Tracking when Oculus Sensors are plugged in:** Locate and open the steamvr.vrsettings file. (Default dir: C:\Program Files (x86)\Steam\config) Search for: "forceFadeOnBadTracking", and set the value to false. This completely disables oculus sensor positional data.

Alternatively just unplug the Oculus Sensors completely.

**Basic steps for setting up:**
1. Launch the Motive Tracking.tpp file. (Ensure the Opti-Track environment has been correctly calibrated)
2. Open the repository in Unity and set the NetworkManager as either the Host or Client. (recommended 2018.3.8f1, the project is currently using a basic Unity Network architecture which is depreciated in 2019+ Unity versions)
3. Launch the Unity Application either in the Editor or as a stand-alone Build. (SteamVR should automatically open)
- Note: Running the application within the Editor will produce poor FPS and tracking, stand-alone Build is recommended)
4. Connect an Oculus controller, put on the VR headset (with the OptiTrack markers attached), a message will appear 'Critical Error: We can't find your sensor..'. Use the Oculus controller to press Okay and the application will launch.
