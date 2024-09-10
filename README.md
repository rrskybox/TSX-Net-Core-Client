TSX Net Core Client is a C# Wrapper that translates a bunch of TheSky COM interface properties and methods into a set of TSX TCP property and methods. The port number for TSX is hardwired in Link.cs, but can be changed or made configurable, if desired. Usage: Pull copy of project. Create custom library (dll) and reference from your automation project instead of TheSKy64Lib.

Wrapper supported objects:

Application

ccdSoftCamera

sky6RASCOMTele

AutomatedImageLink

ClosedLoopSlew

ImageLink

SelectedHardware

ccdSoftImage

sky6DateWizard

sky6Dome

sky6MyFOV

sky6ObjectInformation

sky6StarChart

sky6Utils

sky6RASCOMTheSky
