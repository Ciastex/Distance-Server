pkill -f DistanceServer
find /home/deployed/Servers -mindepth 1 -maxdepth 1 -type d \( ! -name . \) -exec bash -c "echo {}; nohup /home/deployed/DistanceServer/DistanceServer.x86_64 -logFile {}/Server.log -serverDir {} &>/dev/null &" \;