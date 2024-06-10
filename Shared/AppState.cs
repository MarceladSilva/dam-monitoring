namespace dam_monitoring.Shared;

public static class AppState
{
    public const string URL_SIGNALR = "http://localhost:5160/monitoring";
    public const string SEND_MONITORING = "SendMonitoring";
    public const string RECEIVE_MONITORING = "ReceiveMonitoring";
    
    public static int Monitoring;
}
