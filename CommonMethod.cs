using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace XF.CommonLibrary
{
    public class CommonMethod
    {
        public static bool CheckIsIphoneX()
        {
            var device = DeviceInfo.Model;
            return (device == "iPhone10,3" || device == "iPhone10,6" //Iphone X
                || device == "iPhone11,8"   //Iphone XR
                || device == "iPhone11,2"   //Iphone XS
                || device == "iPhone11,4" || device == "iPhone11,6" //Iphone XS Max
                || device == "iPhone X Simulator");
        }

        public static Thickness GetSafeAreaPaddingiOSX(Xamarin.Forms.Page page)
        {
            if (CommonMethod.CheckIsIphoneX())
            {
                var safeInsets = page.On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
                var orientation = DeviceDisplay.MainDisplayInfo.Orientation;
                if (orientation == DisplayOrientation.Portrait)
                {
                    safeInsets.Right = 30;
                    safeInsets.Left = 30;
                }
                else if (orientation == DisplayOrientation.Landscape)
                {
                    safeInsets.Right = 30;
                    safeInsets.Left = 30;
                }
                return safeInsets;
            }
            else return 0;
        }
    }
}
