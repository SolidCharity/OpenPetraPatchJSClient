--- a/csharp/ICT/Common/Remoting/Server/ServerSettings.cs
+++ b/csharp/ICT/Common/Remoting/Server/ServerSettings.cs
@@ -427,6 +427,11 @@ namespace Ict.Common.Remoting.Server
             FClientKeepAliveTimeoutAfterXSecondsRemote =
                 TAppSettingsManager.GetInt32("Server.ClientKeepAliveTimeoutAfterXSeconds_Remote", (ClientKeepAliveTimeoutAfterXSecondsLAN * 2));
 
+            // workaround for browser based client. allow one hour of browsing.
+            // TODO we do not have a keep alive mechanism there
+            FClientKeepAliveTimeoutAfterXSecondsRemote =
+                TAppSettingsManager.GetInt32("Server.ClientKeepAliveTimeoutAfterXSeconds_Remote", 60*60);
+
             // Server.ClientConnectionTimeoutAfterXSeconds
             FClientConnectionTimeoutAfterXSeconds = TAppSettingsManager.GetInt32("Server.ClientConnectionTimeoutAfterXSeconds", 20);

