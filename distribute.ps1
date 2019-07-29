﻿# ビルド
./build.bat

# バージョン取得
$version = [System.Diagnostics.FileVersionInfo]::GetVersionInfo("Build\addons\EnmityOverlay.dll").FileVersion

# フォルダ名
$buildFolder = ".\Build"
$fullFolder = ".\Distribute\EnmityOverlay-" + $version

# フォルダが既に存在するなら消去
if ( Test-Path $fullFolder -PathType Container ) {
	Remove-Item -Recurse -Force $fullFolder
}

# フォルダ作成
New-Item -ItemType directory -Path $fullFolder

# full
xcopy /Y /R /S /EXCLUDE:full.exclude "$buildFolder\*" "$fullFolder"

cd Distribute
$folder = "EnmityOverlay-" + $version

# Download Icons
cd $folder
& ".\ResourceDownloader.exe" "/y"

# アーカイブ
cd ..\
& "C:\Program Files\7-Zip\7z.exe" "a" "$folder.zip" "$folder"

pause
