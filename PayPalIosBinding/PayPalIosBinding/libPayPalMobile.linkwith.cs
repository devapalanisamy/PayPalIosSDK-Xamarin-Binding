using System;
using ObjCRuntime;

[assembly: LinkWith ("libPayPalMobile.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.Arm64, SmartLink = true, Frameworks = "AVFoundation GLKit OpenGLES MobileCoreServices UIKit CoreVideo Foundation AudioToolbox CoreBluetooth CoreTelephony MediaPlayer SystemConfiguration QuartzCore CoreLocation CoreMedia MessageUI Accelerate", ForceLoad = true)]