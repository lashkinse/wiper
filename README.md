# Description
An application made for ARK: Survival Evolved for easy server wipes.

# Configuration
All configuration is done inside a config file on disk via JSON.
```
{
  // files for cleanup
  "temporary_files": [
    "*.log",
    "*.db",
    "*.db-shm",
    "*.db-wal",
    "*.ark",
    "*.arktribe",
    "*.tribebak",
    "*.arktributetribe",
    "*.arkprofile",
    "*.profilebak",
    "*.bak",
    "*.pnt",
    "*.crashstack",
    "unreal*.dmp",
    "UnrealAutoReportDump*.txt",
    "UnrealAutoReportIniDump*.txt",
    "connection_log_*.txt",
    "stats_log.txt",
    "content_log.txt",
    "service_log.txt"
  ],
  
  // paths to clusters files
  "clusters": [
    {
      "name": "cluster0",
      "root": "C:\\asmdata\\cluster0"
    }
  ],
  
  // paths to servers files
  "servers": [
    {
      "name": "server1",
      "root": "C:\\asmdata\\Servers\\Server1"
    }

  ]
}
```
