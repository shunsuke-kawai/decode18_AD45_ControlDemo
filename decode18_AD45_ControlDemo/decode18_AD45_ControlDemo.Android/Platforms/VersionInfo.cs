using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using decode18_AD45_ControlDemo.Droid.Platforms;
using decode18_AD45_ControlDemo.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(VersionInfo))]
namespace decode18_AD45_ControlDemo.Droid.Platforms
{
    class VersionInfo : IVersionInfo
    {
        public string GetVersion()
        {
            Context context = Android.App.Application.Context;
            return context.PackageManager.GetPackageInfo(context.PackageName, 0).VersionName;
        }
    }
}