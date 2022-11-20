#nullable disable
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Avalonia;
using Avalonia.Platform;
using System.Reflection;
using Pchp.Core;

namespace Apf.Platform;


public class UxAssetLoader
{
    private static readonly IAssetLoader Asset = AvaloniaLocator.Current.GetService<IAssetLoader>();

    public static PhpValue? Open(Uri uri, Uri baseUri = null)
    {

        return PhpValue.FromClr(Asset?.Open(uri));
    }

    public static IEnumerable<Uri> GetAssets(Uri uri, Uri baseUri = null)
    {
        return Asset?.GetAssets(uri, baseUri).ToArray();
    }


    public static void SetDefaultAssembly(Assembly assembly)
    {
        Asset?.SetDefaultAssembly(assembly);
    }

    public static bool Exists(Uri uri, Uri baseUri = null)
    {
        return Asset!.Exists(uri, baseUri);
    }

    public static (Stream stream, Assembly assembly)? OpenAndGetAssembly(Uri uri, Uri baseUri = null)
    {
        return Asset!.OpenAndGetAssembly(uri, baseUri);
    }

    public static Assembly GetAssembly(Uri uri, Uri baseUri = null)
    {
        return Asset!.GetAssembly(uri, baseUri);
    }
}