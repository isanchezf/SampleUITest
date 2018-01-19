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
                //var pathApk = "../../../SampleUITest/SampleUITest.Android/bin/release/com.companyname.SampleUITest.apk";
                const string pathApk = "C:/Users/isanchez.INTERGRUPO/Desktop/ApkSample/com.companyname.SampleUITest.apk";

                return ConfigureApp
                    .Android
                    .ApkFile(pathApk)
                    //.InstalledApp("com.companyname.SampleUITest")
                    .KeyStore("C:/Users/isanchez.INTERGRUPO/AppData/Local/Xamarin/Mono for Android/Keystore/sampleuitestkey/sampleuitestkey.keystore", "123456", "123456", "sampleuitestkey")
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}

