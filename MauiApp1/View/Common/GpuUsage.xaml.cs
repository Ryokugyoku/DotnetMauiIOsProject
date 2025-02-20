namespace MauiApp1.View.Common;
using System.Timers;
public partial class GpuUsage : ContentView
{
    private Timer _timer;
    
    public GpuUsage()
    {
        InitializeComponent();
        StartGpuUsageMonitoring();
    }
    
    private void StartGpuUsageMonitoring()
    {
        _timer = new Timer(1000); // 1秒間隔
        _timer.Elapsed += OnTimedEvent;
        _timer.AutoReset = true;
        _timer.Enabled = true;
    }

    private void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        string gpuUsage = Hardware.GpuUsage.GetGpuUsage();
        try
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                GpuUsageLabel.Text = gpuUsage;
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


    }
}