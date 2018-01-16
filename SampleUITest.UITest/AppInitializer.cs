using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace SampleUITest.UITest
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                string pathApk = "../../../SampleUITest/SampleUITest.Android/bin/Release/com.companyname.SampleUITest.apk";
                return ConfigureApp
                    .Android
                    .ApkFile(pathApk)
                    //.InstalledApp("com.companyname.SampleUITest")
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}

