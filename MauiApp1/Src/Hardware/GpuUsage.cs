namespace MauiApp1.Hardware;
using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using System.Diagnostics;
using MauiApp1.Properties;
public class GpuUsage
{
    private static readonly Random _random = new Random();
    /// <summary>
    /// 数値生成デモプログラム
    /// </summary>
    /// <returns></returns>
    public static string GetGpuUsage()
    {
        int randomUsage = _random.Next(0, 101); // 0から100の範囲でランダムな数値を生成
        return Resources.GpuHello + randomUsage ;
    }
    
}