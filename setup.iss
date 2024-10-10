#define MyAppName "Ivan"
#define MyAppVersion "1.0.1"
#define MyAppPublisher "ŠSPT"
#define MyAppURL "https://hradebni.cz"
#define MyAppExeName "SediM.exe"

[Setup]
; Identifikátor aplikace - musí být zachován stejný pro všechny verze, aby se starší verze odinstalovala
AppId={{57D1F386-394C-483B-8CCB-771BB9B6D6BE}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DisableDirPage=true
ArchitecturesAllowed=x64
ArchitecturesInstallIn64BitMode=x64
DisableProgramGroupPage=yes
PrivilegesRequired=admin
OutputDir=C:\Users\pvurm\Downloads
OutputBaseFilename=ivan-setup
SetupIconFile=C:\Users\pvurm\OneDrive - SPŠ, SOŠ a SOU, Hradec Králové\Dokumenty\Škola\ŠSPT\projekty\SediM\SediM.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern
UninstallDisplayIcon={app}\{#MyAppExeName}
UninstallRestartComputer=no

[Languages]
Name: "czech"; MessagesFile: "compiler:Languages\Czech.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\pvurm\OneDrive - SPŠ, SOŠ a SOU, Hradec Králové\Dokumenty\Škola\ŠSPT\projekty\SediM\bin\Release\net6.0-windows\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\pvurm\OneDrive - SPŠ, SOŠ a SOU, Hradec Králové\Dokumenty\Škola\ŠSPT\projekty\SediM\bin\Release\net6.0-windows\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[UninstallDelete]
Type: files; Name: "{app}\OldConfigFile.txt"

[Code]
function InitializeSetup(): Boolean;
var
  OldAppDir: String;
  UninstallString: String;
  ResultCode: Integer;
begin
  Result := True;

  if RegQueryStringValue(HKEY_LOCAL_MACHINE, 'Software\Microsoft\Windows\CurrentVersion\Uninstall\{57D1F386-394C-483B-8CCB-771BB9B6D6BE}_is1', 'InstallLocation', OldAppDir) then
  begin
    if RegQueryStringValue(HKEY_LOCAL_MACHINE, 'Software\Microsoft\Windows\CurrentVersion\Uninstall\{57D1F386-394C-483B-8CCB-771BB9B6D6BE}_is1', 'UninstallString', UninstallString) then
    begin
      if (UninstallString <> '') and (FileExists(UninstallString)) then
      begin
        Exec(UninstallString, '/VERYSILENT /NORESTART', '', SW_HIDE, ewWaitUntilTerminated, ResultCode);
        if ResultCode <> 0 then
        begin
          MsgBox('Nepodařilo se automaticky odinstalovat předchozí verzi. Prosím, odinstalujte ji ručně a zkuste to znovu.', mbError, MB_OK);
          Result := False;
        end;
      end;
    end;
  end;
end;
