# Description
An application made for ARK: Survival Evolved servers for wipes.

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
    "*.arktributetribe",
    "*.arkprofile",
    "*.profilebak",
    "*.bak",
    "*.pnt",
    "connection_log_*.txt",
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
