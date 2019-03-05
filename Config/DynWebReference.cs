//呼叫web server
HardwareService.HardwareInfo hw = new HardwareService.HardwareInfo();

//依IP更新WEB參考URL
IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
foreach (IPAddress ip in host.AddressList)
  if (ip.AddressFamily == AddressFamily.InterNetwork)
  {
    if (ip.ToString() == ConfigValue("Uat.Ip"))
      hw.Url = ConfigValue("Uat.WebReferences");
    else
      hw.Url = ConfigValue("Prod.WebReferences");
  }
