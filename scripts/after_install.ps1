# PowerShell script: after_install.ps1

# Add your commands or actions to be executed after installation here

# Example: Start a service
Start-Service -Name "MyAppService"

# Example: Set permissions on a directory
$Acl = Get-Acl -Path "C:\MyApplication"
$Acl.SetAccessRuleProtection($true, $false)
Set-Acl -Path "C:\MyApplication" -AclObject $Acl

# End of after_install.ps1 script
